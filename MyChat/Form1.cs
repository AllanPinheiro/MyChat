namespace MyChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void lblRecPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nada ainda!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailUser = txtLoginUser.Text;
            string passwordUser = txtLoginPassword.Text;

            // Verificar se os campos estão preenchidos
            if (string.IsNullOrEmpty(emailUser) || string.IsNullOrEmpty(passwordUser))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            // Validar login
            try
            {
                ValidarLogin validarLogin = new ValidarLogin(emailUser, passwordUser);
                txtLoginUser.Clear();
                txtLoginPassword.Clear();
            }
            catch (Exception ex)
            {
                // Mensagem em caso de erro no login
                MessageBox.Show($"Falha no login: {ex.Message}");
                
            }

        }
    }
}
