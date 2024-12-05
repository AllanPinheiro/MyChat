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
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            lblRecPassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(12, 181);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(241, 23);
            txtLoginUser.TabIndex = 1;
            txtLoginUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(12, 225);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(241, 23);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.TextAlign = HorizontalAlignment.Center;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(12, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 431);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "MyChat";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(204, 280);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 134);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 8;
            label4.Text = "Login";
            // 
            // lblRecPassword
            // 
            lblRecPassword.AutoSize = true;
            lblRecPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            lblRecPassword.Location = new Point(12, 280);
            lblRecPassword.Name = "lblRecPassword";
            lblRecPassword.Size = new Size(102, 15);
            lblRecPassword.TabIndex = 9;
            lblRecPassword.TabStop = true;
            lblRecPassword.Text = "Recover Password";
            lblRecPassword.LinkClicked += lblRecPassword_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 450);
            Controls.Add(lblRecPassword);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyChat - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtLoginUser;
        private TextBox txtLoginPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel lblRecPassword;
    }
}
