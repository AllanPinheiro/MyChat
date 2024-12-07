using Microsoft.Data.SqlClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace MyChat
{
    internal class RegisterUser
    {
        private readonly Conexao Conexao = new Conexao();
        private readonly SqlCommand Command = new SqlCommand();

        public RegisterUser(string registerUser, string registerEmail, string registerPassword, string registerRepeatPassword)
        {
            // Validação das senhas
            if (registerPassword != registerRepeatPassword)
            {
                throw new ArgumentException("As senhas não correspondem!");
            }

            Command.CommandText = "INSERT INTO RegisterUser (UserName, Email, PasswordUser, RepeatPasswordUser) VALUES (@UserName, @Email, @PasswordUser, @RepeatPasswordUser)";
            Command.Parameters.AddWithValue("@UserName", registerUser);
            Command.Parameters.AddWithValue("@Email", registerEmail);
            Command.Parameters.AddWithValue("@PasswordUser", registerPassword);
            Command.Parameters.AddWithValue("@RepeatPasswordUser", registerRepeatPassword);

            try
            {
                Command.Connection = Conexao.Conectar();
                Command.ExecuteNonQuery();
                MessageBox.Show("Usuário registrado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao tentar se conectar ao banco de dados: {ex.Message}");
            }
            finally
            {
                Conexao.Desconectar(); // Certifica-se de que a conexão será fechada
            }
        }
    }
}
