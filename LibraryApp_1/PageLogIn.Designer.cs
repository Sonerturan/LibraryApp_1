
namespace LibraryApp_1
{
    partial class PageLogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pctreyes = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctreyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(185, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ YAP";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtusername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtusername.Location = new System.Drawing.Point(190, 159);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.MaxLength = 15;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(177, 20);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "Username";
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtpassword.Location = new System.Drawing.Point(190, 239);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.MaxLength = 4;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(177, 20);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Text = "Password(numeric)";
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // pctreyes
            // 
            this.pctreyes.Image = global::LibraryApp_1.Properties.Resources.eyes_icon;
            this.pctreyes.Location = new System.Drawing.Point(383, 251);
            this.pctreyes.Name = "pctreyes";
            this.pctreyes.Size = new System.Drawing.Size(24, 15);
            this.pctreyes.TabIndex = 7;
            this.pctreyes.TabStop = false;
            this.pctreyes.Click += new System.EventHandler(this.pctreyes_Click);
            this.pctreyes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctreyes_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryApp_1.Properties.Resources.key_icon;
            this.pictureBox4.Location = new System.Drawing.Point(136, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 43);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryApp_1.Properties.Resources.hr;
            this.pictureBox3.Location = new System.Drawing.Point(190, 265);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 3);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryApp_1.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(136, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryApp_1.Properties.Resources.hr;
            this.pictureBox1.Location = new System.Drawing.Point(190, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 3);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PageLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 711);
            this.Controls.Add(this.pctreyes);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageLogIn";
            this.Text = "PageLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pctreyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pctreyes;
    }
}