﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BIMS_dan._dan_bimsBarangayDataset;

namespace BIMS_dan
{

    public partial class ControllerEditBarangayModal : UserControl
    {
        public ControllerEditBarangayModal()
        {
            InitializeComponent();
        }

        private void barangaysDatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a row, not the column header
            if (e.RowIndex >= 0)
            {
                // Access the DataGridView
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;

                // Get the 'barangayNameDataGridViewTextBoxColumn', 'addressDataGridViewTextBoxColumn', and 'descriptionDataGridViewTextBoxColumn' column values of the clicked row
                string barangayName = dgv.Rows[e.RowIndex].Cells["barangayNameDataGridViewTextBoxColumn"].Value.ToString();
                string barangayAddress = dgv.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
                string barangayDescription = dgv.Rows[e.RowIndex].Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();

                // Set the values to the textboxes
                BarangayNameEditTextBox.Text = barangayName;
                barangayAddressEditTextBox.Text = barangayAddress;
                barangayDescriptionEditTextBox.Text = barangayDescription;
            }
        }

        private void ControllerEditBarangayModal_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        
        private async void applyChangesButtonBarangay_Click(object sender, EventArgs e)
        {
        }
    }
}
