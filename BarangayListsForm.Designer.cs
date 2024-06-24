namespace BIMS_dan
{
partial class BarangayListsForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.panel1 = new System.Windows.Forms.Panel();
        this.panel2 = new System.Windows.Forms.Panel();
        this.button5 = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        //
        // label1
        //
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.ForeColor = System.Drawing.Color.White;
        this.label1.Location = new System.Drawing.Point(25, 21);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(194, 18);
        this.label1.TabIndex = 0;
        this.label1.Text = "Select Barangay to Manage";
        this.label1.Click += new System.EventHandler(this.label1_Click);
        //
        // button1
        //
        this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.button1.Location = new System.Drawing.Point(68, 201);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(123, 23);
        this.button1.TabIndex = 1;
        this.button1.Text = "Select Barangay";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        //
        // button2
        //
        this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.button2.Location = new System.Drawing.Point(309, 335);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(123, 23);
        this.button2.TabIndex = 2;
        this.button2.Text = "Add New Barangay";
        this.button2.UseVisualStyleBackColor = true;
        //
        // button3
        //
        this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.button3.Location = new System.Drawing.Point(68, 258);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(123, 23);
        this.button3.TabIndex = 3;
        this.button3.Text = "Delete Barangay";
        this.button3.UseVisualStyleBackColor = true;
        //
        // button4
        //
        this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.button4.Location = new System.Drawing.Point(68, 229);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(123, 23);
        this.button4.TabIndex = 4;
        this.button4.Text = "Edit Barangay";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        //
        // panel1
        //
        this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
        this.panel1.Controls.Add(this.button5);
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Controls.Add(this.button3);
        this.panel1.Controls.Add(this.button4);
        this.panel1.Controls.Add(this.button1);
        this.panel1.Location = new System.Drawing.Point(454, 21);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(259, 350);
        this.panel1.TabIndex = 5;
        //
        // panel2
        //
        this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
        this.panel2.Location = new System.Drawing.Point(77, 34);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(105, 105);
        this.panel2.TabIndex = 5;
        //
        // button5
        //
        this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.button5.Location = new System.Drawing.Point(68, 310);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(123, 23);
        this.button5.TabIndex = 6;
        this.button5.Text = "System User Options";
        this.button5.UseVisualStyleBackColor = true;
        //
        // BarangayListsForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
        this.ClientSize = new System.Drawing.Size(744, 395);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.label1);
        this.ForeColor = System.Drawing.Color.Wheat;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Name = "BarangayListsForm";
        this.Text = "Barangay Information Management System";
        this.panel1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Panel panel2;
}
}