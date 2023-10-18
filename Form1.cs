using Cliente_Socket2;

namespace ClientSocket
{
    public partial class Form1 : Form
    {
        Cliente cliente = new Cliente();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            cliente.EnviarMensagem(txtMensagem.Text);
            txtServidor.Text = ">> " + cliente.respostaServidor;

        }
    }
}