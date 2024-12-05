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
            MessageBox.Show("Nothing yet!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailUser = txtLoginUser.Text;
            string passwordUser = txtLoginPassword.Text;

            // Verificar se os campos est�o preenchidos
            if (string.IsNullOrEmpty(emailUser) || string.IsNullOrEmpty(passwordUser))
            {
                MessageBox.Show("Fill in all fields");
                return;
            }

            // Validar login
            try
            {
                ValidarLogin validarLogin = new ValidarLogin(emailUser, passwordUser);
                txtLoginUser.Clear();
                txtLoginPassword.Clear();
                Close();
            }
            catch (Exception ex)
            {
                // Mensagem em caso de erro no login
                MessageBox.Show($"Login failed: {ex.Message}");
            }
        }
    }
}
