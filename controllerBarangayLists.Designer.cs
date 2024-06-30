namespace BIMS_dan
{
partial class controllerBarangayLists
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
        this.barangayLists = new System.Windows.Forms.Label();
        this.refreshResidents = new System.Windows.Forms.Button();
        this.tableSettingsButton = new System.Windows.Forms.Button();
        this.exportButton = new System.Windows.Forms.Button();
        this.importButton = new System.Windows.Forms.Button();
        this.addNewBarangayButton = new System.Windows.Forms.Button();
        this.searchBarText = new System.Windows.Forms.TextBox();
        this.searchLabel = new System.Windows.Forms.Label();
        this.panel2 = new System.Windows.Forms.Panel();
        this.barangayListTable = new System.Windows.Forms.DataGridView();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.barangayListTable)).BeginInit();
        this.SuspendLayout();
        //
        // panel1
        //
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.Controls.Add(this.tableSettingsButton);
        this.panel1.Controls.Add(this.refreshResidents);
        this.panel1.Controls.Add(this.barangayLists);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(639, 45);
        this.panel1.TabIndex = 0;
        //
        // barangayLists
        //
        this.barangayLists.AutoSize = true;
        this.barangayLists.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.barangayLists.Location = new System.Drawing.Point(3, 8);
        this.barangayLists.Name = "barangayLists";
        this.barangayLists.Size = new System.Drawing.Size(147, 26);
        this.barangayLists.TabIndex = 1;
        this.barangayLists.Text = "Barangay List";
        this.barangayLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // refreshResidents
        //
        this.refreshResidents.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.refreshResidents.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.refreshResidents.Location = new System.Drawing.Point(565, 8);
        this.refreshResidents.Name = "refreshResidents";
        this.refreshResidents.Size = new System.Drawing.Size(63, 28);
        this.refreshResidents.TabIndex = 14;
        this.refreshResidents.Text = "Refresh";
        this.refreshResidents.UseVisualStyleBackColor = false;
        //
        // tableSettingsButton
        //
        this.tableSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.tableSettingsButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tableSettingsButton.Location = new System.Drawing.Point(465, 8);
        this.tableSettingsButton.Name = "tableSettingsButton";
        this.tableSettingsButton.Size = new System.Drawing.Size(95, 28);
        this.tableSettingsButton.TabIndex = 15;
        this.tableSettingsButton.Text = "Table Settings";
        this.tableSettingsButton.UseVisualStyleBackColor = false;
        //
        // exportButton
        //
        this.exportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.exportButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.exportButton.Location = new System.Drawing.Point(456, 50);
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
        this.importButton.Location = new System.Drawing.Point(393, 50);
        this.importButton.Name = "importButton";
        this.importButton.Size = new System.Drawing.Size(63, 28);
        this.importButton.TabIndex = 3;
        this.importButton.Text = "Import";
        this.importButton.UseVisualStyleBackColor = false;
        //
        // addNewBarangayButton
        //
        this.addNewBarangayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
        this.addNewBarangayButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addNewBarangayButton.ForeColor = System.Drawing.Color.White;
        this.addNewBarangayButton.Location = new System.Drawing.Point(523, 50);
        this.addNewBarangayButton.Name = "addNewBarangayButton";
        this.addNewBarangayButton.Size = new System.Drawing.Size(105, 28);
        this.addNewBarangayButton.TabIndex = 1;
        this.addNewBarangayButton.Text = "Add Barangay";
        this.addNewBarangayButton.UseVisualStyleBackColor = false;
        //
        // searchBarText
        //
        this.searchBarText.Location = new System.Drawing.Point(51, 53);
        this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
        this.searchBarText.Name = "searchBarText";
        this.searchBarText.Size = new System.Drawing.Size(227, 24);
        this.searchBarText.TabIndex = 6;
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
        this.panel2.Controls.Add(this.searchBarText);
        this.panel2.Controls.Add(this.addNewBarangayButton);
        this.panel2.Controls.Add(this.importButton);
        this.panel2.Controls.Add(this.exportButton);
        this.panel2.Controls.Add(this.panel1);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel2.Location = new System.Drawing.Point(0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(639, 85);
        this.panel2.TabIndex = 3;
        //
        // barangayListTable
        //
        this.barangayListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.barangayListTable.Location = new System.Drawing.Point(0, 83);
        this.barangayListTable.Name = "barangayListTable";
        this.barangayListTable.Size = new System.Drawing.Size(639, 411);
        this.barangayListTable.TabIndex = 4;
        //
        // controllerBarangayLists
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Controls.Add(this.barangayListTable);
        this.Controls.Add(this.panel2);
        this.MaximumSize = new System.Drawing.Size(639, 494);
        this.MinimumSize = new System.Drawing.Size(639, 494);
        this.Name = "controllerBarangayLists";
        this.Size = new System.Drawing.Size(639, 494);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.barangayListTable)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button tableSettingsButton;
    private System.Windows.Forms.Button refreshResidents;
    private System.Windows.Forms.Label barangayLists;
    private System.Windows.Forms.Button exportButton;
    private System.Windows.Forms.Button importButton;
    private System.Windows.Forms.Button addNewBarangayButton;
    private System.Windows.Forms.TextBox searchBarText;
    private System.Windows.Forms.Label searchLabel;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataGridView barangayListTable;
}
}
