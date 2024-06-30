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

namespace BIMS_dan
{
    public partial class ControllerAddNewResidentModal : UserControl
    {
        public ControllerAddNewResidentModal()
        {
            InitializeComponent();
        }

        private void ControllerAddNewResidentModal_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (Bitmap originalImage = new Bitmap(filePath))
                    {
                        // Resize the image
                        int cellSize = 100; // Example size, adjust as needed
                        Bitmap resizedImage = new Bitmap(originalImage, new Size(cellSize, cellSize));

                        // Apply circular frame
                        Bitmap circularImage = new Bitmap(cellSize, cellSize);
                        using (Graphics g = Graphics.FromImage(circularImage))
                        {
                            g.Clear(Color.Transparent);
                            GraphicsPath path = new GraphicsPath();
                            path.AddEllipse(0, 0, cellSize, cellSize);
                            g.SetClip(path);
                            g.DrawImage(resizedImage, 0, 0);
                        }

                        // Save the circular image to a specific path
                        string directoryPath = "oop-bims-final\\residentimages\\";
                        // Ensure the directory exists
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        string fileName = Path.GetFileName(filePath); // Use original file name, or generate a new one as needed
                        string savePath = Path.Combine(directoryPath, fileName);
                        circularImage.Save(savePath);

                        // Display the circularImage in the PictureBox called idImage
                        idImage.Image = Image.FromFile(savePath);
                    }
                }
            }
        }

        private void idImage_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suffixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void addNewResidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming picture is a path from a TextBox or a predefined value
                string directoryPath = "oop-bims-final\\residentimages\\";
                string filename = $"{lastNameTextBox.Text}_{firstNameTextBox.Text}.jpg";
                byte[] pictureData = File.ReadAllBytes(Path.Combine(directoryPath, filename));
                string lastName = lastNameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string middleName = middleNameTextBox.Text;
                // Assuming suffix is included in lastName or another field if needed
                DateTime birthdate = birthDatePicker.Value;
                string sex = sexDropdown.SelectedItem.ToString();
                string civilStatus = civilStatusDropdown.SelectedItem.ToString();
                string address = addressTextBox.Text;
                int yearsResiding = int.Parse(yearsResidingTextBox.Text); // Convert to int
                string occupation = occupationTextBox.Text;

                // Create an instance of your Database class
                Database db = new Database();
                // Call the AddResident method
                await db.AddResident(pictureData, lastName, firstName, middleName, birthdate, sex, civilStatus, address, yearsResiding, occupation);

                MessageBox.Show("Resident added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add resident. Error: {ex.Message}");
            }
        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sexDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void civilStatusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearsResidingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void occupationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
