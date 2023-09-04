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

        private void cadastrarSenhaDeAutorizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroAutorizacao().ShowDialog();

        private void cadastrarColaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
            => new TelaCadastroColaborador().ShowDialog();

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaTodosOsRelatorios().ShowDialog();

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
            => new TelaCadastroContasPGR().ShowDialog();

        private void pctSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deslogar e Sair do Sistema?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                new ScreenLogin().ShowDialog();
                this.Close();
            }
        }

        // MÉTODO OBSERVER IMPLEMENTADO E FUNCIONANDO !
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
                "\n\nOS PRODUTOS ABAIXO ESTARÃO DISPONÍVEIS NA LOJA ENQUANTO DURAR O ESTOQUE: \n\n\n" +
                string.Join("\n", listaParaNotificar.Select(p => p.NomeProd));

                DialogResult op = MessageBox.Show(produtosAssinados + "\n" +

                "\n\n\nDESEJA VER ESTA LISTA DE NOTIFICAÇÕES NOVAMENTE?",
                "NOTIFICAÇÕES", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (op == DialogResult.No)
                {
                    new NotificarController().RemoverNotificacoes(Program.UsuarioLogado.IdColab, listaParaNotificar);

                    MessageBox.Show("SUA ASSINATURA PARA ESTE PRODUTO FOI EXCLUÍDA COM SUCESSO!",
                    "ASSINATURA EXCLUÍDA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Inativar o botão de ver notificações
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