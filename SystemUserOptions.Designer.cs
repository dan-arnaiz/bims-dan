namespace BIMS_dan {
partial class SystemUserOptions {
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
    this.panel1 = new System.Windows.Forms.Panel();
    this.button5 = new System.Windows.Forms.Button();
    this.panel2 = new System.Windows.Forms.Panel();
    this.button3 = new System.Windows.Forms.Button();
    this.button4 = new System.Windows.Forms.Button();
    this.button1 = new System.Windows.Forms.Button();
    this.label1 = new System.Windows.Forms.Label();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    //
    // panel1
    //
    this.panel1.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
    this.panel1.Controls.Add(this.panel2);
    this.panel1.Controls.Add(this.button3);
    this.panel1.Controls.Add(this.button1);
    this.panel1.Controls.Add(this.button4);
    this.panel1.Location = new System.Drawing.Point(445, 53);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(229, 266);
    this.panel1.TabIndex = 6;
    //
    // button5
    //
    this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.button5.Location = new System.Drawing.Point(590, 343);
    this.button5.Name = "button5";
    this.button5.Size = new System.Drawing.Size(123, 23);
    this.button5.TabIndex = 6;
    this.button5.Text = "System User Options";
    this.button5.UseVisualStyleBackColor = true;
    //
    // panel2
    //
    this.panel2.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
    this.panel2.Location = new System.Drawing.Point(51, 23);
    this.panel2.Name = "panel2";
    this.panel2.Size = new System.Drawing.Size(123, 113);
    this.panel2.TabIndex = 5;
    //
    // button3
    //
    this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.button3.Location = new System.Drawing.Point(51, 225);
    this.button3.Name = "button3";
    this.button3.Size = new System.Drawing.Size(123, 23);
    this.button3.TabIndex = 3;
    this.button3.Text = "Delete User";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new System.EventHandler(this.button3_Click);
    //
    // button4
    //
    this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.button4.Location = new System.Drawing.Point(51, 196);
    this.button4.Name = "button4";
    this.button4.Size = new System.Drawing.Size(123, 23);
    this.button4.TabIndex = 4;
    this.button4.Text = "Create a User";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new System.EventHandler(this.button4_Click);
    //
    // button1
    //
    this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.button1.Location = new System.Drawing.Point(51, 167);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(123, 23);
    this.button1.TabIndex = 1;
    this.button1.Text = "Admin User";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
    //
    // label1
    //
    this.label1.AutoSize = true;
    this.label1.Font = new System.Drawing.Font(
        "Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.ForeColor = System.Drawing.Color.White;
    this.label1.Location = new System.Drawing.Point(485, 22);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(151, 18);
    this.label1.TabIndex = 7;
    this.label1.Text = "System User Options";
    //
    // SystemUserOptions
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.FromArgb(
        ((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
    this.ClientSize = new System.Drawing.Size(744, 395);
    this.Controls.Add(this.label1);
    this.Controls.Add(this.button5);
    this.Controls.Add(this.panel1);
    this.Name = "SystemUserOptions";
    this.Text = "Barangay Information Management System";
    this.Load += new System.EventHandler(this.SystemUserOptions_Load);
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

#endregion

  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Button button5;
  private System.Windows.Forms.Panel panel2;
  private System.Windows.Forms.Button button3;
  private System.Windows.Forms.Button button4;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Label label1;
}
}
