namespace MyChat
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtRegisterUser = new TextBox();
            txtRegisterEmail = new TextBox();
            txtRegisterPassword = new TextBox();
            txtRegisterRepeatPassword = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRegisterUser
            // 
            txtRegisterUser.Location = new Point(12, 187);
            txtRegisterUser.Name = "txtRegisterUser";
            txtRegisterUser.Size = new Size(246, 23);
            txtRegisterUser.TabIndex = 0;
            txtRegisterUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(12, 231);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(246, 23);
            txtRegisterEmail.TabIndex = 1;
            txtRegisterEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(12, 275);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(246, 23);
            txtRegisterPassword.TabIndex = 2;
            txtRegisterPassword.TextAlign = HorizontalAlignment.Center;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterRepeatPassword
            // 
            txtRegisterRepeatPassword.Location = new Point(12, 319);
            txtRegisterRepeatPassword.Name = "txtRegisterRepeatPassword";
            txtRegisterRepeatPassword.Size = new Size(246, 23);
            txtRegisterRepeatPassword.TabIndex = 3;
            txtRegisterRepeatPassword.TextAlign = HorizontalAlignment.Center;
            txtRegisterRepeatPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(12, 348);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(246, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 301);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 5;
            label1.Text = "Repeat password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 436);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "MyChat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 137);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 11;
            label6.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 455);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtRegisterRepeatPassword);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterEmail);
            Controls.Add(txtRegisterUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyChat - Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegisterUser;
        private TextBox txtRegisterEmail;
        private TextBox txtRegisterPassword;
        private TextBox txtRegisterRepeatPassword;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}