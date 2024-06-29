namespace BIMS_dan
{
partial class controllerBarangayOfficials
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
        this.panel1 = new System.Windows.Forms.Panel();
        this.OfficialsLabel = new System.Windows.Forms.Label();
        this.panel2 = new System.Windows.Forms.Panel();
        this.deleteResidentButton = new System.Windows.Forms.Button();
        this.addResidentButton = new System.Windows.Forms.Button();
        this.residentsTable = new System.Windows.Forms.DataGridView();
        this.editOfficialButton = new System.Windows.Forms.Button();
        this.tableSettingsButton = new System.Windows.Forms.Button();
        this.refreshResidents = new System.Windows.Forms.Button();
        this.searchLabel = new System.Windows.Forms.Label();
        this.searchBarText = new System.Windows.Forms.TextBox();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).BeginInit();
        this.SuspendLayout();
        //
        // panel1
        //
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.Controls.Add(this.tableSettingsButton);
        this.panel1.Controls.Add(this.refreshResidents);
        this.panel1.Controls.Add(this.OfficialsLabel);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(711, 45);
        this.panel1.TabIndex = 0;
        //
        // OfficialsLabel
        //
        this.OfficialsLabel.AutoSize = true;
        this.OfficialsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.OfficialsLabel.Location = new System.Drawing.Point(5, 9);
        this.OfficialsLabel.Name = "OfficialsLabel";
        this.OfficialsLabel.Size = new System.Drawing.Size(193, 26);
        this.OfficialsLabel.TabIndex = 1;
        this.OfficialsLabel.Text = "Barangay Officials";
        this.OfficialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // panel2
        //
        this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
        this.panel2.Controls.Add(this.searchLabel);
        this.panel2.Controls.Add(this.searchBarText);
        this.panel2.Controls.Add(this.editOfficialButton);
        this.panel2.Controls.Add(this.deleteResidentButton);
        this.panel2.Controls.Add(this.addResidentButton);
        this.panel2.Controls.Add(this.panel1);
        this.panel2.Location = new System.Drawing.Point(3, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(711, 85);
        this.panel2.TabIndex = 4;
        //
        // deleteResidentButton
        //
        this.deleteResidentButton.BackColor = System.Drawing.Color.Maroon;
        this.deleteResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.deleteResidentButton.ForeColor = System.Drawing.Color.White;
        this.deleteResidentButton.Location = new System.Drawing.Point(411, 51);
        this.deleteResidentButton.Name = "deleteResidentButton";
        this.deleteResidentButton.Size = new System.Drawing.Size(112, 28);
        this.deleteResidentButton.TabIndex = 5;
        this.deleteResidentButton.Text = "Remove Official";
        this.deleteResidentButton.UseVisualStyleBackColor = false;
        //
        // addResidentButton
        //
        this.addResidentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
        this.addResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addResidentButton.ForeColor = System.Drawing.Color.White;
        this.addResidentButton.Location = new System.Drawing.Point(611, 51);
        this.addResidentButton.Name = "addResidentButton";
        this.addResidentButton.Size = new System.Drawing.Size(95, 28);
        this.addResidentButton.TabIndex = 1;
        this.addResidentButton.Text = "Add Official";
        this.addResidentButton.UseVisualStyleBackColor = false;
        //
        // residentsTable
        //
        this.residentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.residentsTable.Location = new System.Drawing.Point(3, 94);
        this.residentsTable.Name = "residentsTable";
        this.residentsTable.Size = new System.Drawing.Size(711, 395);
        this.residentsTable.TabIndex = 3;
        //
        // editOfficialButton
        //
        this.editOfficialButton.BackColor = System.Drawing.Color.White;
        this.editOfficialButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.editOfficialButton.Location = new System.Drawing.Point(529, 51);
        this.editOfficialButton.Name = "editOfficialButton";
        this.editOfficialButton.Size = new System.Drawing.Size(86, 28);
        this.editOfficialButton.TabIndex = 7;
        this.editOfficialButton.Text = "Edit Official";
        this.editOfficialButton.UseVisualStyleBackColor = false;
        //
        // tableSettingsButton
        //
        this.tableSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.tableSettingsButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tableSettingsButton.Location = new System.Drawing.Point(548, 9);
        this.tableSettingsButton.Name = "tableSettingsButton";
        this.tableSettingsButton.Size = new System.Drawing.Size(95, 28);
        this.tableSettingsButton.TabIndex = 13;
        this.tableSettingsButton.Text = "Table Settings";
        this.tableSettingsButton.UseVisualStyleBackColor = false;
        //
        // refreshResidents
        //
        this.refreshResidents.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.refreshResidents.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.refreshResidents.Location = new System.Drawing.Point(643, 9);
        this.refreshResidents.Name = "refreshResidents";
        this.refreshResidents.Size = new System.Drawing.Size(63, 28);
        this.refreshResidents.TabIndex = 12;
        this.refreshResidents.Text = "Refresh";
        this.refreshResidents.UseVisualStyleBackColor = false;
        //
        // searchLabel
        //
        this.searchLabel.AutoSize = true;
        this.searchLabel.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.searchLabel.Location = new System.Drawing.Point(7, 57);
        this.searchLabel.Name = "searchLabel";
        this.searchLabel.Size = new System.Drawing.Size(47, 16);
        this.searchLabel.TabIndex = 14;
        this.searchLabel.Text = "Search:";
        this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // searchBarText
        //
        this.searchBarText.Location = new System.Drawing.Point(56, 54);
        this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
        this.searchBarText.Name = "searchBarText";
        this.searchBarText.Size = new System.Drawing.Size(155, 24);
        this.searchBarText.TabIndex = 13;
        //
        // controllerBarangayOfficials
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.residentsTable);
        this.Name = "controllerBarangayOfficials";
        this.Size = new System.Drawing.Size(717, 492);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label OfficialsLabel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button deleteResidentButton;
    private System.Windows.Forms.Button addResidentButton;
    private System.Windows.Forms.DataGridView residentsTable;
    private System.Windows.Forms.Button editOfficialButton;
    private System.Windows.Forms.Button tableSettingsButton;
    private System.Windows.Forms.Button refreshResidents;
    private System.Windows.Forms.Label searchLabel;
    private System.Windows.Forms.TextBox searchBarText;
}
}
