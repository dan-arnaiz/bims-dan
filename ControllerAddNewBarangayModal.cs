using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMS_dan
{
    public partial class ControllerAddNewBarangayModal : UserControl
    {
        public ControllerAddNewBarangayModal()
        {
            InitializeComponent();
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addNewBarangayButton_Click(object sender, EventArgs e)
        {
            // Mandatory field
            string barangayName = BarangayNameTextBox.Text.Trim();

            // Optional fields
            string address = barangayAddressTextBox.Text.Trim();
            string description = barangayDescriptionTextBox.Text.Trim();
            byte[] logo = BarangayLogo.Image != null ? ImageToByteArray(BarangayLogo) : null; // Check if there's an image before converting

            // Validate Barangay Name
            if (string.IsNullOrEmpty(barangayName))
            {
                MessageBox.Show("Barangay Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }

            // Proceed with adding the new Barangay
            BarangayDB barangayDB = new BarangayDB();
            barangayDB.AddNewBarangay(barangayName, address, description, logo);

            MessageBox.Show("Barangay added successfully!");
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            using (var ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void ControllerAddNewBarangayModal_Load(object sender, EventArgs e)
        {

        }
    }
}
