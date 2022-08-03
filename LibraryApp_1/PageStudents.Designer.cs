
namespace LibraryApp_1
{
    partial class PageStudents
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
            this.pctrsearch = new System.Windows.Forms.PictureBox();
            this.pctrrefresh = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.tabstudentsadd = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxgender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstudentsurname = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tablist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.tabstudentsadd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablist);
            this.tabControl1.Controls.Add(this.tabstudentsadd);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(355, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // tablist
            // 
            this.tablist.BackColor = System.Drawing.Color.White;
            this.tablist.Controls.Add(this.pctrsearch);
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
            // pctrsearch
            // 
            this.pctrsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrsearch.Image = global::LibraryApp_1.Properties.Resources.refreshicon;
            this.pctrsearch.Location = new System.Drawing.Point(554, 547);
            this.pctrsearch.Name = "pctrsearch";
            this.pctrsearch.Size = new System.Drawing.Size(33, 39);
            this.pctrsearch.TabIndex = 9;
            this.pctrsearch.TabStop = false;
            this.pctrsearch.Visible = false;
            this.pctrsearch.Click += new System.EventHandler(this.pctrsearch_Click);
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
            // 
            // tabstudentsadd
            // 
            this.tabstudentsadd.BackColor = System.Drawing.Color.White;
            this.tabstudentsadd.Controls.Add(this.label11);
            this.tabstudentsadd.Controls.Add(this.cbxgender);
            this.tabstudentsadd.Controls.Add(this.label10);
            this.tabstudentsadd.Controls.Add(this.dtdateofbirth);
            this.tabstudentsadd.Controls.Add(this.label6);
            this.tabstudentsadd.Controls.Add(this.txtclass);
            this.tabstudentsadd.Controls.Add(this.label9);
            this.tabstudentsadd.Controls.Add(this.txtdepartment);
            this.tabstudentsadd.Controls.Add(this.label7);
            this.tabstudentsadd.Controls.Add(this.txtstudentphone);
            this.tabstudentsadd.Controls.Add(this.label8);
            this.tabstudentsadd.Controls.Add(this.txtstudentsurname);
            this.tabstudentsadd.Controls.Add(this.lblerror);
            this.tabstudentsadd.Controls.Add(this.btnsave);
            this.tabstudentsadd.Controls.Add(this.label3);
            this.tabstudentsadd.Controls.Add(this.txtstudentname);
            this.tabstudentsadd.Controls.Add(this.label2);
            this.tabstudentsadd.Controls.Add(this.label1);
            this.tabstudentsadd.Controls.Add(this.txtstudentid);
            this.tabstudentsadd.Location = new System.Drawing.Point(4, 39);
            this.tabstudentsadd.Name = "tabstudentsadd";
            this.tabstudentsadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabstudentsadd.Size = new System.Drawing.Size(959, 601);
            this.tabstudentsadd.TabIndex = 1;
            this.tabstudentsadd.Text = "Öğrenci Ekle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(522, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Cinsiyet";
            // 
            // cbxgender
            // 
            this.cbxgender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbxgender.FormattingEnabled = true;
            this.cbxgender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxgender.Location = new System.Drawing.Point(511, 423);
            this.cbxgender.Name = "cbxgender";
            this.cbxgender.Size = new System.Drawing.Size(205, 31);
            this.cbxgender.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(208, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Doğum Tarihi";
            // 
            // dtdateofbirth
            // 
            this.dtdateofbirth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdateofbirth.Location = new System.Drawing.Point(197, 420);
            this.dtdateofbirth.Name = "dtdateofbirth";
            this.dtdateofbirth.Size = new System.Drawing.Size(206, 34);
            this.dtdateofbirth.TabIndex = 28;
            this.dtdateofbirth.Value = new System.DateTime(2002, 1, 11, 15, 9, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(522, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sınıf";
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtclass.Location = new System.Drawing.Point(511, 336);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(205, 30);
            this.txtclass.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(208, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bölüm";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtdepartment.Location = new System.Drawing.Point(198, 336);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(205, 30);
            this.txtdepartment.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(522, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Öğrenci Tel";
            // 
            // txtstudentphone
            // 
            this.txtstudentphone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtstudentphone.Location = new System.Drawing.Point(511, 244);
            this.txtstudentphone.Name = "txtstudentphone";
            this.txtstudentphone.Size = new System.Drawing.Size(205, 30);
            this.txtstudentphone.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(208, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Öğrenci  Soyad";
            // 
            // txtstudentsurname
            // 
            this.txtstudentsurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtstudentsurname.Location = new System.Drawing.Point(198, 244);
            this.txtstudentsurname.Name = "txtstudentsurname";
            this.txtstudentsurname.Size = new System.Drawing.Size(205, 30);
            this.txtstudentsurname.TabIndex = 21;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(289, 479);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 18);
            this.lblerror.TabIndex = 19;
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
            this.btnsave.Location = new System.Drawing.Point(198, 511);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(519, 53);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(522, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci Ad";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtstudentname.Location = new System.Drawing.Point(511, 152);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(205, 30);
            this.txtstudentname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(208, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtstudentid.Location = new System.Drawing.Point(198, 152);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(205, 30);
            this.txtstudentid.TabIndex = 6;
            // 
            // PageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 644);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageStudents";
            this.Text = "PageStudents";
            this.Load += new System.EventHandler(this.PageStudents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tablist.ResumeLayout(false);
            this.tablist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.tabstudentsadd.ResumeLayout(false);
            this.tabstudentsadd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablist;
        private System.Windows.Forms.PictureBox pctrsearch;
        private System.Windows.Forms.PictureBox pctrrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.TabPage tabstudentsadd;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstudentphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstudentsurname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxgender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtdateofbirth;
    }
}