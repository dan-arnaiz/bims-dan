using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing.Imaging;
using System.IO;
using static BIMS_dan._dan_bimsBarangayDataset;

namespace BIMS_dan {
public partial class controllerResidents : UserControl {
  public controllerResidents() {
    InitializeComponent();
    this.Load += residentsTable_Shown;
    this.residentsTable.RowsAdded +=
        new DataGridViewRowsAddedEventHandler(residentsTable_RowsAdded);
    this.residentsTable.RowsRemoved +=
        new DataGridViewRowsRemovedEventHandler(residentsTable_RowsRemoved);
    UpdateRowNumbers();
  }

  private async void residentsTable_Shown(object sender, EventArgs e) {
    Database db = new Database();
    await db.RefreshResidentsTableAsync(this.residentsTable);
  }

  private async void ControllerAddNewResidentModal_ResidentAdded(object sender,
                                                                 EventArgs e) {
    Database db = new Database();
    await db.RefreshResidentsTableAsync(this.residentsTable);
  }

  private void residentsTable_RowsAdded(object sender,
                                        DataGridViewRowsAddedEventArgs e) {
    UpdateRowNumbers();
  }

  private void residentsTable_RowsRemoved(object sender,
                                          DataGridViewRowsRemovedEventArgs e) {
    UpdateRowNumbers();
  }

  private void UpdateRowNumbers() {
    foreach (DataGridViewRow row in residentsTable.Rows) {
      row.Cells["numColumn"].Value =
          row.Index +
          1; // Assuming numColumn is the name of your counter column
    }
  }

  private async void searchBarText_TextChanged(object sender, EventArgs e) {
    Database db = new Database();
    TextBox searchBarText = sender as TextBox;
    if (searchBarText != null) {
      try {
        DataTable searchResults =
            await db.SearchResidentAsync(searchBarText.Text);
        residentsTable.DataSource = searchResults;
      } catch (Exception ex) {
        MessageBox.Show($"Error searching resident: {ex.Message}",
                        "Search Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }
    }
  }

  private async void addResidentButton_Click(object sender, EventArgs e) {
    using (Form modalForm = new Form()) {
      ControllerAddNewResidentModal controllerAddNewResidentModal =
          new ControllerAddNewResidentModal();
      modalForm.Controls.Add(controllerAddNewResidentModal);
      controllerAddNewResidentModal.Dock = DockStyle.Fill;
      modalForm.Name = "Add New Resident";
      modalForm.ShowIcon = false;
      modalForm.ShowInTaskbar = false;
      modalForm.Size = new Size(631, 348);
      modalForm.MinimumSize = new Size(631, 348);
      modalForm.MaximumSize = new Size(631, 348);
      modalForm.StartPosition = FormStartPosition.CenterScreen;
      modalForm.ShowDialog();

      controllerAddNewResidentModal.ResidentAdded += (s, ea) => {
        // Refresh the residentsTable DataGridView here
        RefreshResidentsTable();
      };
    }
  }

  private async void RefreshResidentsTable() {
    Database db = new Database();
    await db.RefreshResidentsTableAsync(this.residentsTable);
  }

  private void editResidentButton_Click(object sender, EventArgs e) {
    using (Form modalForm = new Form()) {
      ControllerEditResidentModal controllerEditResidentModal =
          new ControllerEditResidentModal();
      modalForm.Controls.Add(controllerEditResidentModal);
      controllerEditResidentModal.Dock = DockStyle.Fill;
      modalForm.Name = "Edit Resident";
      modalForm.ShowIcon = false;
      modalForm.ShowInTaskbar = false;
      modalForm.Size = new Size(631, 348);
      modalForm.MinimumSize = new Size(631, 348);
      modalForm.MaximumSize = new Size(631, 348);
      modalForm.StartPosition = FormStartPosition.CenterScreen;
      modalForm.ShowDialog();
    }
  }

  private void residentsTable_CellContentClick(object sender,
                                               DataGridViewCellEventArgs e) {}

  private async void refreshResidents_Click(object sender, EventArgs e) {
    Database db = new Database();
    await db.RefreshResidentsTableAsync(this.residentsTable);
  }

  private void AdjustDataGridViewImageColumnSize() {
    int cellSize = 50; // Target size for the image
    residentsTable.RowTemplate.Height =
        cellSize; // Adjust row height to match the image size
    residentsTable.Columns["picture"].Width =
        cellSize; // Adjust column width to match the image size

    residentsTable.CellFormatting += new DataGridViewCellFormattingEventHandler(
        residentsTable_CellFormatting);
  }

  private void
  residentsTable_CellFormatting(object sender,
                                DataGridViewCellFormattingEventArgs e) {
    if (e.ColumnIndex == residentsTable.Columns["picture"].Index &&
        e.Value != null) {
      try {
        // Assuming e.Value is a byte array representing the image
        using (var ms = new MemoryStream((byte[])e.Value)) {
          Image originalImage = Image.FromStream(ms);
          e.Value =
              ResizeImage(originalImage, 50,
                          50); // Resize and set the new image as cell value
        }
      } catch {
        // Handle exceptions or invalid image data here
      }
    }
  }

  private Image ResizeImage(Image image, int width, int height) {
    var destRect = new Rectangle(0, 0, width, height);
    var destImage = new Bitmap(width, height);

    destImage.SetResolution(image.HorizontalResolution,
                            image.VerticalResolution);

    using (var graphics = Graphics.FromImage(destImage)) {
      graphics.CompositingMode =
          System.Drawing.Drawing2D.CompositingMode.SourceCopy;
      graphics.CompositingQuality =
          System.Drawing.Drawing2D.CompositingQuality.HighQuality;
      graphics.InterpolationMode =
          System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
      graphics.SmoothingMode =
          System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      graphics.PixelOffsetMode =
          System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

      using (var wrapMode = new ImageAttributes()) {
        wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height,
                           GraphicsUnit.Pixel, wrapMode);
      }
    }

    return destImage;
  }

  private async void deleteResidentButton_Click(object sender, EventArgs e) {
    if (residentsTable.SelectedRows.Count > 0) {
      var confirmResult =
          MessageBox.Show("Are you sure you want to delete this resident?",
                          "Confirm Delete", MessageBoxButtons.YesNo);
      if (confirmResult == DialogResult.Yes) {
        int idColumnIndex =
            residentsTable.Columns["idDataGridViewTextBoxColumn"]
                .Index; // Ensure this matches the actual column name in your
                        // DataGridView

        Database db = new Database();
        bool refreshNeeded = false;

        foreach (DataGridViewRow row in residentsTable.SelectedRows) {
          if (!row.IsNewRow) {
            // Check for null value before calling ToString()
            var cellValue = row.Cells[idColumnIndex].Value;
            if (cellValue != null) {
              var residentId = cellValue.ToString();
              bool success = await db.DeleteResidentAsync(residentId);
              if (success) {
                residentsTable.Rows.Remove(row);
                refreshNeeded = true;
              } else {
                MessageBox.Show("Failed to delete resident.");
              }
            } else {
              MessageBox.Show("Resident ID is missing.");
            }
          }
        }

        // If at least one row was successfully deleted, refresh the
        // DataGridView
        if (refreshNeeded) {
          await db.RefreshResidentsTableAsync(residentsTable);
        }
      }
    } else {
      MessageBox.Show("Please select a row to delete.");
    }
  }
}

}
