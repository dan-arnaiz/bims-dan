namespace BIMS_dan
{
    partial class ResidentsController
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
            this.ResidentsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ResidentsLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 40);
            this.panel1.TabIndex = 0;
            // 
            // ResidentsLabel
            // 
            this.ResidentsLabel.AutoSize = true;
            this.ResidentsLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentsLabel.Location = new System.Drawing.Point(11, 8);
            this.ResidentsLabel.Name = "ResidentsLabel";
            this.ResidentsLabel.Size = new System.Drawing.Size(87, 21);
            this.ResidentsLabel.TabIndex = 1;
            this.ResidentsLabel.Text = "Residents";
            // 
            // ResidentsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(717, 492);
            this.MinimumSize = new System.Drawing.Size(717, 492);
            this.Name = "ResidentsController";
            this.Size = new System.Drawing.Size(717, 492);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ResidentsLabel;
    }
}
