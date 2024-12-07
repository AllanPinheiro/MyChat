namespace MyChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            txtLoginUser = new TextBox();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            lblRecPassword = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtLoginUser
            // 
            txtLoginUser.BorderStyle = BorderStyle.None;
            txtLoginUser.Font = new Font("Segoe UI", 18F);
            txtLoginUser.Location = new Point(52, 266);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(450, 32);
            txtLoginUser.TabIndex = 1;
            txtLoginUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BorderStyle = BorderStyle.None;
            txtLoginPassword.Font = new Font("Segoe UI", 18F);
            txtLoginPassword.Location = new Point(52, 343);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(450, 32);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.TextAlign = HorizontalAlignment.Center;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.WindowText;
            btnLogin.Location = new Point(52, 395);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(450, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 595);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "MyChat";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.WindowText;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = SystemColors.WindowText;
            linkLabel1.Location = new Point(434, 444);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastra-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 136);
            label4.Name = "label4";
            label4.Size = new Size(270, 86);
            label4.TabIndex = 8;
            label4.Text = "MyChat";
            // 
            // lblRecPassword
            // 
            lblRecPassword.ActiveLinkColor = SystemColors.WindowText;
            lblRecPassword.AutoSize = true;
            lblRecPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRecPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lblRecPassword.LinkColor = SystemColors.WindowText;
            lblRecPassword.Location = new Point(52, 444);
            lblRecPassword.Name = "lblRecPassword";
            lblRecPassword.Size = new Size(94, 15);
            lblRecPassword.TabIndex = 9;
            lblRecPassword.TabStop = true;
            lblRecPassword.Text = "Recuperar senha";
            lblRecPassword.LinkClicked += lblRecPassword_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(52, 238);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(52, 315);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 11;
            label2.Text = "Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(554, 614);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRecPassword);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyChat - Entrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtLoginUser;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel lblRecPassword;
        private Label label1;
        private Label label2;
    }
}
