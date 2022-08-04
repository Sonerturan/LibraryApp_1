
namespace LibraryApp_1
{
    partial class PageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageBooks));
            this.label10 = new System.Windows.Forms.Label();
            this.dtyearofpublication = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpagenumber = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtwriter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.pctrsearch = new System.Windows.Forms.PictureBox();
            this.pctrrefresh = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.tablist = new System.Windows.Forms.TabPage();
            this.txtpublishersearch = new System.Windows.Forms.TextBox();
            this.pctrpublishersearch = new System.Windows.Forms.PictureBox();
            this.txttypesearch = new System.Windows.Forms.TextBox();
            this.pctrtypesearch = new System.Windows.Forms.PictureBox();
            this.txtwritersearch = new System.Windows.Forms.TextBox();
            this.pctrwritersearch = new System.Windows.Forms.PictureBox();
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabbooksadd = new System.Windows.Forms.TabPage();
            this.dgvtype = new System.Windows.Forms.DataGridView();
            this.dgvpublisher = new System.Windows.Forms.DataGridView();
            this.dgvwriter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).BeginInit();
            this.tablist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrpublishersearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrtypesearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrwritersearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabbooksadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwriter)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(209, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Basım Yılı";
            // 
            // dtyearofpublication
            // 
            this.dtyearofpublication.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtyearofpublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtyearofpublication.Location = new System.Drawing.Point(198, 336);
            this.dtyearofpublication.Name = "dtyearofpublication";
            this.dtyearofpublication.Size = new System.Drawing.Size(206, 34);
            this.dtyearofpublication.TabIndex = 28;
            this.dtyearofpublication.Value = new System.DateTime(2002, 1, 11, 15, 9, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(522, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Yayınevi";
            // 
            // txtpublisher
            // 
            this.txtpublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtpublisher.Location = new System.Drawing.Point(511, 336);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(205, 30);
            this.txtpublisher.TabIndex = 27;
            this.txtpublisher.Click += new System.EventHandler(this.txtpublisher_Click);
            this.txtpublisher.TextChanged += new System.EventHandler(this.txtpublisher_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(522, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tür";
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txttype.Location = new System.Drawing.Point(511, 244);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(205, 30);
            this.txttype.TabIndex = 23;
            this.txttype.Click += new System.EventHandler(this.txttype_Click);
            this.txttype.TextChanged += new System.EventHandler(this.txttype_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(208, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtpagenumber.Location = new System.Drawing.Point(198, 244);
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Size = new System.Drawing.Size(205, 30);
            this.txtpagenumber.TabIndex = 21;
            this.txtpagenumber.Click += new System.EventHandler(this.txtpagenumber_Click);
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
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yazar Ad Soyad";
            // 
            // txtwriter
            // 
            this.txtwriter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtwriter.Location = new System.Drawing.Point(511, 152);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(205, 30);
            this.txtwriter.TabIndex = 8;
            this.txtwriter.Click += new System.EventHandler(this.txtwriter_Click);
            this.txtwriter.TextChanged += new System.EventHandler(this.txtwriter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(208, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "KİTAP EKLE";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtbookname.Location = new System.Drawing.Point(198, 152);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(205, 30);
            this.txtbookname.TabIndex = 6;
            this.txtbookname.Click += new System.EventHandler(this.txtbookname_Click);
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
            // tablist
            // 
            this.tablist.BackColor = System.Drawing.Color.White;
            this.tablist.Controls.Add(this.txtpublishersearch);
            this.tablist.Controls.Add(this.pctrpublishersearch);
            this.tablist.Controls.Add(this.txttypesearch);
            this.tablist.Controls.Add(this.pctrtypesearch);
            this.tablist.Controls.Add(this.txtwritersearch);
            this.tablist.Controls.Add(this.pctrwritersearch);
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
            // txtpublishersearch
            // 
            this.txtpublishersearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpublishersearch.Location = new System.Drawing.Point(818, 2);
            this.txtpublishersearch.Name = "txtpublishersearch";
            this.txtpublishersearch.Size = new System.Drawing.Size(106, 24);
            this.txtpublishersearch.TabIndex = 15;
            this.txtpublishersearch.Visible = false;
            this.txtpublishersearch.TextChanged += new System.EventHandler(this.txtpublishersearch_TextChanged);
            // 
            // pctrpublishersearch
            // 
            this.pctrpublishersearch.Image = ((System.Drawing.Image)(resources.GetObject("pctrpublishersearch.Image")));
            this.pctrpublishersearch.Location = new System.Drawing.Point(926, 3);
            this.pctrpublishersearch.Name = "pctrpublishersearch";
            this.pctrpublishersearch.Size = new System.Drawing.Size(26, 22);
            this.pctrpublishersearch.TabIndex = 14;
            this.pctrpublishersearch.TabStop = false;
            this.pctrpublishersearch.Click += new System.EventHandler(this.pctrpublishersearch_Click);
            // 
            // txttypesearch
            // 
            this.txttypesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttypesearch.Location = new System.Drawing.Point(682, 3);
            this.txttypesearch.Name = "txttypesearch";
            this.txttypesearch.Size = new System.Drawing.Size(106, 24);
            this.txttypesearch.TabIndex = 13;
            this.txttypesearch.Visible = false;
            this.txttypesearch.TextChanged += new System.EventHandler(this.txtttypesearch_TextChanged);
            // 
            // pctrtypesearch
            // 
            this.pctrtypesearch.Image = ((System.Drawing.Image)(resources.GetObject("pctrtypesearch.Image")));
            this.pctrtypesearch.Location = new System.Drawing.Point(790, 4);
            this.pctrtypesearch.Name = "pctrtypesearch";
            this.pctrtypesearch.Size = new System.Drawing.Size(26, 22);
            this.pctrtypesearch.TabIndex = 12;
            this.pctrtypesearch.TabStop = false;
            this.pctrtypesearch.Click += new System.EventHandler(this.pctrtypesearch_Click);
            // 
            // txtwritersearch
            // 
            this.txtwritersearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtwritersearch.Location = new System.Drawing.Point(544, 3);
            this.txtwritersearch.Name = "txtwritersearch";
            this.txtwritersearch.Size = new System.Drawing.Size(106, 24);
            this.txtwritersearch.TabIndex = 11;
            this.txtwritersearch.Visible = false;
            this.txtwritersearch.TextChanged += new System.EventHandler(this.txtwritersearch_TextChanged);
            // 
            // pctrwritersearch
            // 
            this.pctrwritersearch.Image = ((System.Drawing.Image)(resources.GetObject("pctrwritersearch.Image")));
            this.pctrwritersearch.Location = new System.Drawing.Point(653, 4);
            this.pctrwritersearch.Name = "pctrwritersearch";
            this.pctrwritersearch.Size = new System.Drawing.Size(26, 22);
            this.pctrwritersearch.TabIndex = 10;
            this.pctrwritersearch.TabStop = false;
            this.pctrwritersearch.Click += new System.EventHandler(this.pctrwritersearch_Click);
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
            this.dgwlist.Location = new System.Drawing.Point(-1, 1);
            this.dgwlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwlist.Name = "dgwlist";
            this.dgwlist.RowHeadersVisible = false;
            this.dgwlist.RowHeadersWidth = 51;
            this.dgwlist.RowTemplate.Height = 24;
            this.dgwlist.Size = new System.Drawing.Size(954, 541);
            this.dgwlist.TabIndex = 0;
            this.dgwlist.Click += new System.EventHandler(this.dgwlist_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablist);
            this.tabControl1.Controls.Add(this.tabbooksadd);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(355, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 644);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabbooksadd
            // 
            this.tabbooksadd.BackColor = System.Drawing.Color.White;
            this.tabbooksadd.Controls.Add(this.dgvtype);
            this.tabbooksadd.Controls.Add(this.dgvpublisher);
            this.tabbooksadd.Controls.Add(this.dgvwriter);
            this.tabbooksadd.Controls.Add(this.label10);
            this.tabbooksadd.Controls.Add(this.dtyearofpublication);
            this.tabbooksadd.Controls.Add(this.label6);
            this.tabbooksadd.Controls.Add(this.txtpublisher);
            this.tabbooksadd.Controls.Add(this.label7);
            this.tabbooksadd.Controls.Add(this.txttype);
            this.tabbooksadd.Controls.Add(this.label8);
            this.tabbooksadd.Controls.Add(this.txtpagenumber);
            this.tabbooksadd.Controls.Add(this.lblerror);
            this.tabbooksadd.Controls.Add(this.btnsave);
            this.tabbooksadd.Controls.Add(this.label3);
            this.tabbooksadd.Controls.Add(this.txtwriter);
            this.tabbooksadd.Controls.Add(this.label2);
            this.tabbooksadd.Controls.Add(this.label1);
            this.tabbooksadd.Controls.Add(this.txtbookname);
            this.tabbooksadd.Location = new System.Drawing.Point(4, 39);
            this.tabbooksadd.Name = "tabbooksadd";
            this.tabbooksadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabbooksadd.Size = new System.Drawing.Size(959, 601);
            this.tabbooksadd.TabIndex = 1;
            this.tabbooksadd.Text = "Kitap Ekle";
            this.tabbooksadd.Click += new System.EventHandler(this.tabbooksadd_Click);
            // 
            // dgvtype
            // 
            this.dgvtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtype.BackgroundColor = System.Drawing.Color.White;
            this.dgvtype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtype.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtype.ColumnHeadersVisible = false;
            this.dgvtype.Location = new System.Drawing.Point(510, 280);
            this.dgvtype.MultiSelect = false;
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.RowHeadersVisible = false;
            this.dgvtype.RowHeadersWidth = 30;
            this.dgvtype.RowTemplate.Height = 24;
            this.dgvtype.Size = new System.Drawing.Size(206, 103);
            this.dgvtype.TabIndex = 32;
            this.dgvtype.Visible = false;
            this.dgvtype.Click += new System.EventHandler(this.dgvtype_Click);
            // 
            // dgvpublisher
            // 
            this.dgvpublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpublisher.BackgroundColor = System.Drawing.Color.White;
            this.dgvpublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpublisher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvpublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpublisher.ColumnHeadersVisible = false;
            this.dgvpublisher.Location = new System.Drawing.Point(511, 372);
            this.dgvpublisher.MultiSelect = false;
            this.dgvpublisher.Name = "dgvpublisher";
            this.dgvpublisher.RowHeadersVisible = false;
            this.dgvpublisher.RowHeadersWidth = 30;
            this.dgvpublisher.RowTemplate.Height = 24;
            this.dgvpublisher.Size = new System.Drawing.Size(206, 103);
            this.dgvpublisher.TabIndex = 31;
            this.dgvpublisher.Visible = false;
            this.dgvpublisher.Click += new System.EventHandler(this.dgvpublisher_Click);
            // 
            // dgvwriter
            // 
            this.dgvwriter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvwriter.BackgroundColor = System.Drawing.Color.White;
            this.dgvwriter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvwriter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvwriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwriter.ColumnHeadersVisible = false;
            this.dgvwriter.Location = new System.Drawing.Point(510, 188);
            this.dgvwriter.MultiSelect = false;
            this.dgvwriter.Name = "dgvwriter";
            this.dgvwriter.RowHeadersVisible = false;
            this.dgvwriter.RowHeadersWidth = 30;
            this.dgvwriter.RowTemplate.Height = 24;
            this.dgvwriter.Size = new System.Drawing.Size(206, 103);
            this.dgvwriter.TabIndex = 30;
            this.dgvwriter.Visible = false;
            this.dgvwriter.Click += new System.EventHandler(this.dgvwriter_Click);
            // 
            // PageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 644);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageBooks";
            this.Text = "PageBooks";
            this.Load += new System.EventHandler(this.PageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).EndInit();
            this.tablist.ResumeLayout(false);
            this.tablist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrpublishersearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrtypesearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrwritersearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabbooksadd.ResumeLayout(false);
            this.tabbooksadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwriter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtyearofpublication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpagenumber;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtwriter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.PictureBox pctrsearch;
        private System.Windows.Forms.PictureBox pctrrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TabPage tablist;
        public System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabbooksadd;
        private System.Windows.Forms.DataGridView dgvwriter;
        private System.Windows.Forms.DataGridView dgvpublisher;
        private System.Windows.Forms.DataGridView dgvtype;
        private System.Windows.Forms.TextBox txtwritersearch;
        private System.Windows.Forms.PictureBox pctrwritersearch;
        private System.Windows.Forms.TextBox txtpublishersearch;
        private System.Windows.Forms.PictureBox pctrpublishersearch;
        private System.Windows.Forms.TextBox txttypesearch;
        private System.Windows.Forms.PictureBox pctrtypesearch;
    }
}