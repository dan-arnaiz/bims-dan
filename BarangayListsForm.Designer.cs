namespace BIMS_dan {
partial class BarangayListsForm {
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
    System.ComponentModel.ComponentResourceManager resources =
        new System.ComponentModel.ComponentResourceManager(
            typeof(BarangayListsForm));
    this.label1 = new System.Windows.Forms.Label();
    this.button5 = new System.Windows.Forms.Button();
    this.panel2 = new System.Windows.Forms.Panel();
    this.panel3 = new System.Windows.Forms.Panel();
    this.label2 = new System.Windows.Forms.Label();
    this.panel4 = new System.Windows.Forms.Panel();
    this.panel5 = new System.Windows.Forms.Panel();
    this.panel6 = new System.Windows.Forms.Panel();
    this.selectBarangayButton = new System.Windows.Forms.Button();
    this.editBarangayButton = new System.Windows.Forms.Button();
    this.deleteBarangayButton = new System.Windows.Forms.Button();
    this.panel7 = new System.Windows.Forms.Panel();
    this.panel8 = new System.Windows.Forms.Panel();
    this.panel9 = new System.Windows.Forms.Panel();
    this.panel10 = new System.Windows.Forms.Panel();
    this.pictureBox2 = new System.Windows.Forms.PictureBox();
    this.pictureBox1 = new System.Windows.Forms.PictureBox();
    this.label3 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.label5 = new System.Windows.Forms.Label();
    this.panel1 = new System.Windows.Forms.Panel();
    this.panel2.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panel4.SuspendLayout();
    this.panel5.SuspendLayout();
    this.panel7.SuspendLayout();
    this.panel8.SuspendLayout();
    this.panel9.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    //
    // label1
    //
    this.label1.AutoSize = true;
    this.label1.Font = new System.Drawing.Font(
        "Montserrat", 8.249999F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.ForeColor = System.Drawing.Color.White;
    this.label1.Location = new System.Drawing.Point(77, 18);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(156, 15);
    this.label1.TabIndex = 0;
    this.label1.Text = "Select Barangay to Manage";
    this.label1.Click += new System.EventHandler(this.label1_Click);
    //
    // button5
    //
    this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.button5.Location = new System.Drawing.Point(828, 35);
    this.button5.Name = "button5";
    this.button5.Size = new System.Drawing.Size(123, 23);
    this.button5.TabIndex = 6;
    this.button5.Text = "System User Options";
    this.button5.UseVisualStyleBackColor = true;
    //
    // panel2
    //
    this.panel2.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
    this.panel2.Controls.Add(this.panel1);
    this.panel2.Controls.Add(this.label5);
    this.panel2.Location = new System.Drawing.Point(0, 183);
    this.panel2.Name = "panel2";
    this.panel2.Size = new System.Drawing.Size(310, 157);
    this.panel2.TabIndex = 5;
    //
    // panel3
    //
    this.panel3.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
    this.panel3.Controls.Add(this.label2);
    this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel3.Location = new System.Drawing.Point(0, 0);
    this.panel3.Name = "panel3";
    this.panel3.Size = new System.Drawing.Size(962, 29);
    this.panel3.TabIndex = 6;
    //
    // label2
    //
    this.label2.AutoSize = true;
    this.label2.Font = new System.Drawing.Font(
        "Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label2.ForeColor = System.Drawing.Color.White;
    this.label2.Location = new System.Drawing.Point(371, 7);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(258, 15);
    this.label2.TabIndex = 1;
    this.label2.Text = "Barangay Information Management System";
    this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    //
    // panel4
    //
    this.panel4.BackColor = System.Drawing.Color.White;
    this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.panel4.Controls.Add(this.label3);
    this.panel4.Controls.Add(this.pictureBox2);
    this.panel4.Controls.Add(this.panel3);
    this.panel4.Controls.Add(this.button5);
    this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel4.Location = new System.Drawing.Point(0, 0);
    this.panel4.Name = "panel4";
    this.panel4.Size = new System.Drawing.Size(964, 71);
    this.panel4.TabIndex = 7;
    //
    // panel5
    //
    this.panel5.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
    this.panel5.Controls.Add(this.selectBarangayButton);
    this.panel5.Controls.Add(this.panel2);
    this.panel5.Controls.Add(this.editBarangayButton);
    this.panel5.Controls.Add(this.deleteBarangayButton);
    this.panel5.Controls.Add(this.panel7);
    this.panel5.Controls.Add(this.panel8);
    this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
    this.panel5.Location = new System.Drawing.Point(0, 71);
    this.panel5.Name = "panel5";
    this.panel5.Size = new System.Drawing.Size(310, 510);
    this.panel5.TabIndex = 8;
    //
    // panel6
    //
    this.panel6.BackColor = System.Drawing.Color.White;
    this.panel6.Location = new System.Drawing.Point(317, 77);
    this.panel6.Name = "panel6";
    this.panel6.Size = new System.Drawing.Size(639, 494);
    this.panel6.TabIndex = 9;
    //
    // selectBarangayButton
    //
    this.selectBarangayButton.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
    this.selectBarangayButton.Font =
        new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.selectBarangayButton.ForeColor = System.Drawing.Color.White;
    this.selectBarangayButton.Location = new System.Drawing.Point(102, 346);
    this.selectBarangayButton.Name = "selectBarangayButton";
    this.selectBarangayButton.Size = new System.Drawing.Size(105, 28);
    this.selectBarangayButton.TabIndex = 11;
    this.selectBarangayButton.Text = "Select Barangay";
    this.selectBarangayButton.UseVisualStyleBackColor = false;
    //
    // editBarangayButton
    //
    this.editBarangayButton.BackColor =
        System.Drawing.SystemColors.ButtonHighlight;
    this.editBarangayButton.Font =
        new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.editBarangayButton.ForeColor = System.Drawing.Color.Black;
    this.editBarangayButton.Location = new System.Drawing.Point(102, 380);
    this.editBarangayButton.Name = "editBarangayButton";
    this.editBarangayButton.Size = new System.Drawing.Size(105, 28);
    this.editBarangayButton.TabIndex = 10;
    this.editBarangayButton.Text = "Edit Barangay";
    this.editBarangayButton.UseVisualStyleBackColor = false;
    //
    // deleteBarangayButton
    //
    this.deleteBarangayButton.BackColor = System.Drawing.Color.Maroon;
    this.deleteBarangayButton.Font =
        new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.deleteBarangayButton.ForeColor = System.Drawing.Color.White;
    this.deleteBarangayButton.Location = new System.Drawing.Point(102, 428);
    this.deleteBarangayButton.Name = "deleteBarangayButton";
    this.deleteBarangayButton.Size = new System.Drawing.Size(105, 28);
    this.deleteBarangayButton.TabIndex = 9;
    this.deleteBarangayButton.Text = "Delete Barangay";
    this.deleteBarangayButton.UseVisualStyleBackColor = false;
    //
    // panel7
    //
    this.panel7.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
    this.panel7.Controls.Add(this.pictureBox1);
    this.panel7.Location = new System.Drawing.Point(102, 55);
    this.panel7.Name = "panel7";
    this.panel7.Size = new System.Drawing.Size(105, 105);
    this.panel7.TabIndex = 5;
    //
    // panel8
    //
    this.panel8.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
    this.panel8.Controls.Add(this.label1);
    this.panel8.Controls.Add(this.panel9);
    this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel8.Location = new System.Drawing.Point(0, 0);
    this.panel8.Name = "panel8";
    this.panel8.Size = new System.Drawing.Size(310, 38);
    this.panel8.TabIndex = 6;
    //
    // panel9
    //
    this.panel9.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
    this.panel9.Controls.Add(this.panel10);
    this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel9.Location = new System.Drawing.Point(0, 0);
    this.panel9.Name = "panel9";
    this.panel9.Size = new System.Drawing.Size(310, 16);
    this.panel9.TabIndex = 7;
    //
    // panel10
    //
    this.panel10.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
    this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
    this.panel10.Location = new System.Drawing.Point(0, 0);
    this.panel10.Name = "panel10";
    this.panel10.Size = new System.Drawing.Size(310, 23);
    this.panel10.TabIndex = 6;
    //
    // pictureBox2
    //
    this.pictureBox2.Image = global::BIMS_dan.Properties.Resources._22;
    this.pictureBox2.Location = new System.Drawing.Point(106, 36);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new System.Drawing.Size(24, 24);
    this.pictureBox2.SizeMode =
        System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    this.pictureBox2.TabIndex = 1;
    this.pictureBox2.TabStop = false;
    //
    // pictureBox1
    //
    this.pictureBox1.Location = new System.Drawing.Point(3, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new System.Drawing.Size(99, 99);
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    //
    // label3
    //
    this.label3.AutoSize = true;
    this.label3.BackColor = System.Drawing.Color.Transparent;
    this.label3.Font = new System.Drawing.Font(
        "Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label3.ForeColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
    this.label3.Location = new System.Drawing.Point(130, 33);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(69, 29);
    this.label3.TabIndex = 1;
    this.label3.Text = "BIMS";
    //
    // label4
    //
    this.label4.AutoSize = true;
    this.label4.Font = new System.Drawing.Font(
        "Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label4.ForeColor = System.Drawing.Color.White;
    this.label4.Location = new System.Drawing.Point(48, 12);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(124, 18);
    this.label4.TabIndex = 1;
    this.label4.Text = "Barangay Details";
    this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    //
    // label5
    //
    this.label5.AutoSize = true;
    this.label5.Font = new System.Drawing.Font(
        "Montserrat", 11.25F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label5.ForeColor = System.Drawing.Color.White;
    this.label5.Location = new System.Drawing.Point(62, 6);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(189, 21);
    this.label5.TabIndex = 8;
    this.label5.Text = "Barangay Lorem Ipsum";
    //
    // panel1
    //
    this.panel1.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(110)))));
    this.panel1.Controls.Add(this.label4);
    this.panel1.Location = new System.Drawing.Point(51, 37);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(200, 100);
    this.panel1.TabIndex = 12;
    //
    // BarangayListsForm
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.SystemColors.ControlLight;
    this.ClientSize = new System.Drawing.Size(964, 581);
    this.Controls.Add(this.panel6);
    this.Controls.Add(this.panel5);
    this.Controls.Add(this.panel4);
    this.ForeColor = System.Drawing.Color.Wheat;
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    this.MaximumSize = new System.Drawing.Size(980, 620);
    this.MinimumSize = new System.Drawing.Size(980, 620);
    this.Name = "BarangayListsForm";
    this.Text = "Barangay Information Management System";
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.panel3.ResumeLayout(false);
    this.panel3.PerformLayout();
    this.panel4.ResumeLayout(false);
    this.panel4.PerformLayout();
    this.panel5.ResumeLayout(false);
    this.panel7.ResumeLayout(false);
    this.panel8.ResumeLayout(false);
    this.panel8.PerformLayout();
    this.panel9.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.ResumeLayout(false);
  }

#endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button button5;
  private System.Windows.Forms.Panel panel2;
  private System.Windows.Forms.Panel panel3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Panel panel4;
  private System.Windows.Forms.Panel panel5;
  private System.Windows.Forms.Panel panel6;
  private System.Windows.Forms.Button selectBarangayButton;
  private System.Windows.Forms.Button editBarangayButton;
  private System.Windows.Forms.Button deleteBarangayButton;
  private System.Windows.Forms.Panel panel8;
  private System.Windows.Forms.Panel panel9;
  private System.Windows.Forms.Panel panel10;
  private System.Windows.Forms.Panel panel7;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.PictureBox pictureBox2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Panel panel1;
}
}
