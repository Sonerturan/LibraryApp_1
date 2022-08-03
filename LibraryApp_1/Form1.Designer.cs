
namespace LibraryApp_1
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblcontent = new System.Windows.Forms.Label();
            this.btnmore = new System.Windows.Forms.Button();
            this.lbtransformation = new System.Windows.Forms.Label();
            this.panelright = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelright.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paneltop.Controls.Add(this.btnminimize);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(967, 56);
            this.paneltop.TabIndex = 4;
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
            this.btnminimize.TabIndex = 6;
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
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.White;
            this.panelleft.Controls.Add(this.label1);
            this.panelleft.Controls.Add(this.pictureBox1);
            this.panelleft.Controls.Add(this.pictureBox2);
            this.panelleft.Controls.Add(this.lblcontent);
            this.panelleft.Controls.Add(this.btnmore);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 56);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(441, 711);
            this.panelleft.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Duyurular";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryApp_1.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryApp_1.Properties.Resources.login2;
            this.pictureBox2.Location = new System.Drawing.Point(30, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 240);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblcontent
            // 
            this.lblcontent.AutoSize = true;
            this.lblcontent.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblcontent.Location = new System.Drawing.Point(37, 408);
            this.lblcontent.Name = "lblcontent";
            this.lblcontent.Size = new System.Drawing.Size(382, 76);
            this.lblcontent.TabIndex = 1;
            this.lblcontent.Text = "Lorem Ipsum is simply dummy text of the printing and \r\ntypesetting industry. Lore" +
    "m Ipsum has been the\r\n industry\'s standard dummy text ever since the 1500s,\r\n wh" +
    "en an unknown...\r\n";
            // 
            // btnmore
            // 
            this.btnmore.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnmore.FlatAppearance.BorderSize = 2;
            this.btnmore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnmore.Location = new System.Drawing.Point(134, 508);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(112, 53);
            this.btnmore.TabIndex = 0;
            this.btnmore.Text = "Daha Fazla";
            this.btnmore.UseVisualStyleBackColor = true;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // lbtransformation
            // 
            this.lbtransformation.AutoSize = true;
            this.lbtransformation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbtransformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbtransformation.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Underline);
            this.lbtransformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbtransformation.Location = new System.Drawing.Point(154, 428);
            this.lbtransformation.Name = "lbtransformation";
            this.lbtransformation.Size = new System.Drawing.Size(225, 19);
            this.lbtransformation.TabIndex = 8;
            this.lbtransformation.Text = "Hesabın Yok mu ? Hemen Oluştur...\r\n";
            this.lbtransformation.Click += new System.EventHandler(this.lbtransformation_Click);
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.White;
            this.panelright.Controls.Add(this.btnlogin);
            this.panelright.Controls.Add(this.lbtransformation);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright.Location = new System.Drawing.Point(441, 56);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(526, 711);
            this.panelright.TabIndex = 9;
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnlogin.FlatAppearance.BorderSize = 2;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogin.Location = new System.Drawing.Point(167, 324);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(221, 53);
            this.btnlogin.TabIndex = 13;
            this.btnlogin.Text = "Giriş Yap";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 767);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.btnlogin_Click);
            this.paneltop.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Label lblcontent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbtransformation;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
    }
}

