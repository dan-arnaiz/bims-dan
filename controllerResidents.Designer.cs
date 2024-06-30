namespace BIMS_dan
{
    partial class controllerResidents
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.residentsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableSettingsButton = new System.Windows.Forms.Button();
            this.refreshResidents = new System.Windows.Forms.Button();
            this.ResidentsLabel = new System.Windows.Forms.Label();
            this.addResidentButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.deleteResidentButton = new System.Windows.Forms.Button();
            this.searchBarText = new System.Windows.Forms.TextBox();
            this.editResidentButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._dan_bimsDataSet = new BIMS_dan._dan_bimsDataSet();
            this.residentsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentsTableTableAdapter = new BIMS_dan._dan_bimsDataSetTableAdapters.residentsTableTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsResidingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dan_bimsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // residentsTable
            // 
            this.residentsTable.AutoGenerateColumns = false;
            this.residentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.residentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataGridViewImageColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.civilStatusDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.yearsResidingDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn});
            this.residentsTable.DataSource = this.residentsTableBindingSource;
            this.residentsTable.Location = new System.Drawing.Point(3, 94);
            this.residentsTable.Name = "residentsTable";
            this.residentsTable.RowHeadersVisible = false;
            this.residentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.residentsTable.Size = new System.Drawing.Size(711, 395);
            this.residentsTable.TabIndex = 1;
            this.residentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentsTable_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableSettingsButton);
            this.panel1.Controls.Add(this.refreshResidents);
            this.panel1.Controls.Add(this.ResidentsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 45);
            this.panel1.TabIndex = 0;
            // 
            // tableSettingsButton
            // 
            this.tableSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableSettingsButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSettingsButton.Location = new System.Drawing.Point(548, 7);
            this.tableSettingsButton.Name = "tableSettingsButton";
            this.tableSettingsButton.Size = new System.Drawing.Size(95, 28);
            this.tableSettingsButton.TabIndex = 15;
            this.tableSettingsButton.Text = "Table Settings";
            this.tableSettingsButton.UseVisualStyleBackColor = false;
            // 
            // refreshResidents
            // 
            this.refreshResidents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshResidents.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshResidents.Location = new System.Drawing.Point(643, 7);
            this.refreshResidents.Name = "refreshResidents";
            this.refreshResidents.Size = new System.Drawing.Size(63, 28);
            this.refreshResidents.TabIndex = 14;
            this.refreshResidents.Text = "Refresh";
            this.refreshResidents.UseVisualStyleBackColor = false;
            this.refreshResidents.Click += new System.EventHandler(this.refreshResidents_Click);
            // 
            // ResidentsLabel
            // 
            this.ResidentsLabel.AutoSize = true;
            this.ResidentsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentsLabel.Location = new System.Drawing.Point(5, 9);
            this.ResidentsLabel.Name = "ResidentsLabel";
            this.ResidentsLabel.Size = new System.Drawing.Size(110, 26);
            this.ResidentsLabel.TabIndex = 1;
            this.ResidentsLabel.Text = "Residents";
            this.ResidentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addResidentButton
            // 
            this.addResidentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.addResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResidentButton.ForeColor = System.Drawing.Color.White;
            this.addResidentButton.Location = new System.Drawing.Point(601, 51);
            this.addResidentButton.Name = "addResidentButton";
            this.addResidentButton.Size = new System.Drawing.Size(105, 28);
            this.addResidentButton.TabIndex = 1;
            this.addResidentButton.Text = "Add Resident";
            this.addResidentButton.UseVisualStyleBackColor = false;
            this.addResidentButton.Click += new System.EventHandler(this.addResidentButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(430, 51);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(63, 28);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.importButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(367, 51);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(63, 28);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // deleteResidentButton
            // 
            this.deleteResidentButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteResidentButton.ForeColor = System.Drawing.Color.White;
            this.deleteResidentButton.Location = new System.Drawing.Point(251, 50);
            this.deleteResidentButton.Name = "deleteResidentButton";
            this.deleteResidentButton.Size = new System.Drawing.Size(112, 28);
            this.deleteResidentButton.TabIndex = 5;
            this.deleteResidentButton.Text = "Delete Resident";
            this.deleteResidentButton.UseVisualStyleBackColor = false;
            // 
            // searchBarText
            // 
            this.searchBarText.Location = new System.Drawing.Point(52, 54);
            this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
            this.searchBarText.Name = "searchBarText";
            this.searchBarText.Size = new System.Drawing.Size(177, 20);
            this.searchBarText.TabIndex = 6;
            this.searchBarText.TextChanged += new System.EventHandler(this.searchBarText_TextChanged);
            // 
            // editResidentButton
            // 
            this.editResidentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editResidentButton.ForeColor = System.Drawing.Color.Black;
            this.editResidentButton.Location = new System.Drawing.Point(498, 51);
            this.editResidentButton.Name = "editResidentButton";
            this.editResidentButton.Size = new System.Drawing.Size(105, 28);
            this.editResidentButton.TabIndex = 7;
            this.editResidentButton.Text = "Edit Resident";
            this.editResidentButton.UseVisualStyleBackColor = false;
            this.editResidentButton.Click += new System.EventHandler(this.editResidentButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 56);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(47, 16);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Controls.Add(this.editResidentButton);
            this.panel2.Controls.Add(this.searchBarText);
            this.panel2.Controls.Add(this.deleteResidentButton);
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Controls.Add(this.exportButton);
            this.panel2.Controls.Add(this.addResidentButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 85);
            this.panel2.TabIndex = 2;
            // 
            // _dan_bimsDataSet
            // 
            this._dan_bimsDataSet.DataSetName = "_dan_bimsDataSet";
            this._dan_bimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentsTableBindingSource
            // 
            this.residentsTableBindingSource.DataMember = "residentsTable";
            this.residentsTableBindingSource.DataSource = this._dan_bimsDataSet;
            // 
            // residentsTableTableAdapter
            // 
            this.residentsTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "picture";
            this.dataGridViewImageColumn1.Image = global::BIMS_dan.Properties.Resources.default_profile_picture_placeholder_g4pw6l6c8ja53vbv;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Image = global::BIMS_dan.Properties.Resources.default_profile_picture_placeholder_g4pw6l6c8ja53vbv;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "middleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // civilStatusDataGridViewTextBoxColumn
            // 
            this.civilStatusDataGridViewTextBoxColumn.DataPropertyName = "civilStatus";
            this.civilStatusDataGridViewTextBoxColumn.HeaderText = "civilStatus";
            this.civilStatusDataGridViewTextBoxColumn.Name = "civilStatusDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // yearsResidingDataGridViewTextBoxColumn
            // 
            this.yearsResidingDataGridViewTextBoxColumn.DataPropertyName = "yearsResiding";
            this.yearsResidingDataGridViewTextBoxColumn.HeaderText = "yearsResiding";
            this.yearsResidingDataGridViewTextBoxColumn.Name = "yearsResidingDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // controllerResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.residentsTable);
            this.MaximumSize = new System.Drawing.Size(717, 492);
            this.MinimumSize = new System.Drawing.Size(717, 492);
            this.Name = "controllerResidents";
            this.Size = new System.Drawing.Size(717, 492);
            ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dan_bimsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tableSettingsButton;
        private System.Windows.Forms.Button refreshResidents;
        private System.Windows.Forms.Label ResidentsLabel;
        private System.Windows.Forms.Button addResidentButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button deleteResidentButton;
        private System.Windows.Forms.TextBox searchBarText;
        private System.Windows.Forms.Button editResidentButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource residentsTableBindingSource;
        private _dan_bimsDataSet _dan_bimsDataSet;
        private _dan_bimsDataSetTableAdapters.residentsTableTableAdapter residentsTableTableAdapter;
        public System.Windows.Forms.DataGridView residentsTable;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsResidingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
