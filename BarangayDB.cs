using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace BIMS_dan
{
    internal class BarangayDB
    {
        private string connectionString = @"Server=localhost;Database=dan-bims;Integrated Security=True;"; // Update with your actual connection string

        public void AddNewBarangay(string barangayName, string address, string description, byte[] logo)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Barangays (BarangayLogo, BarangayName, Address, Description) VALUES (@Logo, @Name, @Address, @Description)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Logo", logo);
                    command.Parameters.AddWithValue("@Name", barangayName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Description", description);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            using (var ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
