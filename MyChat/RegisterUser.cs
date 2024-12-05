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

        public RegisterUser(string UserName, string Email, string PasswordUser, string RepeatPasswordUser)
        {
            // Validação das senhas
            if (PasswordUser != RepeatPasswordUser)
            {
                throw new ArgumentException("Passwords do not match!");
            }

            Command.CommandText = "INSERT INTO RegisterUser (UserName, Email, PasswordUser, RepeatPasswordUser) VALUES (@UserName, @Email, @PasswordUser, @RepeatPasswordUser)";
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@PasswordUser", PasswordUser);
            Command.Parameters.AddWithValue("@RepeatPasswordUser", RepeatPasswordUser);

            try
            {
                Command.Connection = Conexao.Conectar();
                Command.ExecuteNonQuery();
                MessageBox.Show("User registered successfully!");
            }
            catch (SqlException e)
            {
                MessageBox.Show($"Error trying to connect to the database: {e.Message}");
            }
            finally
            {
                Conexao.Desconectar(); // Certifica-se de que a conexão será fechada
            }
        }
    }
}
