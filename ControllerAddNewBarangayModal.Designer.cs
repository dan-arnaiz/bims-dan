namespace BIMS_dan
{
partial class ControllerAddNewBarangayModal
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
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.panel2 = new System.Windows.Forms.Panel();
        this.AddBarangayLabel = new System.Windows.Forms.Label();
        this.panel3 = new System.Windows.Forms.Panel();
        this.barangayLogoLabel = new System.Windows.Forms.Label();
        this.uploadBarangayLogoButton = new System.Windows.Forms.Button();
        this.panel4 = new System.Windows.Forms.Panel();
        this.BarangayLogoImage = new System.Windows.Forms.PictureBox();
        this.addressLabel = new System.Windows.Forms.Label();
        this.barangayAddressTextBox = new System.Windows.Forms.TextBox();
        this.BarangayNameTextBox = new System.Windows.Forms.TextBox();
        this.barangayNameLabel = new System.Windows.Forms.Label();
        this.Description = new System.Windows.Forms.Label();
        this.barangayDescriptionTextBox = new System.Windows.Forms.TextBox();
        this.panel5 = new System.Windows.Forms.Panel();
        this.addNewBarangayButton = new System.Windows.Forms.Button();
        this.cancelButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.BarangayLogoImage)).BeginInit();
        this.panel5.SuspendLayout();
        this.SuspendLayout();
        //
        // pictureBox1
        //
        this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pictureBox1.Image = global::BIMS_dan.Properties.Resources._32;
        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(614, 797);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 2;
        this.pictureBox1.TabStop = false;
        //
        // panel2
        //
        this.panel2.BackColor = System.Drawing.Color.White;
        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel2.Controls.Add(this.AddBarangayLabel);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel2.Location = new System.Drawing.Point(0, 0);
        this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(614, 71);
        this.panel2.TabIndex = 6;
        //
        // AddBarangayLabel
        //
        this.AddBarangayLabel.AutoSize = true;
        this.AddBarangayLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.AddBarangayLabel.Location = new System.Drawing.Point(30, 19);
        this.AddBarangayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.AddBarangayLabel.Name = "AddBarangayLabel";
        this.AddBarangayLabel.Size = new System.Drawing.Size(270, 32);
        this.AddBarangayLabel.TabIndex = 7;
        this.AddBarangayLabel.Text = "Add a New Barangay";
        this.AddBarangayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // panel3
        //
        this.panel3.BackColor = System.Drawing.Color.White;
        this.panel3.Controls.Add(this.barangayLogoLabel);
        this.panel3.Controls.Add(this.uploadBarangayLogoButton);
        this.panel3.Location = new System.Drawing.Point(13, 183);
        this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.panel3.Name = "panel3";
        this.panel3.Size = new System.Drawing.Size(158, 84);
        this.panel3.TabIndex = 7;
        //
        // barangayLogoLabel
        //
        this.barangayLogoLabel.AutoSize = true;
        this.barangayLogoLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.barangayLogoLabel.Location = new System.Drawing.Point(7, 9);
        this.barangayLogoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.barangayLogoLabel.Name = "barangayLogoLabel";
        this.barangayLogoLabel.Size = new System.Drawing.Size(142, 24);
        this.barangayLogoLabel.TabIndex = 34;
        this.barangayLogoLabel.Text = "Barangay Logo";
        this.barangayLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // uploadBarangayLogoButton
        //
        this.uploadBarangayLogoButton.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.uploadBarangayLogoButton.Location = new System.Drawing.Point(28, 39);
        this.uploadBarangayLogoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.uploadBarangayLogoButton.Name = "uploadBarangayLogoButton";
        this.uploadBarangayLogoButton.Size = new System.Drawing.Size(94, 35);
        this.uploadBarangayLogoButton.TabIndex = 32;
        this.uploadBarangayLogoButton.Text = "Upload";
        this.uploadBarangayLogoButton.UseVisualStyleBackColor = true;
        this.uploadBarangayLogoButton.Click += new System.EventHandler(this.uploadBarangayLogoButton_Click);
        //
        // panel4
        //
        this.panel4.Controls.Add(this.BarangayLogoImage);
        this.panel4.Controls.Add(this.panel3);
        this.panel4.Location = new System.Drawing.Point(208, 88);
        this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.panel4.Name = "panel4";
        this.panel4.Size = new System.Drawing.Size(184, 290);
        this.panel4.TabIndex = 33;
        //
        // BarangayLogoImage
        //
        this.BarangayLogoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.BarangayLogoImage.InitialImage = global::BIMS_dan.Properties.Resources._22;
        this.BarangayLogoImage.Location = new System.Drawing.Point(16, 20);
        this.BarangayLogoImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.BarangayLogoImage.Name = "BarangayLogoImage";
        this.BarangayLogoImage.Size = new System.Drawing.Size(149, 153);
        this.BarangayLogoImage.TabIndex = 33;
        this.BarangayLogoImage.TabStop = false;
        //
        // addressLabel
        //
        this.addressLabel.AutoSize = true;
        this.addressLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addressLabel.Location = new System.Drawing.Point(22, 76);
        this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.addressLabel.Name = "addressLabel";
        this.addressLabel.Size = new System.Drawing.Size(94, 25);
        this.addressLabel.TabIndex = 14;
        this.addressLabel.Text = "Address:";
        this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
        //
        // barangayAddressTextBox
        //
        this.barangayAddressTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.barangayAddressTextBox.Location = new System.Drawing.Point(27, 106);
        this.barangayAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.barangayAddressTextBox.Multiline = true;
        this.barangayAddressTextBox.Name = "barangayAddressTextBox";
        this.barangayAddressTextBox.Size = new System.Drawing.Size(463, 53);
        this.barangayAddressTextBox.TabIndex = 11;
        //
        // BarangayNameTextBox
        //
        this.BarangayNameTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.BarangayNameTextBox.Location = new System.Drawing.Point(27, 43);
        this.BarangayNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.BarangayNameTextBox.Name = "BarangayNameTextBox";
        this.BarangayNameTextBox.Size = new System.Drawing.Size(463, 28);
        this.BarangayNameTextBox.TabIndex = 9;
        //
        // barangayNameLabel
        //
        this.barangayNameLabel.AutoSize = true;
        this.barangayNameLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.barangayNameLabel.Location = new System.Drawing.Point(22, 13);
        this.barangayNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.barangayNameLabel.Name = "barangayNameLabel";
        this.barangayNameLabel.Size = new System.Drawing.Size(168, 25);
        this.barangayNameLabel.TabIndex = 8;
        this.barangayNameLabel.Text = "Barangay Name:\r\n";
        this.barangayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // Description
        //
        this.Description.AutoSize = true;
        this.Description.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Description.Location = new System.Drawing.Point(22, 164);
        this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.Description.Name = "Description";
        this.Description.Size = new System.Drawing.Size(126, 25);
        this.Description.TabIndex = 26;
        this.Description.Text = "Description:";
        this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // barangayDescriptionTextBox
        //
        this.barangayDescriptionTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.barangayDescriptionTextBox.Location = new System.Drawing.Point(27, 204);
        this.barangayDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.barangayDescriptionTextBox.Multiline = true;
        this.barangayDescriptionTextBox.Name = "barangayDescriptionTextBox";
        this.barangayDescriptionTextBox.Size = new System.Drawing.Size(463, 68);
        this.barangayDescriptionTextBox.TabIndex = 27;
        //
        // panel5
        //
        this.panel5.Controls.Add(this.barangayDescriptionTextBox);
        this.panel5.Controls.Add(this.Description);
        this.panel5.Controls.Add(this.barangayNameLabel);
        this.panel5.Controls.Add(this.BarangayNameTextBox);
        this.panel5.Controls.Add(this.barangayAddressTextBox);
        this.panel5.Controls.Add(this.addressLabel);
        this.panel5.Location = new System.Drawing.Point(47, 395);
        this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.panel5.Name = "panel5";
        this.panel5.Size = new System.Drawing.Size(523, 301);
        this.panel5.TabIndex = 34;
        //
        // addNewBarangayButton
        //
        this.addNewBarangayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
        this.addNewBarangayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.addNewBarangayButton.ForeColor = System.Drawing.Color.White;
        this.addNewBarangayButton.Location = new System.Drawing.Point(412, 721);
        this.addNewBarangayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.addNewBarangayButton.Name = "addNewBarangayButton";
        this.addNewBarangayButton.Size = new System.Drawing.Size(158, 43);
        this.addNewBarangayButton.TabIndex = 35;
        this.addNewBarangayButton.Text = "Add Barangay";
        this.addNewBarangayButton.UseVisualStyleBackColor = false;
        this.addNewBarangayButton.Click += new System.EventHandler(this.addNewBarangayButton_Click);
        //
        // cancelButton
        //
        this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDark;
        this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cancelButton.ForeColor = System.Drawing.Color.Black;
        this.cancelButton.Location = new System.Drawing.Point(245, 721);
        this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(158, 43);
        this.cancelButton.TabIndex = 36;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = false;
        this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
        //
        // ControllerAddNewBarangayModal
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.addNewBarangayButton);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.panel4);
        this.Controls.Add(this.panel5);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.pictureBox1);
        this.MaximumSize = new System.Drawing.Size(614, 797);
        this.MinimumSize = new System.Drawing.Size(614, 797);
        this.Name = "ControllerAddNewBarangayModal";
        this.Size = new System.Drawing.Size(614, 797);
        this.Load += new System.EventHandler(this.ControllerAddNewBarangayModal_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.BarangayLogoImage)).EndInit();
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label AddBarangayLabel;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label barangayLogoLabel;
    private System.Windows.Forms.Button uploadBarangayLogoButton;
    private System.Windows.Forms.PictureBox BarangayLogoImage;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.TextBox barangayDescriptionTextBox;
    private System.Windows.Forms.Label Description;
    private System.Windows.Forms.Label barangayNameLabel;
    private System.Windows.Forms.TextBox barangayAddressTextBox;
    private System.Windows.Forms.Label addressLabel;
    private System.Windows.Forms.Button addNewBarangayButton;
    private System.Windows.Forms.Button cancelButton;
    public System.Windows.Forms.TextBox BarangayNameTextBox;
}
}
