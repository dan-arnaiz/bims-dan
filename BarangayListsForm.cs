using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMS_dan
{
    public partial class BarangayListsForm : Form
    {
        public BarangayListsForm()
        {
            InitializeComponent();
            this.Load += BarangayLists_refresh;
            
        }
        private async void BarangayLists_refresh(object sender, EventArgs e)
        {
            BarangayDB db = new BarangayDB();
            await db.RefreshBarangaysTableAsync(this.barangaysDatatable);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBarangayButton_Click(object sender, EventArgs e)
        {
            using (Form modalForm = new Form())
            {
                ControllerAddNewBarangayModal ControllerAddNewBarangayModal = new ControllerAddNewBarangayModal();
                modalForm.Controls.Add(ControllerAddNewBarangayModal);
                ControllerAddNewBarangayModal.Dock = DockStyle.Fill;
                modalForm.Name = "Add New Barangay";
                modalForm.ShowIcon = false;
                modalForm.ShowInTaskbar = false;
                modalForm.Size = new Size(414, 584);
                modalForm.MinimumSize = new Size(414, 584);
                modalForm.MaximumSize = new Size(414, 584);
                modalForm.StartPosition = FormStartPosition.CenterScreen;
                modalForm.ShowDialog();

                

            }
        }

        private void BarangayListsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_dan_bimsBarangayDataset.Barangays' table. You can move, or remove it, as needed.
            this.barangaysTableAdapter.Fill(this._dan_bimsBarangayDataset.Barangays);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private async void refreshBarangayTable_Click(object sender, EventArgs e)
        {
            BarangayDB db = new BarangayDB();
            await db.RefreshBarangaysTableAsync(this.barangaysDatatable);
        }



        private void barangayLabelTitle_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            // Subscribe to the CellClick event
            this.barangaysDatatable.CellClick += new DataGridViewCellEventHandler(this.barangaysDatatable_CellContentClick);
        }

        private void barangaysDatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a row, not the column header
            if (e.RowIndex >= 0)
            {
                // Access the DataGridView
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;

                // Get the 'barangayNameDataGridViewTextBoxColumn' column value of the clicked row
                string barangayName = dgv.Rows[e.RowIndex].Cells["barangayNameDataGridViewTextBoxColumn"].Value.ToString();
                string barangayAddress = dgv.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
                string barangayDescription = dgv.Rows[e.RowIndex].Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();

                // Update the Text of barangayLabelTitle with the selected barangay name
                barangayLabelTitle.Text = "Barangay " + barangayName;
                addressplaceholder.Text = barangayAddress;
                descriptionplaceholder.Text = barangayDescription;

                var cellValue = dgv.Rows[e.RowIndex].Cells["barangayLogoDataGridViewImageColumn"].Value;
                if (cellValue != DBNull.Value && cellValue is Image)
                {
                    // Update the Image of BarangayLogoPlaceholder with the selected image
                    BarangayLogoPlaceholder.Image = cellValue as Image;
                }
                else
                {
                    // Optionally, set a default image if the cell value is not an image
                    BarangayLogoPlaceholder.Image = null; // Or set to a default image
                }
            }

        }
        private void barangaysDatatable_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there are any selected rows
            if (barangaysDatatable.SelectedRows.Count > 0)
            {
                // Assuming 'barangayNameDataGridViewTextBoxColumn' is the name of the column
                // Get the value from the first selected row
                string selectedBarangayName = barangaysDatatable.SelectedRows[0].Cells["barangayNameDataGridViewTextBoxColumn"].Value.ToString();

                // Update the Text of barangayLabelTitle with the selected barangay name
                
            }
        }

        private void addressplaceholder_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            // Subscribe to the CellClick event
            this.barangaysDatatable.CellClick += new DataGridViewCellEventHandler(this.barangaysDatatable_CellContentClick);
        }

        private void descriptionplaceholder_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            // Subscribe to the CellClick event
            this.barangaysDatatable.CellClick += new DataGridViewCellEventHandler(this.barangaysDatatable_CellContentClick);
        }

        private void addresslabeldetails_Click(object sender, EventArgs e)
        {

        }

        private void BarangayLogoPlaceholder_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            // Subscribe to the CellClick event
            this.barangaysDatatable.CellClick += new DataGridViewCellEventHandler(this.barangaysDatatable_CellContentClick);
        }
    }
}
