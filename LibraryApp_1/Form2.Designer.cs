
namespace LibraryApp_1
{
    partial class Form2
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnpublisher = new System.Windows.Forms.Button();
            this.btnwriters = new System.Windows.Forms.Button();
            this.btntypes = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.btnprocces = new System.Windows.Forms.Button();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.lbllogout = new System.Windows.Forms.LinkLabel();
            this.pctrlogout = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.pctrlogo = new System.Windows.Forms.PictureBox();
            this.pctrlogo2 = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogout)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paneltop.Controls.Add(this.btnminimize);
            this.paneltop.Controls.Add(this.btnexit);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(967, 56);
            this.paneltop.TabIndex = 1;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            this.paneltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseMove);
            this.paneltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseUp);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnminimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnminimize.Location = new System.Drawing.Point(890, 15);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(24, 31);
            this.btnminimize.TabIndex = 8;
            this.btnminimize.Text = "_";
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(929, 15);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(24, 31);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnbooks);
            this.panel2.Controls.Add(this.btnpublisher);
            this.panel2.Controls.Add(this.btnwriters);
            this.panel2.Controls.Add(this.btntypes);
            this.panel2.Controls.Add(this.btnstudents);
            this.panel2.Controls.Add(this.btnprocces);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 67);
            this.panel2.TabIndex = 2;
            // 
            // btnbooks
            // 
            this.btnbooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbooks.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnbooks.FlatAppearance.BorderSize = 2;
            this.btnbooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnbooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbooks.Location = new System.Drawing.Point(275, 4);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(133, 60);
            this.btnbooks.TabIndex = 6;
            this.btnbooks.Text = "Kitaplar";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnpublisher
            // 
            this.btnpublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpublisher.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnpublisher.FlatAppearance.BorderSize = 2;
            this.btnpublisher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnpublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnpublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpublisher.Location = new System.Drawing.Point(686, 4);
            this.btnpublisher.Name = "btnpublisher";
            this.btnpublisher.Size = new System.Drawing.Size(133, 60);
            this.btnpublisher.TabIndex = 5;
            this.btnpublisher.Text = "Yayınevleri";
            this.btnpublisher.UseVisualStyleBackColor = true;
            this.btnpublisher.Click += new System.EventHandler(this.btnpublisher_Click);
            // 
            // btnwriters
            // 
            this.btnwriters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnwriters.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnwriters.FlatAppearance.BorderSize = 2;
            this.btnwriters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnwriters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnwriters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwriters.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnwriters.Location = new System.Drawing.Point(412, 4);
            this.btnwriters.Name = "btnwriters";
            this.btnwriters.Size = new System.Drawing.Size(133, 60);
            this.btnwriters.TabIndex = 4;
            this.btnwriters.Text = "Yazarlar";
            this.btnwriters.UseVisualStyleBackColor = true;
            this.btnwriters.Click += new System.EventHandler(this.btnwriters_Click);
            // 
            // btntypes
            // 
            this.btntypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntypes.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btntypes.FlatAppearance.BorderSize = 2;
            this.btntypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btntypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btntypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntypes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntypes.Location = new System.Drawing.Point(549, 4);
            this.btntypes.Name = "btntypes";
            this.btntypes.Size = new System.Drawing.Size(133, 60);
            this.btntypes.TabIndex = 3;
            this.btntypes.Text = "Türler";
            this.btntypes.UseVisualStyleBackColor = true;
            this.btntypes.Click += new System.EventHandler(this.btntypes_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstudents.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnstudents.FlatAppearance.BorderSize = 2;
            this.btnstudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnstudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudents.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstudents.Location = new System.Drawing.Point(138, 4);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(133, 60);
            this.btnstudents.TabIndex = 1;
            this.btnstudents.Text = "Öğrenciler";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnprocces
            // 
            this.btnprocces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprocces.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnprocces.FlatAppearance.BorderSize = 2;
            this.btnprocces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnprocces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnprocces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocces.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprocces.Location = new System.Drawing.Point(1, 4);
            this.btnprocces.Name = "btnprocces";
            this.btnprocces.Size = new System.Drawing.Size(133, 60);
            this.btnprocces.TabIndex = 0;
            this.btnprocces.Text = "İşlemler";
            this.btnprocces.UseVisualStyleBackColor = true;
            this.btnprocces.Click += new System.EventHandler(this.btnprocces_Click);
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.White;
            this.panelcontent.Location = new System.Drawing.Point(0, 123);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(967, 644);
            this.panelcontent.TabIndex = 3;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.White;
            this.panelleft.Controls.Add(this.lbllogout);
            this.panelleft.Controls.Add(this.pctrlogout);
            this.panelleft.Location = new System.Drawing.Point(823, 56);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(144, 711);
            this.panelleft.TabIndex = 0;
            this.panelleft.Visible = false;
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllogout.Location = new System.Drawing.Point(48, 678);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(66, 17);
            this.lbllogout.TabIndex = 2;
            this.lbllogout.TabStop = true;
            this.lbllogout.Text = "Çıkış Yap";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // pctrlogout
            // 
            this.pctrlogout.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pctrlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrlogout.Image = global::LibraryApp_1.Properties.Resources.logouticon;
            this.pctrlogout.Location = new System.Drawing.Point(15, 673);
            this.pctrlogout.Name = "pctrlogout";
            this.pctrlogout.Size = new System.Drawing.Size(31, 28);
            this.pctrlogout.TabIndex = 0;
            this.pctrlogout.TabStop = false;
            this.pctrlogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblusername);
            this.panel5.Controls.Add(this.pctrlogo);
            this.panel5.Controls.Add(this.pctrlogo2);
            this.panel5.Location = new System.Drawing.Point(823, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 67);
            this.panel5.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.White;
            this.lblusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblusername.Location = new System.Drawing.Point(57, 33);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(81, 19);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            this.lblusername.Click += new System.EventHandler(this.pctrlogo_Click);
            // 
            // pctrlogo
            // 
            this.pctrlogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrlogo.Image = global::LibraryApp_1.Properties.Resources.bookicon1;
            this.pctrlogo.Location = new System.Drawing.Point(11, 1);
            this.pctrlogo.Name = "pctrlogo";
            this.pctrlogo.Size = new System.Drawing.Size(114, 67);
            this.pctrlogo.TabIndex = 0;
            this.pctrlogo.TabStop = false;
            this.pctrlogo.Click += new System.EventHandler(this.pctrlogo_Click);
            // 
            // pctrlogo2
            // 
            this.pctrlogo2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pctrlogo2.Image = global::LibraryApp_1.Properties.Resources.bookicon;
            this.pctrlogo2.Location = new System.Drawing.Point(11, 1);
            this.pctrlogo2.Name = "pctrlogo2";
            this.pctrlogo2.Size = new System.Drawing.Size(114, 67);
            this.pctrlogo2.TabIndex = 2;
            this.pctrlogo2.TabStop = false;
            this.pctrlogo2.Click += new System.EventHandler(this.pctrlogo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 767);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.paneltop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogout)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrlogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button btnpublisher;
        private System.Windows.Forms.Button btnwriters;
        private System.Windows.Forms.Button btntypes;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnprocces;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label lblusername;
        public System.Windows.Forms.Panel panelleft;
        public System.Windows.Forms.PictureBox pctrlogo;
        public System.Windows.Forms.PictureBox pctrlogo2;
        public System.Windows.Forms.PictureBox pctrlogout;
        public System.Windows.Forms.LinkLabel lbllogout;
    }
}