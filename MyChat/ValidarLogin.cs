using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MyChat
{
    internal class ValidarLogin
    {
        private readonly Conexao conexao = new Conexao();
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly string emailUser;
        private readonly string passwordUser;
        public ValidarLogin(string emailUser, string passwordUser)
        {
            this.emailUser = emailUser;
            this.passwordUser = passwordUser;
            cmd.CommandText = @"SELECT COUNT(1) FROM RegisterUser WHERE Email = @Email AND PasswordUser = @PasswordUser";
            cmd.Parameters.AddWithValue("@Email", emailUser);
            cmd.Parameters.AddWithValue("@PasswordUser", passwordUser);
            try
            {
                cmd.Connection = conexao.Conectar();
                // Usando ExecuteScalar para contar resultados
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                conexao.Desconectar();

                if (count > 0)
                {
                    MessageBox.Show("Login bem-sucedido!");
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválidos.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro de conexão do banco de dados: {ex.Message}");
            }
        }
    }
}
