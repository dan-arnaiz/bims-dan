﻿namespace BIMS_dan {
partial class Form1 {
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
    this.label1 = new System.Windows.Forms.Label();
    this.checkBox1 = new System.Windows.Forms.CheckBox();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    //
    // panel1
    //
    this.panel1.Controls.Add(this.checkBox1);
    this.panel1.Controls.Add(this.label1);
    this.panel1.Location = new System.Drawing.Point(12, 12);
    this.panel1.Name = "panel1";
    this.panel1.Size = new System.Drawing.Size(776, 426);
    this.panel1.TabIndex = 0;
    //
    // label1
    //
    this.label1.AutoSize = true;
    this.label1.Location = new System.Drawing.Point(278, 180);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(204, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Testing Git version control across devices";
    this.label1.Click += new System.EventHandler(this.label1_Click);
    //
    // checkBox1
    //
    this.checkBox1.AutoSize = true;
    this.checkBox1.Location = new System.Drawing.Point(290, 196);
    this.checkBox1.Name = "checkBox1";
    this.checkBox1.Size = new System.Drawing.Size(177, 17);
    this.checkBox1.TabIndex = 1;
    this.checkBox1.Text = "Check this if the test successfull";
    this.checkBox1.UseVisualStyleBackColor = true;
    //
    // Form1
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(800, 450);
    this.Controls.Add(this.panel1);
    this.Name = "Form1";
    this.Text = "Barangay Information Management System";
    this.Load += new System.EventHandler(this.Form1_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.ResumeLayout(false);
  }

#endregion

  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.CheckBox checkBox1;
}
}
