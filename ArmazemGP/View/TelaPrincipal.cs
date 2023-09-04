using ArmazemGP.Controller;
using ArmazemGP.View;

namespace ArmazemGP
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            new ScreenLogin().Close();
        }

        private void cadastrarFornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
            => new TelaCadastroFornecedor().ShowDialog();

        private void pDVVenderToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaVenda().ShowDialog();

        private void adicionarQtdEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroProduto().ShowDialog();

        private void adicionarQtdAoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroQtd().ShowDialog();

        private void cadastrarSenhaDeAutoriza��oToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroAutorizacao().ShowDialog();

        private void cadastrarColaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
            => new TelaCadastroColaborador().ShowDialog();

        private void relat�riosToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaTodosOsRelatorios().ShowDialog();

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroContasPGR().ShowDialog();

        private void pctSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deslogar e Sair do Sistema?", "Aten��o!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                new ScreenLogin().ShowDialog();
                this.Close();
            }
        }

        // M�TODO OBSERVER IMPLEMENTADO E FUNCIONANDO !
        private void btNNotifica_Click_1(object sender, EventArgs e)
        {
            var listaParaNotificar = new NotificarController().BuscarProdutoNotificacao(Program.UsuarioLogado.IdColab);
            var adicionarNomeProd = new List<string>();

            foreach (DataGridViewRow row in dgvNotifica.Rows)
            {
                if (row.Cells["NomeColab"].Value != null)
                {
                    var nomeProd = row.Cells["NomeProd"].Value.ToString();
                    adicionarNomeProd.Add("\n" + nomeProd);
                }
            }

            if (listaParaNotificar.Count > 0)
            {
                btNNotifica.Visible = true;
                dgvNotifica.Visible = true;

                string produtosAssinados = "COLABORADOR: " + Program.UsuarioLogado.NomeColab + "\n\n\tSUA ESPERA TERMINOU!\n" +
                "\n\nOS PRODUTOS ABAIXO ESTAR�O DISPON�VEIS NA LOJA ENQUANTO DURAR O ESTOQUE: \n\n\n" +
                string.Join("\n", listaParaNotificar.Select(p => p.NomeProd));

                DialogResult op = MessageBox.Show(produtosAssinados + "\n" +

                "\n\n\nDESEJA VER ESTA LISTA DE NOTIFICA��ES NOVAMENTE?",
                "NOTIFICA��ES", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (op == DialogResult.No)
                {
                    new NotificarController().RemoverNotificacoes(Program.UsuarioLogado.IdColab, listaParaNotificar);

                    MessageBox.Show("SUA ASSINATURA PARA ESTE PRODUTO FOI EXCLU�DA COM SUCESSO!",
                    "ASSINATURA EXCLU�DA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Inativar o bot�o de ver notifica��es
                    btNNotifica.Visible = false;
                    dgvNotifica.Visible = false;
                }
                else
                {
                    btNNotifica.Visible = true;
                    dgvNotifica.Visible = true;
                }
            }
            else
            {
                btNNotifica.Visible = false;
                dgvNotifica.Visible = false;
            }
        }
    }
}