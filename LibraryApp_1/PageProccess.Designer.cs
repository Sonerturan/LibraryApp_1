
namespace LibraryApp_1
{
    partial class PageProccess
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablist = new System.Windows.Forms.TabPage();
            this.btnlateprocessing = new System.Windows.Forms.Button();
            this.pctrsearch = new System.Windows.Forms.PictureBox();
            this.btnupcomingprocess = new System.Windows.Forms.Button();
            this.pctrrefresh = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.tabproccesadd = new System.Windows.Forms.TabPage();
            this.lblerror = new System.Windows.Forms.Label();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.dgvbooks = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtissuedate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpurhasedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudent = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tablist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.tabproccesadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablist);
            this.tabControl1.Controls.Add(this.tabproccesadd);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(355, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 644);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tablist
            // 
            this.tablist.BackColor = System.Drawing.Color.White;
            this.tablist.Controls.Add(this.btnlateprocessing);
            this.tablist.Controls.Add(this.pctrsearch);
            this.tablist.Controls.Add(this.btnupcomingprocess);
            this.tablist.Controls.Add(this.pctrrefresh);
            this.tablist.Controls.Add(this.btnsearch);
            this.tablist.Controls.Add(this.txtsearch);
            this.tablist.Controls.Add(this.btndelete);
            this.tablist.Controls.Add(this.btnupdate);
            this.tablist.Controls.Add(this.dgwlist);
            this.tablist.Location = new System.Drawing.Point(4, 39);
            this.tablist.Name = "tablist";
            this.tablist.Padding = new System.Windows.Forms.Padding(3);
            this.tablist.Size = new System.Drawing.Size(959, 601);
            this.tablist.TabIndex = 0;
            this.tablist.Text = "Listele";
            // 
            // btnlateprocessing
            // 
            this.btnlateprocessing.BackColor = System.Drawing.Color.Brown;
            this.btnlateprocessing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlateprocessing.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnlateprocessing.FlatAppearance.BorderSize = 2;
            this.btnlateprocessing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnlateprocessing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnlateprocessing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlateprocessing.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.btnlateprocessing.ForeColor = System.Drawing.Color.White;
            this.btnlateprocessing.Location = new System.Drawing.Point(554, 547);
            this.btnlateprocessing.Name = "btnlateprocessing";
            this.btnlateprocessing.Size = new System.Drawing.Size(199, 39);
            this.btnlateprocessing.TabIndex = 10;
            this.btnlateprocessing.Text = "Geciken İşlemler";
            this.btnlateprocessing.UseVisualStyleBackColor = false;
            this.btnlateprocessing.Click += new System.EventHandler(this.btnlateprocessing_Click);
            // 
            // pctrsearch
            // 
            this.pctrsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrsearch.Image = global::LibraryApp_1.Properties.Resources.refreshicon;
            this.pctrsearch.Location = new System.Drawing.Point(554, 547);
            this.pctrsearch.Name = "pctrsearch";
            this.pctrsearch.Size = new System.Drawing.Size(33, 39);
            this.pctrsearch.TabIndex = 9;
            this.pctrsearch.TabStop = false;
            this.pctrsearch.Click += new System.EventHandler(this.pctrsearch_Click);
            // 
            // btnupcomingprocess
            // 
            this.btnupcomingprocess.BackColor = System.Drawing.Color.RosyBrown;
            this.btnupcomingprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupcomingprocess.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnupcomingprocess.FlatAppearance.BorderSize = 2;
            this.btnupcomingprocess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnupcomingprocess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnupcomingprocess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupcomingprocess.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.btnupcomingprocess.ForeColor = System.Drawing.Color.White;
            this.btnupcomingprocess.Location = new System.Drawing.Point(754, 547);
            this.btnupcomingprocess.Name = "btnupcomingprocess";
            this.btnupcomingprocess.Size = new System.Drawing.Size(199, 39);
            this.btnupcomingprocess.TabIndex = 8;
            this.btnupcomingprocess.Text = "Yaklaşan İşlemler";
            this.btnupcomingprocess.UseVisualStyleBackColor = false;
            this.btnupcomingprocess.Click += new System.EventHandler(this.btnupcomingprocess_Click);
            // 
            // pctrrefresh
            // 
            this.pctrrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrrefresh.Image = global::LibraryApp_1.Properties.Resources.refreshicon;
            this.pctrrefresh.Location = new System.Drawing.Point(2, 547);
            this.pctrrefresh.Name = "pctrrefresh";
            this.pctrrefresh.Size = new System.Drawing.Size(33, 39);
            this.pctrrefresh.TabIndex = 6;
            this.pctrrefresh.TabStop = false;
            this.pctrrefresh.Click += new System.EventHandler(this.pctrrefresh_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnsearch.FlatAppearance.BorderSize = 2;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(382, 547);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(171, 39);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Ara";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtsearch.Location = new System.Drawing.Point(382, 547);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(171, 35);
            this.txtsearch.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(209, 547);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(171, 39);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(37, 547);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(171, 39);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dgwlist
            // 
            this.dgwlist.AllowUserToOrderColumns = true;
            this.dgwlist.AllowUserToResizeColumns = false;
            this.dgwlist.AllowUserToResizeRows = false;
            this.dgwlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwlist.BackgroundColor = System.Drawing.Color.White;
            this.dgwlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwlist.Location = new System.Drawing.Point(0, 1);
            this.dgwlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwlist.Name = "dgwlist";
            this.dgwlist.RowHeadersVisible = false;
            this.dgwlist.RowHeadersWidth = 51;
            this.dgwlist.RowTemplate.Height = 24;
            this.dgwlist.Size = new System.Drawing.Size(954, 541);
            this.dgwlist.TabIndex = 0;
            this.dgwlist.Click += new System.EventHandler(this.dgwlist_Click);
            // 
            // tabproccesadd
            // 
            this.tabproccesadd.BackColor = System.Drawing.Color.White;
            this.tabproccesadd.Controls.Add(this.lblerror);
            this.tabproccesadd.Controls.Add(this.dgvstudent);
            this.tabproccesadd.Controls.Add(this.dgvbooks);
            this.tabproccesadd.Controls.Add(this.btnsave);
            this.tabproccesadd.Controls.Add(this.label6);
            this.tabproccesadd.Controls.Add(this.txtnote);
            this.tabproccesadd.Controls.Add(this.label5);
            this.tabproccesadd.Controls.Add(this.dtissuedate);
            this.tabproccesadd.Controls.Add(this.label4);
            this.tabproccesadd.Controls.Add(this.dtpurhasedate);
            this.tabproccesadd.Controls.Add(this.label3);
            this.tabproccesadd.Controls.Add(this.txtbook);
            this.tabproccesadd.Controls.Add(this.label2);
            this.tabproccesadd.Controls.Add(this.label1);
            this.tabproccesadd.Controls.Add(this.txtstudent);
            this.tabproccesadd.Location = new System.Drawing.Point(4, 39);
            this.tabproccesadd.Name = "tabproccesadd";
            this.tabproccesadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabproccesadd.Size = new System.Drawing.Size(959, 601);
            this.tabproccesadd.TabIndex = 1;
            this.tabproccesadd.Text = "İşlem Ekle";
            this.tabproccesadd.Click += new System.EventHandler(this.tabproccesadd_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(381, 428);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 18);
            this.lblerror.TabIndex = 19;
            // 
            // dgvstudent
            // 
            this.dgvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvstudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvstudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.ColumnHeadersVisible = false;
            this.dgvstudent.Location = new System.Drawing.Point(197, 188);
            this.dgvstudent.MultiSelect = false;
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowHeadersVisible = false;
            this.dgvstudent.RowHeadersWidth = 30;
            this.dgvstudent.RowTemplate.Height = 24;
            this.dgvstudent.Size = new System.Drawing.Size(206, 103);
            this.dgvstudent.TabIndex = 18;
            this.dgvstudent.Visible = false;
            this.dgvstudent.Click += new System.EventHandler(this.dgvstudent_Click);
            // 
            // dgvbooks
            // 
            this.dgvbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvbooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvbooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbooks.ColumnHeadersVisible = false;
            this.dgvbooks.Location = new System.Drawing.Point(511, 188);
            this.dgvbooks.MultiSelect = false;
            this.dgvbooks.Name = "dgvbooks";
            this.dgvbooks.RowHeadersVisible = false;
            this.dgvbooks.RowHeadersWidth = 30;
            this.dgvbooks.RowTemplate.Height = 24;
            this.dgvbooks.Size = new System.Drawing.Size(206, 103);
            this.dgvbooks.TabIndex = 17;
            this.dgvbooks.Visible = false;
            this.dgvbooks.Click += new System.EventHandler(this.dgvbooks_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsave.Location = new System.Drawing.Point(198, 467);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(519, 53);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(208, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Not";
            // 
            // txtnote
            // 
            this.txtnote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtnote.Location = new System.Drawing.Point(198, 343);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(518, 30);
            this.txtnote.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(526, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Teslim Tarihi";
            // 
            // dtissuedate
            // 
            this.dtissuedate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtissuedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtissuedate.Location = new System.Drawing.Point(516, 237);
            this.dtissuedate.Name = "dtissuedate";
            this.dtissuedate.Size = new System.Drawing.Size(200, 34);
            this.dtissuedate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(208, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alış Tarihi";
            // 
            // dtpurhasedate
            // 
            this.dtpurhasedate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpurhasedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpurhasedate.Location = new System.Drawing.Point(198, 237);
            this.dtpurhasedate.Name = "dtpurhasedate";
            this.dtpurhasedate.Size = new System.Drawing.Size(200, 34);
            this.dtpurhasedate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(522, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Adı";
            // 
            // txtbook
            // 
            this.txtbook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtbook.Location = new System.Drawing.Point(511, 152);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(205, 30);
            this.txtbook.TabIndex = 8;
            this.txtbook.TextChanged += new System.EventHandler(this.txtbook_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(208, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(354, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "İŞLEM EKLE";
            // 
            // txtstudent
            // 
            this.txtstudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtstudent.Location = new System.Drawing.Point(198, 152);
            this.txtstudent.Name = "txtstudent";
            this.txtstudent.Size = new System.Drawing.Size(205, 30);
            this.txtstudent.TabIndex = 6;
            this.txtstudent.TextChanged += new System.EventHandler(this.txtstudent_TextChanged);
            // 
            // PageProccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 644);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageProccess";
            this.Text = "PageProccescs";
            this.Load += new System.EventHandler(this.PageProccess_Load);
            this.tabControl1.ResumeLayout(false);
            this.tablist.ResumeLayout(false);
            this.tablist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.tabproccesadd.ResumeLayout(false);
            this.tabproccesadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablist;
        private System.Windows.Forms.TabPage tabproccesadd;
        public System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.PictureBox pctrrefresh;
        private System.Windows.Forms.Button btnupcomingprocess;
        private System.Windows.Forms.Button btnlateprocessing;
        private System.Windows.Forms.PictureBox pctrsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtissuedate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpurhasedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.TextBox txtstudent;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.DataGridView dgvbooks;
        private System.Windows.Forms.Label lblerror;
    }
}