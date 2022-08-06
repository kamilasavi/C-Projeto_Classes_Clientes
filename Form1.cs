namespace Classes_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente novoCliente = new Cliente();

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                novoCliente.setNome(txbNome.Text);
                novoCliente.setEndereco(txbEndereco.Text);
                novoCliente.setContato(txbContato.Text);
                novoCliente.setLimiteCredito(double.Parse(txbLimiteCredito.Text));
                novoCliente.setNumeroCartao(double.Parse(txbNumCartao.Text));
                novoCliente.setDataNasc(dateTimePicker1.Value);
                
                MessageBox.Show("Cliente Cadastrado com Sucesso", "Aviso");
                
                novoCliente.verificaLimite();

                MessageBox.Show("Sua situação atual é: " + novoCliente.getStatus(), "Aviso");

                lblNome.Text = (novoCliente.getNome());
                lblEndereco.Text = (novoCliente.getEndereco());
                lblContato.Text = (novoCliente.getContato());
                lblLimCredito.Text = (novoCliente.getLimiteCredito()).ToString();
                lblNumCartao.Text = (novoCliente.getNumeroCartao()).ToString();
                lblDtNasc.Text = (novoCliente.getDataNasc()).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão", "Falha no Cadastro");
            }

        }
    }
}