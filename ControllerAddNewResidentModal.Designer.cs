namespace BIMS_dan {
partial class ControllerAddNewResidentModal {
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

#region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.panel2 = new System.Windows.Forms.Panel();
    this.AddResidentsLabel = new System.Windows.Forms.Label();
    this.cancelButton = new System.Windows.Forms.Button();
    this.addNewResidentButton = new System.Windows.Forms.Button();
    this.panel3 = new System.Windows.Forms.Panel();
    this.panel5 = new System.Windows.Forms.Panel();
    this.label1 = new System.Windows.Forms.Label();
    this.lastNameTextBox = new System.Windows.Forms.TextBox();
    this.occupationTextBox = new System.Windows.Forms.TextBox();
    this.firstNameTextBox = new System.Windows.Forms.TextBox();
    this.label10 = new System.Windows.Forms.Label();
    this.middleNameTextBox = new System.Windows.Forms.TextBox();
    this.yearsResidingTextBox = new System.Windows.Forms.TextBox();
    this.suffixTextBox = new System.Windows.Forms.TextBox();
    this.label9 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.addressTextBox = new System.Windows.Forms.TextBox();
    this.label2 = new System.Windows.Forms.Label();
    this.label8 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.civilStatusDropdown = new System.Windows.Forms.ComboBox();
    this.sexDropdown = new System.Windows.Forms.ComboBox();
    this.label7 = new System.Windows.Forms.Label();
    this.label5 = new System.Windows.Forms.Label();
    this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
    this.label6 = new System.Windows.Forms.Label();
    this.panel4 = new System.Windows.Forms.Panel();
    this.label11 = new System.Windows.Forms.Label();
    this.uploadPhotoButton = new System.Windows.Forms.Button();
    this.panel1 = new System.Windows.Forms.Panel();
    this.idImage = new System.Windows.Forms.PictureBox();
    this.pictureBox1 = new System.Windows.Forms.PictureBox();
    this.label12 = new System.Windows.Forms.Label();
    this.ageTextBox = new System.Windows.Forms.TextBox();
    this.panel2.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panel5.SuspendLayout();
    this.panel4.SuspendLayout();
    this.panel1.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.idImage)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    this.SuspendLayout();
    //
    // panel2
    //
    this.panel2.BackColor = System.Drawing.Color.White;
    this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.panel2.Controls.Add(this.AddResidentsLabel);
    this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel2.Location = new System.Drawing.Point(0, 0);
    this.panel2.Name = "panel2";
    this.panel2.Size = new System.Drawing.Size(631, 44);
    this.panel2.TabIndex = 5;
    this.panel2.Paint +=
        new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
    //
    // AddResidentsLabel
    //
    this.AddResidentsLabel.AutoSize = true;
    this.AddResidentsLabel.Font = new System.Drawing.Font(
        "Montserrat", 11.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.AddResidentsLabel.Location = new System.Drawing.Point(23, 10);
    this.AddResidentsLabel.Name = "AddResidentsLabel";
    this.AddResidentsLabel.Size = new System.Drawing.Size(153, 21);
    this.AddResidentsLabel.TabIndex = 7;
    this.AddResidentsLabel.Text = "Add New Resident";
    this.AddResidentsLabel.TextAlign =
        System.Drawing.ContentAlignment.MiddleLeft;
    //
    // cancelButton
    //
    this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDark;
    this.cancelButton.Font =
        new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.cancelButton.ForeColor = System.Drawing.Color.Black;
    this.cancelButton.Location = new System.Drawing.Point(390, 268);
    this.cancelButton.Name = "cancelButton";
    this.cancelButton.Size = new System.Drawing.Size(105, 28);
    this.cancelButton.TabIndex = 6;
    this.cancelButton.Text = "Cancel";
    this.cancelButton.UseVisualStyleBackColor = false;
    this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
    //
    // addNewResidentButton
    //
    this.addNewResidentButton.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
    this.addNewResidentButton.Font =
        new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.addNewResidentButton.ForeColor = System.Drawing.Color.White;
    this.addNewResidentButton.Location = new System.Drawing.Point(501, 268);
    this.addNewResidentButton.Name = "addNewResidentButton";
    this.addNewResidentButton.Size = new System.Drawing.Size(105, 28);
    this.addNewResidentButton.TabIndex = 5;
    this.addNewResidentButton.Text = "Add Resident";
    this.addNewResidentButton.UseVisualStyleBackColor = false;
    this.addNewResidentButton.Click +=
        new System.EventHandler(this.addNewResidentButton_Click);
    //
    // panel3
    //
    this.panel3.BackColor = System.Drawing.Color.White;
    this.panel3.Controls.Add(this.panel5);
    this.panel3.Controls.Add(this.panel4);
    this.panel3.Location = new System.Drawing.Point(12, 50);
    this.panel3.Name = "panel3";
    this.panel3.Size = new System.Drawing.Size(594, 203);
    this.panel3.TabIndex = 4;
    //
    // panel5
    //
    this.panel5.Controls.Add(this.ageTextBox);
    this.panel5.Controls.Add(this.label12);
    this.panel5.Controls.Add(this.addressTextBox);
    this.panel5.Controls.Add(this.label8);
    this.panel5.Controls.Add(this.label1);
    this.panel5.Controls.Add(this.lastNameTextBox);
    this.panel5.Controls.Add(this.occupationTextBox);
    this.panel5.Controls.Add(this.firstNameTextBox);
    this.panel5.Controls.Add(this.label10);
    this.panel5.Controls.Add(this.middleNameTextBox);
    this.panel5.Controls.Add(this.yearsResidingTextBox);
    this.panel5.Controls.Add(this.suffixTextBox);
    this.panel5.Controls.Add(this.label9);
    this.panel5.Controls.Add(this.label3);
    this.panel5.Controls.Add(this.label2);
    this.panel5.Controls.Add(this.label4);
    this.panel5.Controls.Add(this.civilStatusDropdown);
    this.panel5.Controls.Add(this.sexDropdown);
    this.panel5.Controls.Add(this.label7);
    this.panel5.Controls.Add(this.label5);
    this.panel5.Controls.Add(this.birthDatePicker);
    this.panel5.Controls.Add(this.label6);
    this.panel5.Location = new System.Drawing.Point(140, 15);
    this.panel5.Name = "panel5";
    this.panel5.Size = new System.Drawing.Size(439, 166);
    this.panel5.TabIndex = 34;
    //
    // label1
    //
    this.label1.AutoSize = true;
    this.label1.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.Location = new System.Drawing.Point(3, 9);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(70, 15);
    this.label1.TabIndex = 8;
    this.label1.Text = "Last Name";
    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // lastNameTextBox
    //
    this.lastNameTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lastNameTextBox.Location = new System.Drawing.Point(6, 28);
    this.lastNameTextBox.Name = "lastNameTextBox";
    this.lastNameTextBox.Size = new System.Drawing.Size(96, 21);
    this.lastNameTextBox.TabIndex = 9;
    this.lastNameTextBox.TextChanged +=
        new System.EventHandler(this.lastNameTextBox_TextChanged);
    //
    // occupationTextBox
    //
    this.occupationTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.occupationTextBox.Location = new System.Drawing.Point(289, 96);
    this.occupationTextBox.Name = "occupationTextBox";
    this.occupationTextBox.Size = new System.Drawing.Size(147, 21);
    this.occupationTextBox.TabIndex = 31;
    this.occupationTextBox.TextChanged +=
        new System.EventHandler(this.occupationTextBox_TextChanged);
    //
    // firstNameTextBox
    //
    this.firstNameTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.firstNameTextBox.Location = new System.Drawing.Point(108, 28);
    this.firstNameTextBox.Name = "firstNameTextBox";
    this.firstNameTextBox.Size = new System.Drawing.Size(148, 21);
    this.firstNameTextBox.TabIndex = 11;
    this.firstNameTextBox.TextChanged +=
        new System.EventHandler(this.firstNameTextBox_TextChanged);
    //
    // label10
    //
    this.label10.AutoSize = true;
    this.label10.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label10.Location = new System.Drawing.Point(207, 101);
    this.label10.Name = "label10";
    this.label10.Size = new System.Drawing.Size(79, 15);
    this.label10.TabIndex = 30;
    this.label10.Text = "Occupation:";
    this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // middleNameTextBox
    //
    this.middleNameTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.middleNameTextBox.Location = new System.Drawing.Point(262, 28);
    this.middleNameTextBox.Name = "middleNameTextBox";
    this.middleNameTextBox.Size = new System.Drawing.Size(97, 21);
    this.middleNameTextBox.TabIndex = 12;
    this.middleNameTextBox.TextChanged +=
        new System.EventHandler(this.middleNameTextBox_TextChanged);
    //
    // yearsResidingTextBox
    //
    this.yearsResidingTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.yearsResidingTextBox.Location = new System.Drawing.Point(170, 97);
    this.yearsResidingTextBox.Name = "yearsResidingTextBox";
    this.yearsResidingTextBox.Size = new System.Drawing.Size(30, 21);
    this.yearsResidingTextBox.TabIndex = 29;
    this.yearsResidingTextBox.TextChanged +=
        new System.EventHandler(this.yearsResidingTextBox_TextChanged);
    //
    // suffixTextBox
    //
    this.suffixTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.suffixTextBox.Location = new System.Drawing.Point(365, 28);
    this.suffixTextBox.Name = "suffixTextBox";
    this.suffixTextBox.Size = new System.Drawing.Size(71, 21);
    this.suffixTextBox.TabIndex = 13;
    this.suffixTextBox.TextChanged +=
        new System.EventHandler(this.suffixTextBox_TextChanged);
    //
    // label9
    //
    this.label9.AutoSize = true;
    this.label9.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label9.Location = new System.Drawing.Point(69, 100);
    this.label9.Name = "label9";
    this.label9.Size = new System.Drawing.Size(95, 15);
    this.label9.TabIndex = 28;
    this.label9.Text = "Years Residing:";
    this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // label3
    //
    this.label3.AutoSize = true;
    this.label3.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label3.Location = new System.Drawing.Point(105, 9);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(71, 15);
    this.label3.TabIndex = 14;
    this.label3.Text = "First Name";
    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // addressTextBox
    //
    this.addressTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.addressTextBox.Location = new System.Drawing.Point(67, 130);
    this.addressTextBox.Name = "addressTextBox";
    this.addressTextBox.Size = new System.Drawing.Size(369, 21);
    this.addressTextBox.TabIndex = 27;
    this.addressTextBox.TextChanged +=
        new System.EventHandler(this.addressTextBox_TextChanged);
    //
    // label2
    //
    this.label2.AutoSize = true;
    this.label2.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label2.Location = new System.Drawing.Point(259, 9);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(85, 15);
    this.label2.TabIndex = 15;
    this.label2.Text = "Middle Name";
    this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    this.label2.Click += new System.EventHandler(this.label2_Click);
    //
    // label8
    //
    this.label8.AutoSize = true;
    this.label8.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label8.Location = new System.Drawing.Point(3, 132);
    this.label8.Name = "label8";
    this.label8.Size = new System.Drawing.Size(58, 15);
    this.label8.TabIndex = 26;
    this.label8.Text = "Address:";
    this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // label4
    //
    this.label4.AutoSize = true;
    this.label4.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label4.Location = new System.Drawing.Point(362, 9);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(41, 15);
    this.label4.TabIndex = 16;
    this.label4.Text = "Suffix";
    this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
    //
    // civilStatusDropdown
    //
    this.civilStatusDropdown.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.civilStatusDropdown.FormattingEnabled = true;
    this.civilStatusDropdown.ImeMode = System.Windows.Forms.ImeMode.Disable;
    this.civilStatusDropdown.Items.AddRange(
        new object[] { "Single", "Married", "Separated", "Divorced",
                       "Widowed" });
    this.civilStatusDropdown.Location = new System.Drawing.Point(360, 62);
    this.civilStatusDropdown.Name = "civilStatusDropdown";
    this.civilStatusDropdown.Size = new System.Drawing.Size(76, 23);
    this.civilStatusDropdown.TabIndex = 25;
    this.civilStatusDropdown.SelectedIndexChanged +=
        new System.EventHandler(this.civilStatusDropdown_SelectedIndexChanged);
    //
    // sexDropdown
    //
    this.sexDropdown.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.sexDropdown.FormattingEnabled = true;
    this.sexDropdown.ImeMode = System.Windows.Forms.ImeMode.Disable;
    this.sexDropdown.Items.AddRange(
        new object[] { "Male", "Female", "Unknown" });
    this.sexDropdown.Location = new System.Drawing.Point(206, 62);
    this.sexDropdown.Name = "sexDropdown";
    this.sexDropdown.Size = new System.Drawing.Size(79, 23);
    this.sexDropdown.TabIndex = 20;
    this.sexDropdown.SelectedIndexChanged +=
        new System.EventHandler(this.sexDropdown_SelectedIndexChanged);
    //
    // label7
    //
    this.label7.AutoSize = true;
    this.label7.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label7.Location = new System.Drawing.Point(286, 67);
    this.label7.Name = "label7";
    this.label7.Size = new System.Drawing.Size(75, 15);
    this.label7.TabIndex = 24;
    this.label7.Text = "Civil Status:";
    this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // label5
    //
    this.label5.AutoSize = true;
    this.label5.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label5.Location = new System.Drawing.Point(174, 65);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(31, 15);
    this.label5.TabIndex = 21;
    this.label5.Text = "Sex:";
    this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // birthDatePicker
    //
    this.birthDatePicker.CustomFormat = "MM/dd/yyyy";
    this.birthDatePicker.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.birthDatePicker.Format =
        System.Windows.Forms.DateTimePickerFormat.Custom;
    this.birthDatePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
    this.birthDatePicker.Location = new System.Drawing.Point(72, 62);
    this.birthDatePicker.MaxDate = new System.DateTime(2024, 6, 30, 0, 0, 0, 0);
    this.birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
    this.birthDatePicker.Name = "birthDatePicker";
    this.birthDatePicker.Size = new System.Drawing.Size(100, 21);
    this.birthDatePicker.TabIndex = 23;
    this.birthDatePicker.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
    this.birthDatePicker.ValueChanged +=
        new System.EventHandler(this.birthDatePicker_ValueChanged);
    //
    // label6
    //
    this.label6.AutoSize = true;
    this.label6.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label6.Location = new System.Drawing.Point(3, 65);
    this.label6.Name = "label6";
    this.label6.Size = new System.Drawing.Size(70, 15);
    this.label6.TabIndex = 22;
    this.label6.Text = "Birth Date:";
    this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // panel4
    //
    this.panel4.Controls.Add(this.label11);
    this.panel4.Controls.Add(this.uploadPhotoButton);
    this.panel4.Controls.Add(this.idImage);
    this.panel4.Location = new System.Drawing.Point(16, 15);
    this.panel4.Name = "panel4";
    this.panel4.Size = new System.Drawing.Size(116, 166);
    this.panel4.TabIndex = 33;
    //
    // label11
    //
    this.label11.AutoSize = true;
    this.label11.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label11.Location = new System.Drawing.Point(25, 110);
    this.label11.Name = "label11";
    this.label11.Size = new System.Drawing.Size(66, 15);
    this.label11.TabIndex = 34;
    this.label11.Text = "ID Picture";
    this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // uploadPhotoButton
    //
    this.uploadPhotoButton.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.uploadPhotoButton.Location = new System.Drawing.Point(28, 130);
    this.uploadPhotoButton.Name = "uploadPhotoButton";
    this.uploadPhotoButton.Size = new System.Drawing.Size(63, 23);
    this.uploadPhotoButton.TabIndex = 32;
    this.uploadPhotoButton.Text = "Upload";
    this.uploadPhotoButton.UseVisualStyleBackColor = true;
    this.uploadPhotoButton.Click +=
        new System.EventHandler(this.uploadPhotoButton_Click);
    //
    // panel1
    //
    this.panel1.Controls.Add(this.panel3);
    this.panel1.Controls.Add(this.addNewResidentButton);
    this.panel1.Controls.Add(this.cancelButton);
    this.panel1.Controls.Add(this.pictureBox1);
    this.panel1.Location = new System.Drawing.Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(633, 319);
    this.panel1.TabIndex = 2;
    //
    // idImage
    //
    this.idImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.idImage.InitialImage = global::BIMS_dan.Properties.Resources._22;
    this.idImage.Location = new System.Drawing.Point(9, 7);
    this.idImage.Name = "idImage";
    this.idImage.Size = new System.Drawing.Size(100, 100);
    this.idImage.TabIndex = 33;
    this.idImage.TabStop = false;
    this.idImage.Click += new System.EventHandler(this.idImage_Click);
    //
    // pictureBox1
    //
    this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.pictureBox1.Image = global::BIMS_dan.Properties.Resources._32;
    this.pictureBox1.Location = new System.Drawing.Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new System.Drawing.Size(633, 319);
    this.pictureBox1.SizeMode =
        System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
    //
    // label12
    //
    this.label12.AutoSize = true;
    this.label12.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label12.Location = new System.Drawing.Point(3, 100);
    this.label12.Name = "label12";
    this.label12.Size = new System.Drawing.Size(33, 15);
    this.label12.TabIndex = 32;
    this.label12.Text = "Age:";
    this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    //
    // ageTextBox
    //
    this.ageTextBox.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.ageTextBox.Location = new System.Drawing.Point(37, 97);
    this.ageTextBox.Name = "ageTextBox";
    this.ageTextBox.Size = new System.Drawing.Size(27, 21);
    this.ageTextBox.TabIndex = 34;
    //
    // ControllerAddNewResidentModal
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.AutoValidate =
        System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
    this.BackColor = System.Drawing.SystemColors.ControlLight;
    this.Controls.Add(this.panel2);
    this.Controls.Add(this.panel1);
    this.MaximumSize = new System.Drawing.Size(631, 348);
    this.MinimumSize = new System.Drawing.Size(631, 348);
    this.Name = "ControllerAddNewResidentModal";
    this.Size = new System.Drawing.Size(631, 348);
    this.Load +=
        new System.EventHandler(this.ControllerAddNewResidentModal_Load);
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.panel3.ResumeLayout(false);
    this.panel5.ResumeLayout(false);
    this.panel5.PerformLayout();
    this.panel4.ResumeLayout(false);
    this.panel4.PerformLayout();
    this.panel1.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)(this.idImage)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
    this.ResumeLayout(false);
  }

#endregion
  private System.Windows.Forms.Panel panel2;
  private System.Windows.Forms.Label AddResidentsLabel;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Button cancelButton;
  private System.Windows.Forms.Button addNewResidentButton;
  private System.Windows.Forms.Panel panel3;
  private System.Windows.Forms.Panel panel5;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox lastNameTextBox;
  private System.Windows.Forms.TextBox occupationTextBox;
  private System.Windows.Forms.TextBox firstNameTextBox;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox middleNameTextBox;
  private System.Windows.Forms.TextBox yearsResidingTextBox;
  private System.Windows.Forms.TextBox suffixTextBox;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox addressTextBox;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox civilStatusDropdown;
  private System.Windows.Forms.ComboBox sexDropdown;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label5;
  public System.Windows.Forms.DateTimePicker birthDatePicker;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Panel panel4;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Button uploadPhotoButton;
  private System.Windows.Forms.PictureBox idImage;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.TextBox ageTextBox;
}
}
