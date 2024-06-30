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


namespace BIMS_dan
{
    public partial class controllerResidents : UserControl
    {
        public controllerResidents()
        {
            InitializeComponent();
            this.Load += residentsTable_Shown;
        }

        private async void residentsTable_Shown(object sender, EventArgs e)
        {
            Database db = new Database();
            await db.RefreshResidentsTableAsync(this.residentsTable);
        }

        private void searchBarText_TextChanged(object sender, EventArgs e)
        {
          
        }

        private async void addResidentButton_Click(object sender, EventArgs e)
        {
            using (Form modalForm = new Form())
            {
                ControllerAddNewResidentModal controllerAddNewResidentModal = new ControllerAddNewResidentModal();
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

            }
        }

        private void editResidentButton_Click(object sender, EventArgs e)
        {
            using (Form modalForm = new Form())
            {
                ControllerEditResidentModal controllerEditResidentModal = new ControllerEditResidentModal();
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

        private void residentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshResidents_Click(object sender, EventArgs e)
        {
            this.Load += residentsTable_Shown;
        }
    }

    
}
