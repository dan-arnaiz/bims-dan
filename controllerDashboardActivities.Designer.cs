﻿namespace BIMS_dan
{
    partial class controllerDashboardActivities
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
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editRequestButton = new System.Windows.Forms.Button();
            this.searchBarText = new System.Windows.Forms.TextBox();
            this.deleteRequestButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.newRequestButton = new System.Windows.Forms.Button();
            this.residentsTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DashboardLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 45);
            this.panel1.TabIndex = 0;
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.Location = new System.Drawing.Point(3, 8);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(121, 26);
            this.DashboardLabel.TabIndex = 8;
            this.DashboardLabel.Text = "Dashboard";
            this.DashboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editRequestButton);
            this.panel2.Controls.Add(this.searchBarText);
            this.panel2.Controls.Add(this.deleteRequestButton);
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Controls.Add(this.exportButton);
            this.panel2.Controls.Add(this.newRequestButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 85);
            this.panel2.TabIndex = 6;
            // 
            // editRequestButton
            // 
            this.editRequestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editRequestButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRequestButton.Location = new System.Drawing.Point(498, 51);
            this.editRequestButton.Name = "editRequestButton";
            this.editRequestButton.Size = new System.Drawing.Size(105, 28);
            this.editRequestButton.TabIndex = 7;
            this.editRequestButton.Text = "Edit Request";
            this.editRequestButton.UseVisualStyleBackColor = false;
            // 
            // searchBarText
            // 
            this.searchBarText.Location = new System.Drawing.Point(0, 55);
            this.searchBarText.MinimumSize = new System.Drawing.Size(4, 24);
            this.searchBarText.Name = "searchBarText";
            this.searchBarText.Size = new System.Drawing.Size(222, 24);
            this.searchBarText.TabIndex = 6;
            // 
            // deleteRequestButton
            // 
            this.deleteRequestButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteRequestButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRequestButton.ForeColor = System.Drawing.Color.White;
            this.deleteRequestButton.Location = new System.Drawing.Point(249, 50);
            this.deleteRequestButton.Name = "deleteRequestButton";
            this.deleteRequestButton.Size = new System.Drawing.Size(112, 28);
            this.deleteRequestButton.TabIndex = 5;
            this.deleteRequestButton.Text = "Delete Request";
            this.deleteRequestButton.UseVisualStyleBackColor = false;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.importButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(367, 51);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(63, 28);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(430, 51);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(63, 28);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // newRequestButton
            // 
            this.newRequestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newRequestButton.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequestButton.Location = new System.Drawing.Point(601, 51);
            this.newRequestButton.Name = "newRequestButton";
            this.newRequestButton.Size = new System.Drawing.Size(105, 28);
            this.newRequestButton.TabIndex = 1;
            this.newRequestButton.Text = "New Request";
            this.newRequestButton.UseVisualStyleBackColor = false;
            // 
            // residentsTable
            // 
            this.residentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.residentsTable.Location = new System.Drawing.Point(3, 94);
            this.residentsTable.Name = "residentsTable";
            this.residentsTable.Size = new System.Drawing.Size(711, 395);
            this.residentsTable.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(643, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // controllerDashboardActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.residentsTable);
            this.Name = "controllerDashboardActivities";
            this.Size = new System.Drawing.Size(717, 492);
            this.Load += new System.EventHandler(this.controllerDashboardActivities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editRequestButton;
        private System.Windows.Forms.TextBox searchBarText;
        private System.Windows.Forms.Button deleteRequestButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button newRequestButton;
        private System.Windows.Forms.DataGridView residentsTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
