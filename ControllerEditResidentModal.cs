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
    public partial class ControllerEditResidentModal : UserControl
    {
        public ControllerEditResidentModal()
        {
            InitializeComponent();
        }

        private void ControllerEditResidentModal_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
