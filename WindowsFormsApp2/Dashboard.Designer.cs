
namespace WindowsFormsApp2
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker_duration = new System.Windows.Forms.DateTimePicker();
            this.textBox_fare = new System.Windows.Forms.TextBox();
            this.dataGridView_StationLink = new System.Windows.Forms.DataGridView();
            this.btn_update_stationlink = new System.Windows.Forms.Button();
            this.lbl_toStation = new System.Windows.Forms.Label();
            this.lbl_fromStation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stationName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_page = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StationLink)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationToolStripMenuItem,
            this.stationLinksToolStripMenuItem,
            this.searchHistoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stationToolStripMenuItem
            // 
            this.stationToolStripMenuItem.Name = "stationToolStripMenuItem";
            this.stationToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.stationToolStripMenuItem.Text = "Station";
            this.stationToolStripMenuItem.Click += new System.EventHandler(this.stationToolStripMenuItem_Click);
            // 
            // stationLinksToolStripMenuItem
            // 
            this.stationLinksToolStripMenuItem.Name = "stationLinksToolStripMenuItem";
            this.stationLinksToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.stationLinksToolStripMenuItem.Text = "Station Links";
            this.stationLinksToolStripMenuItem.Click += new System.EventHandler(this.stationLinksToolStripMenuItem_Click);
            // 
            // searchHistoryToolStripMenuItem
            // 
            this.searchHistoryToolStripMenuItem.Name = "searchHistoryToolStripMenuItem";
            this.searchHistoryToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.searchHistoryToolStripMenuItem.Text = "Search History";
            this.searchHistoryToolStripMenuItem.Click += new System.EventHandler(this.searchHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.Location = new System.Drawing.Point(258, 23);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(86, 17);
            this.lbl_loading.TabIndex = 2;
            this.lbl_loading.Text = "Loading... ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.datePicker_duration);
            this.panel2.Controls.Add(this.textBox_fare);
            this.panel2.Controls.Add(this.dataGridView_StationLink);
            this.panel2.Controls.Add(this.btn_update_stationlink);
            this.panel2.Controls.Add(this.lbl_toStation);
            this.panel2.Controls.Add(this.lbl_fromStation);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 385);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HH:mm";
            // 
            // datePicker_duration
            // 
            this.datePicker_duration.Location = new System.Drawing.Point(117, 51);
            this.datePicker_duration.Name = "datePicker_duration";
            this.datePicker_duration.Size = new System.Drawing.Size(100, 20);
            this.datePicker_duration.TabIndex = 9;
            // 
            // textBox_fare
            // 
            this.textBox_fare.Location = new System.Drawing.Point(117, 23);
            this.textBox_fare.Name = "textBox_fare";
            this.textBox_fare.Size = new System.Drawing.Size(100, 20);
            this.textBox_fare.TabIndex = 8;
            this.textBox_fare.TextChanged += new System.EventHandler(this.textBox_fare_TextChanged);
            // 
            // dataGridView_StationLink
            // 
            this.dataGridView_StationLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_StationLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_StationLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StationLink.Location = new System.Drawing.Point(15, 132);
            this.dataGridView_StationLink.Name = "dataGridView_StationLink";
            this.dataGridView_StationLink.ReadOnly = true;
            this.dataGridView_StationLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_StationLink.Size = new System.Drawing.Size(541, 245);
            this.dataGridView_StationLink.TabIndex = 7;
            this.dataGridView_StationLink.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StationLink_CellContentClick);
            // 
            // btn_update_stationlink
            // 
            this.btn_update_stationlink.Location = new System.Drawing.Point(181, 89);
            this.btn_update_stationlink.Name = "btn_update_stationlink";
            this.btn_update_stationlink.Size = new System.Drawing.Size(75, 23);
            this.btn_update_stationlink.TabIndex = 6;
            this.btn_update_stationlink.Text = "Update";
            this.btn_update_stationlink.UseVisualStyleBackColor = true;
            this.btn_update_stationlink.Click += new System.EventHandler(this.btn_update_stationlink_Click);
            // 
            // lbl_toStation
            // 
            this.lbl_toStation.AutoSize = true;
            this.lbl_toStation.Location = new System.Drawing.Point(315, 51);
            this.lbl_toStation.Name = "lbl_toStation";
            this.lbl_toStation.Size = new System.Drawing.Size(0, 13);
            this.lbl_toStation.TabIndex = 5;
            // 
            // lbl_fromStation
            // 
            this.lbl_fromStation.AutoSize = true;
            this.lbl_fromStation.Location = new System.Drawing.Point(315, 23);
            this.lbl_fromStation.Name = "lbl_fromStation";
            this.lbl_fromStation.Size = new System.Drawing.Size(0, 13);
            this.lbl_fromStation.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fare";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_stationName);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 385);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update Station Information";
            // 
            // lbl_stationName
            // 
            this.lbl_stationName.AutoSize = true;
            this.lbl_stationName.Location = new System.Drawing.Point(122, 34);
            this.lbl_stationName.Name = "lbl_stationName";
            this.lbl_stationName.Size = new System.Drawing.Size(0, 13);
            this.lbl_stationName.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(21, 205);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 181);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(202, 176);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(122, 71);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(267, 96);
            this.txt_description.TabIndex = 3;
            this.txt_description.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Description";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Location = new System.Drawing.Point(33, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(71, 13);
            this.txt_name.TabIndex = 0;
            this.txt_name.Text = "Station Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_page);
            this.panel3.Controls.Add(this.btn_preview);
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 385);
            this.panel3.TabIndex = 11;
            // 
            // lbl_page
            // 
            this.lbl_page.AutoSize = true;
            this.lbl_page.Location = new System.Drawing.Point(85, 28);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(10, 13);
            this.lbl_page.TabIndex = 4;
            this.lbl_page.Text = ".";
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(0, 20);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 3;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(491, 21);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "All Search History";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(576, 329);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(13, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 385);
            this.panel4.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StationLink)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datePicker_duration;
        private System.Windows.Forms.TextBox textBox_fare;
        private System.Windows.Forms.DataGridView dataGridView_StationLink;
        private System.Windows.Forms.Button btn_update_stationlink;
        private System.Windows.Forms.Label lbl_toStation;
        private System.Windows.Forms.Label lbl_fromStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stationName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_page;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
    }
}