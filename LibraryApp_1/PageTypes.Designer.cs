
namespace LibraryApp_1
{
    partial class PageTypes
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
            this.lblerror = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttypename = new System.Windows.Forms.TextBox();
            this.pctrsearch = new System.Windows.Forms.PictureBox();
            this.pctrrefresh = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.tablist = new System.Windows.Forms.TabPage();
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabtypesadd = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).BeginInit();
            this.tablist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabtypesadd.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(208, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tür Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÜR EKLE";
            // 
            // txttypename
            // 
            this.txttypename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txttypename.Location = new System.Drawing.Point(198, 209);
            this.txttypename.Name = "txttypename";
            this.txttypename.Size = new System.Drawing.Size(519, 30);
            this.txttypename.TabIndex = 6;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablist);
            this.tabControl1.Controls.Add(this.tabtypesadd);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(355, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 644);
            this.tabControl1.TabIndex = 2;
            // 
            // tabtypesadd
            // 
            this.tabtypesadd.BackColor = System.Drawing.Color.White;
            this.tabtypesadd.Controls.Add(this.lblerror);
            this.tabtypesadd.Controls.Add(this.btnsave);
            this.tabtypesadd.Controls.Add(this.label2);
            this.tabtypesadd.Controls.Add(this.label1);
            this.tabtypesadd.Controls.Add(this.txttypename);
            this.tabtypesadd.Location = new System.Drawing.Point(4, 39);
            this.tabtypesadd.Name = "tabtypesadd";
            this.tabtypesadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabtypesadd.Size = new System.Drawing.Size(959, 601);
            this.tabtypesadd.TabIndex = 1;
            this.tabtypesadd.Text = "Tür Ekle";
            // 
            // PageTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 644);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageTypes";
            this.Text = "PageTypes";
            this.Load += new System.EventHandler(this.PageTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrrefresh)).EndInit();
            this.tablist.ResumeLayout(false);
            this.tablist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabtypesadd.ResumeLayout(false);
            this.tabtypesadd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttypename;
        private System.Windows.Forms.PictureBox pctrsearch;
        private System.Windows.Forms.PictureBox pctrrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TabPage tablist;
        public System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabtypesadd;
    }
}