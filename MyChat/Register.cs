﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyChat
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string registerUser = txtRegisterUser.Text;
            string registerEmail = txtRegisterEmail.Text;
            string registerPassword = txtRegisterPassword.Text;
            string registerRepeatPassword = txtRegisterRepeatPassword.Text;

            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(registerUser) ||
                string.IsNullOrEmpty(registerEmail) ||
                string.IsNullOrEmpty(registerPassword) ||
                string.IsNullOrEmpty(registerRepeatPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de e-mail
            if (!IsValidEmail(registerEmail))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se as senhas coincidem
            if (registerPassword != registerRepeatPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Chamar a classe para registrar o usuário
                RegisterUser regisUser = new RegisterUser(registerUser, registerEmail, registerPassword, registerRepeatPassword);

                // Limpar os campos
                txtRegisterUser.Clear();
                txtRegisterEmail.Clear();
                txtRegisterPassword.Clear();
                txtRegisterRepeatPassword.Clear();
                Close();
            }
            catch (Exception ex)
            {
                // Mostrar erro caso algo dê errado
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validação de e-mail usando regex
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}