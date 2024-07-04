using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMS_dan {
public partial class ControllerAddNewBarangayModal : UserControl {
  public event EventHandler BarangayAdded;
  public ControllerAddNewBarangayModal() { InitializeComponent(); }

  private void addressLabel_Click(object sender, EventArgs e) {}

  private async void addNewBarangayButton_Click(object sender, EventArgs e) {
    // Check for empty required fields and show an error dialog if any are empty
    if (string.IsNullOrWhiteSpace(BarangayNameTextBox.Text) ||
        string.IsNullOrWhiteSpace(barangayAddressTextBox.Text) ||
        string.IsNullOrWhiteSpace(barangayDescriptionTextBox.Text)) {
      MessageBox.Show("Please fill in all required fields.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
      return; // Stop further execution
    }

    try {
      string directoryPath = "oop-bims-final\\barangayimages\\";
      string defaultImagePath =
          Path.Combine(directoryPath, "tempBarangayLogo.jpg");
      string filename;

      // Check if idImage has an image uploaded and construct the filename
      // accordingly
      if (BarangayLogoImage.Image != null) {
        filename = $"{BarangayNameTextBox.Text}.jpg";
      } else {
        filename = "tempBarangayLogo.jpg"; // Use the default image name
      }

      string imagePath = Path.Combine(directoryPath, filename);
      // Ensure the default image exists if no image is uploaded
      if (!File.Exists(imagePath)) {
        imagePath = defaultImagePath;
      }

      byte[] pictureBarangayData = File.ReadAllBytes(imagePath);
      string BarangayName = BarangayNameTextBox.Text;
      string barangayAddress = barangayAddressTextBox.Text;
      string barangayDescription = barangayDescriptionTextBox.Text;

      // Create an instance of your Database class
      BarangayDB db = new BarangayDB();
      // Call the AddResident method
      await db.AddNewBarangay(pictureBarangayData, BarangayName,
                              barangayAddress, barangayDescription);
      MessageBox.Show("Barangay added successfully!");
      this.ParentForm.Close();
      OnBarangayAdded();
    } catch (Exception ex) {
      MessageBox.Show($"Failed to add Barangay. Error: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }

  protected virtual void OnBarangayAdded() {
    BarangayAdded?.Invoke(this, EventArgs.Empty);
  }

  private byte[] ImageToByteArray(PictureBox pictureBox) {
    using (var ms = new MemoryStream()) {
      pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
      return ms.ToArray();
    }
  }

  private void cancelButton_Click(object sender, EventArgs e) {
    this.ParentForm.Close();
  }

  private void ControllerAddNewBarangayModal_Load(object sender, EventArgs e) {}

  private void uploadBarangayLogoButton_Click(object sender, EventArgs e) {
    string directoryPath = "oop-bims-final\\barangayimages\\";
    string filePath;
    Bitmap imageToSave;
    bool useDefaultImage = false;

    using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
      openFileDialog.Filter = "Image Files|*.jpg;*.png";
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        filePath = openFileDialog.FileName;
        imageToSave = new Bitmap(filePath);
      } else {
        // Use default image if no image is selected
        filePath = Path.Combine(directoryPath, "tempBarangayLogo.jpg");
        imageToSave = new Bitmap(filePath);
        useDefaultImage =
            true; // Set the flag to true as the default image is being used
      }
    }
    // Resize the image
    int cellSize = 100; // Example size, adjust as needed
    using (Bitmap resizedImage =
               new Bitmap(imageToSave, new Size(cellSize, cellSize))) {
      // Apply circular frame
      using (Bitmap circularImage = new Bitmap(cellSize, cellSize)) {
        using (Graphics g = Graphics.FromImage(circularImage)) {
          g.Clear(Color.Transparent);
          GraphicsPath path = new GraphicsPath();
          path.AddEllipse(0, 0, cellSize, cellSize);
          g.SetClip(path);
          g.DrawImage(resizedImage, 0, 0);
        }

        // Ensure the directory exists
        if (!Directory.Exists(directoryPath)) {
          Directory.CreateDirectory(directoryPath);
        }

        // Construct the filename based on the resident's name or use a default
        // name
        string filename =
            useDefaultImage ||
                    string.IsNullOrWhiteSpace(BarangayNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(barangayAddressTextBox.Text)
                ? "tempBarangayLogo.jpg" // Use the default picture name if flag
                                         // is true or names are empty
                : $"{BarangayNameTextBox.Text}.jpg";
        string savePath = Path.Combine(directoryPath, filename);

        // Save the circular image
        circularImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

        // Display the circularImage in the PictureBox called idImage
        BarangayLogoImage.Image = Image.FromFile(savePath);
      }
    }
  }
}
}
