namespace BIMS_dan
{
partial class controllerBarangayEvents
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
        this.residentsTable = new System.Windows.Forms.DataGridView();
        this.panel1 = new System.Windows.Forms.Panel();
        this.refreshButton = new System.Windows.Forms.Button();
        this.eventsLabel = new System.Windows.Forms.Label();
        this.tableFilterButton = new System.Windows.Forms.Button();
        this.panel2 = new System.Windows.Forms.Panel();
        this.editOfficialButton = new System.Windows.Forms.Button();
        this.searchBarText = new System.Windows.Forms.TextBox();
        this.deleteResidentButton = new System.Windows.Forms.Button();
        this.addResidentButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).BeginInit();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        //
        // residentsTable
        //
        this.residentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.residentsTable.Location = new System.Drawing.Point(3, 94);
        this.residentsTable.Name = "residentsTable";
        this.residentsTable.Size = new System.Drawing.Size(711, 395);
        this.residentsTable.TabIndex = 5;
        //
        // panel1
        //
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.Controls.Add(this.refreshButton);
        this.panel1.Controls.Add(this.eventsLabel);
        this.panel1.Controls.Add(this.tableFilterButton);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(711, 45);
        this.panel1.TabIndex = 0;
        //
        // refreshButton
        //
        this.refreshButton.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.refreshButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.refreshButton.Location = new System.Drawing.Point(643, 8);
        this.refreshButton.Name = "refreshButton";
        this.refreshButton.Size = new System.Drawing.Size(63, 28);
        this.refreshButton.TabIndex = 7;
        this.refreshButton.Text = "Refresh";
        this.refreshButton.UseVisualStyleBackColor = false;
        //
        // eventsLabel
        //
        this.eventsLabel.AutoSize = true;
        this.eventsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.eventsLabel.Location = new System.Drawing.Point(5, 9);
        this.eventsLabel.Name = "eventsLabel";
        this.eventsLabel.Size = new System.Drawing.Size(79, 26);
        this.eventsLabel.TabIndex = 1;
        this.eventsLabel.Text = "Events";
        this.eventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // tableFilterButton
        //
        this.tableFilterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.tableFilterButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tableFilterButton.Location = new System.Drawing.Point(551, 8);
        this.tableFilterButton.Name = "tableFilterButton";
        this.tableFilterButton.Size = new System.Drawing.Size(92, 28);
        this.tableFilterButton.TabIndex = 4;
        this.tableFilterButton.Text = "Table Settings";
        this.tableFilterButton.UseVisualStyleBackColor = false;
        //
        // panel2
        //
        this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
        this.panel2.Controls.Add(this.editOfficialButton);
        this.panel2.Controls.Add(this.searchBarText);
        this.panel2.Controls.Add(this.deleteResidentButton);
        this.panel2.Controls.Add(this.addResidentButton);
        this.panel2.Controls.Add(this.panel1);
        this.panel2.Location = new System.Drawing.Point(3, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(711, 85);
        this.panel2.TabIndex = 6;
        //
        // editOfficialButton
        //
        this.editOfficialButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.editOfficialButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.editOfficialButton.Location = new System.Drawing.Point(528, 51);
        this.editOfficialButton.Name = "editOfficialButton";
        this.editOfficialButton.Size = new System.Drawing.Size(86, 28);
        this.editOfficialButton.TabIndex = 7;
        this.editOfficialButton.Text = "Edit Official";
        this.editOfficialButton.UseVisualStyleBackColor = false;
        //
        // searchBarText
        //
        this.searchBarText.Location = new System.Drawing.Point(0, 55);
        this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
        this.searchBarText.Name = "searchBarText";
        this.searchBarText.Size = new System.Drawing.Size(222, 24);
        this.searchBarText.TabIndex = 6;
        //
        // deleteResidentButton
        //
        this.deleteResidentButton.BackColor = System.Drawing.Color.Maroon;
        this.deleteResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.deleteResidentButton.ForeColor = System.Drawing.Color.White;
        this.deleteResidentButton.Location = new System.Drawing.Point(410, 51);
        this.deleteResidentButton.Name = "deleteResidentButton";
        this.deleteResidentButton.Size = new System.Drawing.Size(112, 28);
        this.deleteResidentButton.TabIndex = 5;
        this.deleteResidentButton.Text = "Remove Official";
        this.deleteResidentButton.UseVisualStyleBackColor = false;
        //
        // addResidentButton
        //
        this.addResidentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.addResidentButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addResidentButton.Location = new System.Drawing.Point(611, 51);
        this.addResidentButton.Name = "addResidentButton";
        this.addResidentButton.Size = new System.Drawing.Size(95, 28);
        this.addResidentButton.TabIndex = 1;
        this.addResidentButton.Text = "Add Official";
        this.addResidentButton.UseVisualStyleBackColor = false;
        //
        // controllerBarangayEvents
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.residentsTable);
        this.Controls.Add(this.panel2);
        this.Name = "controllerBarangayEvents";
        this.Size = new System.Drawing.Size(717, 492);
        ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView residentsTable;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button refreshButton;
    private System.Windows.Forms.Label eventsLabel;
    private System.Windows.Forms.Button tableFilterButton;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button editOfficialButton;
    private System.Windows.Forms.TextBox searchBarText;
    private System.Windows.Forms.Button deleteResidentButton;
    private System.Windows.Forms.Button addResidentButton;
}
}
