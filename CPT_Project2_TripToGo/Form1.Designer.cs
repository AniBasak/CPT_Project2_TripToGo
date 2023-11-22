namespace CPT_Project2_TripToGo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.b_show = new System.Windows.Forms.Button();
            this.b_filter = new System.Windows.Forms.Button();
            this.l_name = new System.Windows.Forms.Label();
            this.t_sname = new System.Windows.Forms.TextBox();
            this.l_cost = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.l_type = new System.Windows.Forms.Label();
            this.l_city = new System.Windows.Forms.Label();
            this.b_search = new System.Windows.Forms.Button();
            this.cbox_cost = new System.Windows.Forms.ComboBox();
            this.cbox_time = new System.Windows.Forms.ComboBox();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.cbox_city = new System.Windows.Forms.ComboBox();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.b_exit);
            this.panel1.Controls.Add(this.b_refresh);
            this.panel1.Controls.Add(this.b_show);
            this.panel1.Controls.Add(this.b_filter);
            this.panel1.Controls.Add(this.l_name);
            this.panel1.Controls.Add(this.t_sname);
            this.panel1.Controls.Add(this.l_cost);
            this.panel1.Controls.Add(this.l_time);
            this.panel1.Controls.Add(this.l_type);
            this.panel1.Controls.Add(this.l_city);
            this.panel1.Controls.Add(this.b_search);
            this.panel1.Controls.Add(this.cbox_cost);
            this.panel1.Controls.Add(this.cbox_time);
            this.panel1.Controls.Add(this.cbox_type);
            this.panel1.Controls.Add(this.cbox_city);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 139);
            this.panel1.TabIndex = 0;
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(541, 113);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(111, 23);
            this.b_exit.TabIndex = 7;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(10, 113);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(111, 23);
            this.b_refresh.TabIndex = 7;
            this.b_refresh.Text = "Refresh";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // b_show
            // 
            this.b_show.Location = new System.Drawing.Point(409, 113);
            this.b_show.Name = "b_show";
            this.b_show.Size = new System.Drawing.Size(111, 23);
            this.b_show.TabIndex = 6;
            this.b_show.Text = "Show";
            this.b_show.UseVisualStyleBackColor = true;
            this.b_show.Click += new System.EventHandler(this.b_show_Click);
            // 
            // b_filter
            // 
            this.b_filter.Location = new System.Drawing.Point(271, 113);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(111, 23);
            this.b_filter.TabIndex = 6;
            this.b_filter.Text = "Filter";
            this.b_filter.UseVisualStyleBackColor = true;
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(10, 57);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(86, 13);
            this.l_name.TabIndex = 5;
            this.l_name.Text = "Search by Name";
            // 
            // t_sname
            // 
            this.t_sname.Location = new System.Drawing.Point(10, 73);
            this.t_sname.Name = "t_sname";
            this.t_sname.Size = new System.Drawing.Size(642, 20);
            this.t_sname.TabIndex = 4;
            this.t_sname.TextChanged += new System.EventHandler(this.t_sname_TextChanged);
            // 
            // l_cost
            // 
            this.l_cost.AutoSize = true;
            this.l_cost.Location = new System.Drawing.Point(501, 17);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(28, 13);
            this.l_cost.TabIndex = 3;
            this.l_cost.Text = "Cost";
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Location = new System.Drawing.Point(337, 17);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(30, 13);
            this.l_time.TabIndex = 3;
            this.l_time.Text = "Time";
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.Location = new System.Drawing.Point(173, 17);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(31, 13);
            this.l_type.TabIndex = 3;
            this.l_type.Text = "Type";
            // 
            // l_city
            // 
            this.l_city.AutoSize = true;
            this.l_city.Location = new System.Drawing.Point(11, 17);
            this.l_city.Name = "l_city";
            this.l_city.Size = new System.Drawing.Size(24, 13);
            this.l_city.TabIndex = 3;
            this.l_city.Text = "City";
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(138, 113);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(111, 23);
            this.b_search.TabIndex = 2;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // cbox_cost
            // 
            this.cbox_cost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_cost.FormattingEnabled = true;
            this.cbox_cost.Location = new System.Drawing.Point(504, 36);
            this.cbox_cost.Name = "cbox_cost";
            this.cbox_cost.Size = new System.Drawing.Size(148, 21);
            this.cbox_cost.TabIndex = 1;
            // 
            // cbox_time
            // 
            this.cbox_time.FormattingEnabled = true;
            this.cbox_time.Location = new System.Drawing.Point(340, 36);
            this.cbox_time.Name = "cbox_time";
            this.cbox_time.Size = new System.Drawing.Size(148, 21);
            this.cbox_time.TabIndex = 1;
            // 
            // cbox_type
            // 
            this.cbox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_type.FormattingEnabled = true;
            this.cbox_type.Location = new System.Drawing.Point(176, 36);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(148, 21);
            this.cbox_type.TabIndex = 1;
            // 
            // cbox_city
            // 
            this.cbox_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_city.FormattingEnabled = true;
            this.cbox_city.Location = new System.Drawing.Point(10, 36);
            this.cbox_city.Name = "cbox_city";
            this.cbox_city.Size = new System.Drawing.Size(148, 21);
            this.cbox_city.TabIndex = 1;
            this.cbox_city.SelectedIndexChanged += new System.EventHandler(this.cbox_city_SelectedIndexChanged);
            // 
            // datagrid1
            // 
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(12, 160);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(642, 278);
            this.datagrid1.TabIndex = 1;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.ComboBox cbox_cost;
        private System.Windows.Forms.ComboBox cbox_time;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.Label l_cost;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Label l_type;
        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.TextBox t_sname;
        private System.Windows.Forms.Label l_city;
        private System.Windows.Forms.ComboBox cbox_city;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Button b_filter;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_show;
    }
}

