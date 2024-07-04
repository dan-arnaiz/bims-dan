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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarangayListsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selectBarangayButton = new System.Windows.Forms.Button();
            this.editBarangayButton = new System.Windows.Forms.Button();
            this.deleteBarangayButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BarangayLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBarangayText = new System.Windows.Forms.TextBox();
            this.addBarangayButton = new System.Windows.Forms.Button();
            this.BarangaytableSettingsButton = new System.Windows.Forms.Button();
            this.refreshBarangayTable = new System.Windows.Forms.Button();
            this.systemUserOptions = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._dan_bimsBarangayDataset = new BIMS_dan._dan_bimsBarangayDataset();
            this.barangaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangaysTableAdapter = new BIMS_dan._dan_bimsBarangayDatasetTableAdapters.BarangaysTableAdapter();
            this.barangayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangayLogoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.barangayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dan_bimsBarangayDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangaysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Barangay to Manage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 242);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(76, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 154);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barangay Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barangay Lorem Ipsum";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1435, 45);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(556, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barangay Information Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.systemUserOptions);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1437, 108);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "BIMS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel5.Controls.Add(this.selectBarangayButton);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.editBarangayButton);
            this.panel5.Controls.Add(this.deleteBarangayButton);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 108);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 760);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // selectBarangayButton
            // 
            this.selectBarangayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
            this.selectBarangayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBarangayButton.ForeColor = System.Drawing.Color.White;
            this.selectBarangayButton.Location = new System.Drawing.Point(153, 532);
            this.selectBarangayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectBarangayButton.Name = "selectBarangayButton";
            this.selectBarangayButton.Size = new System.Drawing.Size(158, 43);
            this.selectBarangayButton.TabIndex = 11;
            this.selectBarangayButton.Text = "Select Barangay";
            this.selectBarangayButton.UseVisualStyleBackColor = false;
            // 
            // editBarangayButton
            // 
            this.editBarangayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBarangayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBarangayButton.ForeColor = System.Drawing.Color.Black;
            this.editBarangayButton.Location = new System.Drawing.Point(153, 585);
            this.editBarangayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBarangayButton.Name = "editBarangayButton";
            this.editBarangayButton.Size = new System.Drawing.Size(158, 43);
            this.editBarangayButton.TabIndex = 10;
            this.editBarangayButton.Text = "Edit Barangay";
            this.editBarangayButton.UseVisualStyleBackColor = false;
            // 
            // deleteBarangayButton
            // 
            this.deleteBarangayButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteBarangayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBarangayButton.ForeColor = System.Drawing.Color.White;
            this.deleteBarangayButton.Location = new System.Drawing.Point(153, 658);
            this.deleteBarangayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBarangayButton.Name = "deleteBarangayButton";
            this.deleteBarangayButton.Size = new System.Drawing.Size(158, 43);
            this.deleteBarangayButton.TabIndex = 9;
            this.deleteBarangayButton.Text = "Delete Barangay";
            this.deleteBarangayButton.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(153, 85);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(158, 162);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(102)))));
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(465, 58);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(465, 25);
            this.panel9.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(465, 35);
            this.panel10.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Location = new System.Drawing.Point(476, 118);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(948, 750);
            this.panel6.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.searchLabel);
            this.panel11.Controls.Add(this.searchBarangayText);
            this.panel11.Controls.Add(this.addBarangayButton);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(948, 136);
            this.panel11.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.BarangaytableSettingsButton);
            this.panel12.Controls.Add(this.refreshBarangayTable);
            this.panel12.Controls.Add(this.BarangayLabel);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(946, 73);
            this.panel12.TabIndex = 0;
            // 
            // BarangayLabel
            // 
            this.BarangayLabel.AutoSize = true;
            this.BarangayLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangayLabel.ForeColor = System.Drawing.Color.Black;
            this.BarangayLabel.Location = new System.Drawing.Point(23, 13);
            this.BarangayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BarangayLabel.Name = "BarangayLabel";
            this.BarangayLabel.Size = new System.Drawing.Size(162, 40);
            this.BarangayLabel.TabIndex = 2;
            this.BarangayLabel.Text = "Barangay";
            this.BarangayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLabel.Location = new System.Drawing.Point(27, 91);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(74, 20);
            this.searchLabel.TabIndex = 19;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBarangayText
            // 
            this.searchBarangayText.Location = new System.Drawing.Point(109, 89);
            this.searchBarangayText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBarangayText.MinimumSize = new System.Drawing.Size(4, 24);
            this.searchBarangayText.Name = "searchBarangayText";
            this.searchBarangayText.Size = new System.Drawing.Size(264, 26);
            this.searchBarangayText.TabIndex = 17;
            // 
            // addBarangayButton
            // 
            this.addBarangayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.addBarangayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBarangayButton.ForeColor = System.Drawing.Color.White;
            this.addBarangayButton.Location = new System.Drawing.Point(714, 80);
            this.addBarangayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBarangayButton.Name = "addBarangayButton";
            this.addBarangayButton.Size = new System.Drawing.Size(216, 43);
            this.addBarangayButton.TabIndex = 13;
            this.addBarangayButton.Text = "Add New Barangay";
            this.addBarangayButton.UseVisualStyleBackColor = false;
            this.addBarangayButton.Click += new System.EventHandler(this.addBarangayButton_Click);
            // 
            // BarangaytableSettingsButton
            // 
            this.BarangaytableSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BarangaytableSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangaytableSettingsButton.ForeColor = System.Drawing.Color.Black;
            this.BarangaytableSettingsButton.Location = new System.Drawing.Point(666, 13);
            this.BarangaytableSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarangaytableSettingsButton.Name = "BarangaytableSettingsButton";
            this.BarangaytableSettingsButton.Size = new System.Drawing.Size(163, 43);
            this.BarangaytableSettingsButton.TabIndex = 17;
            this.BarangaytableSettingsButton.Text = "Table Settings";
            this.BarangaytableSettingsButton.UseVisualStyleBackColor = false;
            // 
            // refreshBarangayTable
            // 
            this.refreshBarangayTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshBarangayTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBarangayTable.ForeColor = System.Drawing.Color.Black;
            this.refreshBarangayTable.Location = new System.Drawing.Point(835, 13);
            this.refreshBarangayTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshBarangayTable.Name = "refreshBarangayTable";
            this.refreshBarangayTable.Size = new System.Drawing.Size(94, 43);
            this.refreshBarangayTable.TabIndex = 16;
            this.refreshBarangayTable.Text = "Refresh";
            this.refreshBarangayTable.UseVisualStyleBackColor = false;
            // 
            // systemUserOptions
            // 
            this.systemUserOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.systemUserOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUserOptions.ForeColor = System.Drawing.Color.Black;
            this.systemUserOptions.Location = new System.Drawing.Point(1207, 52);
            this.systemUserOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.systemUserOptions.Name = "systemUserOptions";
            this.systemUserOptions.Size = new System.Drawing.Size(216, 43);
            this.systemUserOptions.TabIndex = 18;
            this.systemUserOptions.Text = "System User Options";
            this.systemUserOptions.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barangayIDDataGridViewTextBoxColumn,
            this.barangayLogoDataGridViewImageColumn,
            this.barangayNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangaysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 606);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BIMS_dan.Properties.Resources._22;
            this.pictureBox2.Location = new System.Drawing.Point(159, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // _dan_bimsBarangayDataset
            // 
            this._dan_bimsBarangayDataset.DataSetName = "_dan_bimsBarangayDataset";
            this._dan_bimsBarangayDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangaysBindingSource
            // 
            this.barangaysBindingSource.DataMember = "Barangays";
            this.barangaysBindingSource.DataSource = this._dan_bimsBarangayDataset;
            // 
            // barangaysTableAdapter
            // 
            this.barangaysTableAdapter.ClearBeforeFill = true;
            // 
            // barangayIDDataGridViewTextBoxColumn
            // 
            this.barangayIDDataGridViewTextBoxColumn.DataPropertyName = "BarangayID";
            this.barangayIDDataGridViewTextBoxColumn.HeaderText = "BarangayID";
            this.barangayIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.barangayIDDataGridViewTextBoxColumn.Name = "barangayIDDataGridViewTextBoxColumn";
            this.barangayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.barangayIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // barangayLogoDataGridViewImageColumn
            // 
            this.barangayLogoDataGridViewImageColumn.DataPropertyName = "BarangayLogo";
            this.barangayLogoDataGridViewImageColumn.HeaderText = "BarangayLogo";
            this.barangayLogoDataGridViewImageColumn.MinimumWidth = 8;
            this.barangayLogoDataGridViewImageColumn.Name = "barangayLogoDataGridViewImageColumn";
            this.barangayLogoDataGridViewImageColumn.Width = 150;
            // 
            // barangayNameDataGridViewTextBoxColumn
            // 
            this.barangayNameDataGridViewTextBoxColumn.DataPropertyName = "BarangayName";
            this.barangayNameDataGridViewTextBoxColumn.HeaderText = "BarangayName";
            this.barangayNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.barangayNameDataGridViewTextBoxColumn.Name = "barangayNameDataGridViewTextBoxColumn";
            this.barangayNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // BarangayListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1437, 868);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Wheat;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1459, 924);
            this.MinimumSize = new System.Drawing.Size(1459, 924);
            this.Name = "BarangayListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay Information Management System";
            this.Load += new System.EventHandler(this.BarangayListsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dan_bimsBarangayDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangaysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label BarangayLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBarangayText;
        private System.Windows.Forms.Button addBarangayButton;
        private System.Windows.Forms.Button BarangaytableSettingsButton;
        private System.Windows.Forms.Button refreshBarangayTable;
        private System.Windows.Forms.Button systemUserOptions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _dan_bimsBarangayDataset _dan_bimsBarangayDataset;
        private System.Windows.Forms.BindingSource barangaysBindingSource;
        private _dan_bimsBarangayDatasetTableAdapters.BarangaysTableAdapter barangaysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn barangayLogoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}