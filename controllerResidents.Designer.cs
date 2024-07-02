namespace BIMS_dan {
partial class controllerResidents {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed;
  /// otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

#region Component Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
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
    this.dataGridViewImageColumn1 =
        new System.Windows.Forms.DataGridViewImageColumn();
    this._dan_bimsDataSet2 = new BIMS_dan._dan_bimsDataSet2();
    this.residentsTableBindingSource =
        new System.Windows.Forms.BindingSource(this.components);
    this.residentsTableTableAdapter =
        new BIMS_dan._dan_bimsDataSet2TableAdapters
            .residentsTableTableAdapter();
    this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.idDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.pictureDataGridViewImageColumn =
        new System.Windows.Forms.DataGridViewImageColumn();
    this.lastNameDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.firstNameDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.middleNameDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.suffixDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.birthdateDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.ageDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.sexDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.civilStatusDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.addressDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.yearsResidingDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.occupationDataGridViewTextBoxColumn =
        new System.Windows.Forms.DataGridViewTextBoxColumn();
    ((System.ComponentModel.ISupportInitialize)(this.residentsTable))
        .BeginInit();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this._dan_bimsDataSet2))
        .BeginInit();
    ((System.ComponentModel.ISupportInitialize)(
         this.residentsTableBindingSource))
        .BeginInit();
    this.SuspendLayout();
    //
    // residentsTable
    //
    this.residentsTable.AutoGenerateColumns = false;
    this.residentsTable.AutoSizeRowsMode =
        System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
    this.residentsTable.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.residentsTable.Columns.AddRange(
        new System.Windows.Forms.DataGridViewColumn[] {
          this.numColumn, this.idDataGridViewTextBoxColumn,
          this.pictureDataGridViewImageColumn,
          this.lastNameDataGridViewTextBoxColumn,
          this.firstNameDataGridViewTextBoxColumn,
          this.middleNameDataGridViewTextBoxColumn,
          this.suffixDataGridViewTextBoxColumn,
          this.birthdateDataGridViewTextBoxColumn,
          this.ageDataGridViewTextBoxColumn, this.sexDataGridViewTextBoxColumn,
          this.civilStatusDataGridViewTextBoxColumn,
          this.addressDataGridViewTextBoxColumn,
          this.yearsResidingDataGridViewTextBoxColumn,
          this.occupationDataGridViewTextBoxColumn
        });
    this.residentsTable.DataSource = this.residentsTableBindingSource;
    this.residentsTable.Location = new System.Drawing.Point(4, 145);
    this.residentsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.residentsTable.Name = "residentsTable";
    this.residentsTable.RowHeadersVisible = false;
    this.residentsTable.RowHeadersWidth = 62;
    this.residentsTable.SelectionMode =
        System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
    this.residentsTable.Size = new System.Drawing.Size(1066, 608);
    this.residentsTable.TabIndex = 1;
    this.residentsTable.CellContentClick +=
        new System.Windows.Forms.DataGridViewCellEventHandler(
            this.residentsTable_CellContentClick);
    //
    // panel1
    //
    this.panel1.BackColor = System.Drawing.Color.White;
    this.panel1.Controls.Add(this.tableSettingsButton);
    this.panel1.Controls.Add(this.refreshResidents);
    this.panel1.Controls.Add(this.ResidentsLabel);
    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel1.Location = new System.Drawing.Point(0, 0);
    this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(1066, 69);
    this.panel1.TabIndex = 0;
    //
    // tableSettingsButton
    //
    this.tableSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
    this.tableSettingsButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.tableSettingsButton.Location = new System.Drawing.Point(795, 11);
    this.tableSettingsButton.Margin =
        new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.tableSettingsButton.Name = "tableSettingsButton";
    this.tableSettingsButton.Size = new System.Drawing.Size(163, 43);
    this.tableSettingsButton.TabIndex = 15;
    this.tableSettingsButton.Text = "Table Settings";
    this.tableSettingsButton.UseVisualStyleBackColor = false;
    //
    // refreshResidents
    //
    this.refreshResidents.BackColor = System.Drawing.SystemColors.ButtonFace;
    this.refreshResidents.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.refreshResidents.Location = new System.Drawing.Point(964, 11);
    this.refreshResidents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.refreshResidents.Name = "refreshResidents";
    this.refreshResidents.Size = new System.Drawing.Size(94, 43);
    this.refreshResidents.TabIndex = 14;
    this.refreshResidents.Text = "Refresh";
    this.refreshResidents.UseVisualStyleBackColor = false;
    this.refreshResidents.Click +=
        new System.EventHandler(this.refreshResidents_Click);
    //
    // ResidentsLabel
    //
    this.ResidentsLabel.AutoSize = true;
    this.ResidentsLabel.Font = new System.Drawing.Font(
        "Montserrat", 14.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.ResidentsLabel.Location = new System.Drawing.Point(8, 14);
    this.ResidentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    this.ResidentsLabel.Name = "ResidentsLabel";
    this.ResidentsLabel.Size = new System.Drawing.Size(166, 40);
    this.ResidentsLabel.TabIndex = 1;
    this.ResidentsLabel.Text = "Residents";
    this.ResidentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // addResidentButton
    //
    this.addResidentButton.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
    this.addResidentButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.addResidentButton.ForeColor = System.Drawing.Color.White;
    this.addResidentButton.Location = new System.Drawing.Point(902, 78);
    this.addResidentButton.Margin =
        new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.addResidentButton.Name = "addResidentButton";
    this.addResidentButton.Size = new System.Drawing.Size(158, 43);
    this.addResidentButton.TabIndex = 1;
    this.addResidentButton.Text = "Add Resident";
    this.addResidentButton.UseVisualStyleBackColor = false;
    this.addResidentButton.Click +=
        new System.EventHandler(this.addResidentButton_Click);
    //
    // exportButton
    //
    this.exportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
    this.exportButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.exportButton.Location = new System.Drawing.Point(645, 78);
    this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.exportButton.Name = "exportButton";
    this.exportButton.Size = new System.Drawing.Size(94, 43);
    this.exportButton.TabIndex = 2;
    this.exportButton.Text = "Export";
    this.exportButton.UseVisualStyleBackColor = false;
    //
    // importButton
    //
    this.importButton.BackColor = System.Drawing.SystemColors.ButtonFace;
    this.importButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.importButton.Location = new System.Drawing.Point(550, 78);
    this.importButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.importButton.Name = "importButton";
    this.importButton.Size = new System.Drawing.Size(94, 43);
    this.importButton.TabIndex = 3;
    this.importButton.Text = "Import";
    this.importButton.UseVisualStyleBackColor = false;
    //
    // deleteResidentButton
    //
    this.deleteResidentButton.BackColor = System.Drawing.Color.Maroon;
    this.deleteResidentButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.deleteResidentButton.ForeColor = System.Drawing.Color.White;
    this.deleteResidentButton.Location = new System.Drawing.Point(376, 77);
    this.deleteResidentButton.Margin =
        new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.deleteResidentButton.Name = "deleteResidentButton";
    this.deleteResidentButton.Size = new System.Drawing.Size(168, 43);
    this.deleteResidentButton.TabIndex = 5;
    this.deleteResidentButton.Text = "Delete Resident";
    this.deleteResidentButton.UseVisualStyleBackColor = false;
    this.deleteResidentButton.Click +=
        new System.EventHandler(this.deleteResidentButton_Click);
    //
    // searchBarText
    //
    this.searchBarText.Location = new System.Drawing.Point(78, 83);
    this.searchBarText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
    this.searchBarText.Name = "searchBarText";
    this.searchBarText.Size = new System.Drawing.Size(264, 26);
    this.searchBarText.TabIndex = 6;
    this.searchBarText.TextChanged +=
        new System.EventHandler(this.searchBarText_TextChanged);
    //
    // editResidentButton
    //
    this.editResidentButton.BackColor =
        System.Drawing.SystemColors.ButtonHighlight;
    this.editResidentButton.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.editResidentButton.ForeColor = System.Drawing.Color.Black;
    this.editResidentButton.Location = new System.Drawing.Point(747, 78);
    this.editResidentButton.Margin =
        new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.editResidentButton.Name = "editResidentButton";
    this.editResidentButton.Size = new System.Drawing.Size(158, 43);
    this.editResidentButton.TabIndex = 7;
    this.editResidentButton.Text = "Edit Resident";
    this.editResidentButton.UseVisualStyleBackColor = false;
    this.editResidentButton.Click +=
        new System.EventHandler(this.editResidentButton_Click);
    //
    // searchLabel
    //
    this.searchLabel.AutoSize = true;
    this.searchLabel.Font = new System.Drawing.Font(
        "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.searchLabel.Location = new System.Drawing.Point(4, 86);
    this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    this.searchLabel.Name = "searchLabel";
    this.searchLabel.Size = new System.Drawing.Size(74, 20);
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
    this.panel2.Location = new System.Drawing.Point(4, 5);
    this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.panel2.Name = "panel2";
    this.panel2.Size = new System.Drawing.Size(1066, 131);
    this.panel2.TabIndex = 2;
    //
    // dataGridViewImageColumn1
    //
    this.dataGridViewImageColumn1.AutoSizeMode =
        System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
    this.dataGridViewImageColumn1.DataPropertyName = "picture";
    this.dataGridViewImageColumn1.HeaderText = "picture";
    this.dataGridViewImageColumn1.Image =
        global::BIMS_dan.Properties.Resources
            .default_profile_picture_placeholder_g4pw6l6c8ja53vbv;
    this.dataGridViewImageColumn1.MinimumWidth = 8;
    this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
    //
    // _dan_bimsDataSet2
    //
    this._dan_bimsDataSet2.DataSetName = "_dan_bimsDataSet2";
    this._dan_bimsDataSet2.SchemaSerializationMode =
        System.Data.SchemaSerializationMode.IncludeSchema;
    //
    // residentsTableBindingSource
    //
    this.residentsTableBindingSource.DataMember = "residentsTable";
    this.residentsTableBindingSource.DataSource = this._dan_bimsDataSet2;
    //
    // residentsTableTableAdapter
    //
    this.residentsTableTableAdapter.ClearBeforeFill = true;
    //
    // numColumn
    //
    this.numColumn.HeaderText = "";
    this.numColumn.MinimumWidth = 8;
    this.numColumn.Name = "numColumn";
    this.numColumn.ReadOnly = true;
    this.numColumn.Width = 150;
    //
    // idDataGridViewTextBoxColumn
    //
    this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
    this.idDataGridViewTextBoxColumn.HeaderText = "id";
    this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
    this.idDataGridViewTextBoxColumn.ReadOnly = true;
    this.idDataGridViewTextBoxColumn.Visible = false;
    this.idDataGridViewTextBoxColumn.Width = 150;
    //
    // pictureDataGridViewImageColumn
    //
    this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
    this.pictureDataGridViewImageColumn.HeaderText = "picture";
    this.pictureDataGridViewImageColumn.MinimumWidth = 8;
    this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
    this.pictureDataGridViewImageColumn.Width = 150;
    //
    // lastNameDataGridViewTextBoxColumn
    //
    this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
    this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
    this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.lastNameDataGridViewTextBoxColumn.Name =
        "lastNameDataGridViewTextBoxColumn";
    this.lastNameDataGridViewTextBoxColumn.Width = 150;
    //
    // firstNameDataGridViewTextBoxColumn
    //
    this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
    this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
    this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.firstNameDataGridViewTextBoxColumn.Name =
        "firstNameDataGridViewTextBoxColumn";
    this.firstNameDataGridViewTextBoxColumn.Width = 150;
    //
    // middleNameDataGridViewTextBoxColumn
    //
    this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName";
    this.middleNameDataGridViewTextBoxColumn.HeaderText = "middleName";
    this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.middleNameDataGridViewTextBoxColumn.Name =
        "middleNameDataGridViewTextBoxColumn";
    this.middleNameDataGridViewTextBoxColumn.Width = 150;
    //
    // suffixDataGridViewTextBoxColumn
    //
    this.suffixDataGridViewTextBoxColumn.DataPropertyName = "suffix";
    this.suffixDataGridViewTextBoxColumn.HeaderText = "suffix";
    this.suffixDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.suffixDataGridViewTextBoxColumn.Name =
        "suffixDataGridViewTextBoxColumn";
    this.suffixDataGridViewTextBoxColumn.Width = 150;
    //
    // birthdateDataGridViewTextBoxColumn
    //
    this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
    this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
    this.birthdateDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.birthdateDataGridViewTextBoxColumn.Name =
        "birthdateDataGridViewTextBoxColumn";
    this.birthdateDataGridViewTextBoxColumn.Width = 150;
    //
    // ageDataGridViewTextBoxColumn
    //
    this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
    this.ageDataGridViewTextBoxColumn.HeaderText = "age";
    this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
    this.ageDataGridViewTextBoxColumn.Width = 150;
    //
    // sexDataGridViewTextBoxColumn
    //
    this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
    this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
    this.sexDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
    this.sexDataGridViewTextBoxColumn.Width = 150;
    //
    // civilStatusDataGridViewTextBoxColumn
    //
    this.civilStatusDataGridViewTextBoxColumn.DataPropertyName = "civilStatus";
    this.civilStatusDataGridViewTextBoxColumn.HeaderText = "civilStatus";
    this.civilStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.civilStatusDataGridViewTextBoxColumn.Name =
        "civilStatusDataGridViewTextBoxColumn";
    this.civilStatusDataGridViewTextBoxColumn.Width = 150;
    //
    // addressDataGridViewTextBoxColumn
    //
    this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
    this.addressDataGridViewTextBoxColumn.HeaderText = "address";
    this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.addressDataGridViewTextBoxColumn.Name =
        "addressDataGridViewTextBoxColumn";
    this.addressDataGridViewTextBoxColumn.Width = 150;
    //
    // yearsResidingDataGridViewTextBoxColumn
    //
    this.yearsResidingDataGridViewTextBoxColumn.DataPropertyName =
        "yearsResiding";
    this.yearsResidingDataGridViewTextBoxColumn.HeaderText = "yearsResiding";
    this.yearsResidingDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.yearsResidingDataGridViewTextBoxColumn.Name =
        "yearsResidingDataGridViewTextBoxColumn";
    this.yearsResidingDataGridViewTextBoxColumn.Width = 150;
    //
    // occupationDataGridViewTextBoxColumn
    //
    this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
    this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
    this.occupationDataGridViewTextBoxColumn.MinimumWidth = 8;
    this.occupationDataGridViewTextBoxColumn.Name =
        "occupationDataGridViewTextBoxColumn";
    this.occupationDataGridViewTextBoxColumn.Width = 150;
    //
    // controllerResidents
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.SystemColors.ControlLight;
    this.Controls.Add(this.panel2);
    this.Controls.Add(this.residentsTable);
    this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
    this.MaximumSize = new System.Drawing.Size(1076, 757);
    this.MinimumSize = new System.Drawing.Size(1076, 757);
    this.Name = "controllerResidents";
    this.Size = new System.Drawing.Size(1076, 757);
    ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)(this._dan_bimsDataSet2))
        .EndInit();
    ((System.ComponentModel.ISupportInitialize)(
         this.residentsTableBindingSource))
        .EndInit();
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
  public System.Windows.Forms.DataGridView residentsTable;
  private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
  private System.Windows.Forms.BindingSource residentsTableBindingSource;
  private _dan_bimsDataSet2 _dan_bimsDataSet2;
  private _dan_bimsDataSet2TableAdapters
      .residentsTableTableAdapter residentsTableTableAdapter;
  private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewImageColumn pictureDataGridViewImageColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn civilStatusDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn yearsResidingDataGridViewTextBoxColumn;
  private System.Windows.Forms
      .DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
}
}
