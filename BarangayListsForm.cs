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
    }
}
