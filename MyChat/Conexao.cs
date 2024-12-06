using Microsoft.Data.SqlClient;
using System;

namespace MyChat
{
    internal class Conexao
    {
        private readonly SqlConnection con;

        public Conexao()
        {
            // String de conexão 
            con = new SqlConnection("Data Source=DESKTOP-N6OGC4V\\SQLEXPRESS;Initial Catalog=MyChat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public SqlConnection Conectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao abrir a conexão: {ex.Message}");
            }
        }

        public void Desconectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao fechar a conexão: {ex.Message}");
            }
        }
    }
}
