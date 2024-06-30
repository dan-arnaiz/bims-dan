using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BIMS_dan
{
    public class Database
    {
        public readonly string connectionString;

        public Database()
        {
            connectionString = @"Server=localhost;Database=dan-bims;Integrated Security=True;";
        }

        public async Task RefreshResidentsTableAsync(DataGridView residentsTable)
        {
            string query = @"SELECT picture, lastName, firstName, middleName, birthdate, sex, civilStatus, address, yearsResiding, occupation FROM residentsTable";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    residentsTable.DataSource = dataTable;
                }
            }
        }
    }
}