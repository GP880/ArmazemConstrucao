using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.View
{
    public partial class TelaCadastroQtd : Form
    {
        public TelaCadastroQtd()
        {
            InitializeComponent();
            MontaComboProduto();
            buscaQtdEstoq();
            // PRODUTO
            ProdutoController prodCtr = new ProdutoController();
            var dados = new ProdutoController().BuscarProd();
            dgvProd.DataSource = dados;
            // ESTOQUE
            EstoqueController estCtr = new EstoqueController();
            var estQtd = new EstoqueController().BuscarEstoque();
            dgvQtd.DataSource = estQtd;
        }
        private void MontaComboProduto()
        {
            // Obtendo os Produtos para o combobox apresentar 
            ProdutoController ctr = new ProdutoController();
            var dados = new ProdutoController().BuscarProd();
            if (dados.Rows.Count > 0)
            {
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    Produto prod = new Produto(Convert.ToInt32(dados.Rows[i]["IdProd"].ToString()),
                    dados.Rows[i]["NomeProd"].ToString());
                    cbbProd.Items.Add(prod);
                }
                cbbProd.DropDownStyle = ComboBoxStyle.DropDownList;
                cbbProd.DisplayMember = "NomeProd";
                cbbProd.ValueMember = "IdProd";
                lbIdProd.Text = cbbProd.Text;
            }
            else
                cbbProd.Items.Add(new Produto(-1, "NÃO EXISTE PRODUTO CADASTRADO!"));
        }

        private void cbbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)cbbProd.SelectedItem;
            if (produtoSelecionado != null)
            {
                EstoqueController estCtr = new EstoqueController();
                int idProdSelecionado = produtoSelecionado.IdProd;
                int quantidadeProduto = estCtr.ObterQuantidadeProduto(idProdSelecionado); // CHAMADA PARA O ESTOQUE DO PRODUTO SELECIONADO AQUI
                lbNome.Text = produtoSelecionado.NomeProd;
                lbQtdEstoqueAtual.Text = Convert.ToString(quantidadeProduto.ToString());
            }
            else
            {
                MessageBox.Show("ESTE ITEM NÃO EXISTE EM NOSSO ESTOQUE!",
                "CADASTRE ESTE ITEM!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void transportaQtd()
        {
            DataTable dtResult = new DataTable();
            EstoqueController ctrEst = new EstoqueController();

            if (string.IsNullOrEmpty(ttbQtd.Text))
            {
                MessageBox.Show("O CAMPO QUANTIDADE NÃO PODE SER VAZIO!",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbQtd.Focus();
                return;
            }

            if (ttbQtd.Text.Contains(" "))
            {
                MessageBox.Show("\n O CAMPO QUANTIDADE NÃO PODE CONTER ESPAÇOS!",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbQtd.Focus();
                return;
            }

            int idProd;
            int.TryParse(cbbProd.Text, out idProd);
            dtResult = ctrEst.BuscarEstoqueIdProd(idProd);

            if (dtResult.Rows.Count > 0)
            {
                dgvQtd.DataSource = dtResult;
                lbIdProd.Text = dgvQtd.CurrentRow.Cells[0].Value.ToString();
                int qtd = Convert.ToInt32(ttbQtd.Text);
            }
            else
            {
                MessageBox.Show("PRODUTO EM FALTA!\n\n ADICIONE PRODUTOS AO ESTOQUE!",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buscaQtdEstoq()
        {
            DataTable dados = new EstoqueController().BuscarEstoque();
            EstoqueController estC = new EstoqueController();
            var estoque = new EstoqueController().BuscarEstoque();
            lbQtdEstoqueAtual.Text = "";
            Estoque estoQ = new Estoque();

            if (estoque.Rows.Count > 0)
            {
                for (int i = 0; i < estoque.Rows.Count; i++)
                {
                    Estoque est = new Estoque(Convert.ToInt32(int.Parse(estoque.Rows[i]["IdEstoque"].ToString())),
                    Convert.ToInt32(int.Parse(estoque.Rows[i]["IdProd"].ToString())),
                    Convert.ToInt32(int.Parse(estoque.Rows[i]["Qtd"].ToString())));
                    if (lbIdProd.Text == dados.Rows[i]["IdProd"].ToString())
                    {
                        lbQtdEstoqueAtual.Text = dgvQtd.Rows[i].Cells[2].Value.ToString();
                        break;
                    }
                }
                cbbQtd.DisplayMember = "Qtd";
                cbbQtd.ValueMember = "IdEstoque";
            }
            else
                cbbQtd.Items.Add(new Produto(-1, "ESTOQUE ZERADO!"));
        }

        private void btNGravar_Click(object sender, EventArgs e)
        {
            Produto prodSelect = (Produto)cbbProd.SelectedItem;
            int idProd = prodSelect.IdProd;
            int NovaQtd;
            int.TryParse(ttbQtd.Text, out NovaQtd);
            if (NovaQtd <= 0)
            {
                MessageBox.Show("O CAMPO QUANTIDADE NÃO PODE SER VAZIO!",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbProd.SelectedItem == null)
            {
                MessageBox.Show("VOCÊ PRECISA SELECIONAR PELO MENOS UM ITEM PARA ADICIONAR A QUANTIDADE DESEJADA!",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //essa busca poderia ser por código ou id,evitando possíveis problemas com nomes iguais
                DataTable dtConsulta = new ProdutoController().BuscarProdPorCodigo(idProd);
                EstoqueController estoqueController = new EstoqueController();
                try
                {
                    Estoque consultaQtd = dtConsulta.Rows.Count > 0 ? new Estoque(
                    Convert.ToInt32(dtConsulta.Rows[0]["IdProd"].ToString()),
                    Convert.ToInt32(dgvQtd.CurrentRow.Cells[2].Value.ToString()),
                    Convert.ToInt32(ttbQtd.Text)) : null;

                    bool gravouOK = estoqueController.AtualizarEstoque(idProd, NovaQtd);

                    if (gravouOK)
                    {
                        ttbQtd.Clear();
                        MessageBox.Show("PRODUTO ATUALIZADO COM SUCESSO!",
                            "PRODUTO ATUALIZADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var assinantes = new AssinanteController().ObterAssinantesProduto(idProd);

                        for (int i = 0; i < assinantes.Rows.Count; i++)
                            new Notificar(idProd, Convert.ToInt32(assinantes.Rows[i]["IdColab"].ToString())).AdicionarNotificacao();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("ERRO NA CONTROLLER!",
                            "NÃO ATUALIZOU AQUI X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO AO ATUALIZAR O PRODUTO!",
                    "NÃO ATUALIZOU A QUANTIDADE! K", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                return;
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar janela?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

