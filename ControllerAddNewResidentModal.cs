using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void addNewResidentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
