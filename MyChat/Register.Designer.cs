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
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRegisterUser
            // 
            txtRegisterUser.BorderStyle = BorderStyle.None;
            txtRegisterUser.Font = new Font("Segoe UI", 20.25F);
            txtRegisterUser.Location = new Point(9, 270);
            txtRegisterUser.Multiline = true;
            txtRegisterUser.Name = "txtRegisterUser";
            txtRegisterUser.Size = new Size(530, 46);
            txtRegisterUser.TabIndex = 0;
            txtRegisterUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.BorderStyle = BorderStyle.None;
            txtRegisterEmail.Font = new Font("Segoe UI", 20.25F);
            txtRegisterEmail.Location = new Point(9, 347);
            txtRegisterEmail.Multiline = true;
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(530, 46);
            txtRegisterEmail.TabIndex = 1;
            txtRegisterEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BorderStyle = BorderStyle.None;
            txtRegisterPassword.Font = new Font("Segoe UI", 20.25F);
            txtRegisterPassword.Location = new Point(9, 424);
            txtRegisterPassword.Multiline = true;
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(530, 46);
            txtRegisterPassword.TabIndex = 2;
            txtRegisterPassword.TextAlign = HorizontalAlignment.Center;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterRepeatPassword
            // 
            txtRegisterRepeatPassword.BorderStyle = BorderStyle.None;
            txtRegisterRepeatPassword.Font = new Font("Segoe UI", 20.25F);
            txtRegisterRepeatPassword.Location = new Point(9, 501);
            txtRegisterRepeatPassword.Multiline = true;
            txtRegisterRepeatPassword.Name = "txtRegisterRepeatPassword";
            txtRegisterRepeatPassword.Size = new Size(530, 46);
            txtRegisterRepeatPassword.TabIndex = 3;
            txtRegisterRepeatPassword.TextAlign = HorizontalAlignment.Center;
            txtRegisterRepeatPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.GradientActiveCaption;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(9, 553);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(530, 46);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(533, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(148, 137);
            label7.Name = "label7";
            label7.Size = new Size(270, 86);
            label7.TabIndex = 13;
            label7.Text = "MyChat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 14;
            label1.Text = "Nome de usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 319);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 396);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 16;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(12, 473);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 17;
            label4.Text = "Repetir senha";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(554, 614);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtRegisterRepeatPassword);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterEmail);
            Controls.Add(txtRegisterUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyChat - Cadastre-se";
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
        private PictureBox pictureBox1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}