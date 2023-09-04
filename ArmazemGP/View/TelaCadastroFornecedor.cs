using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.View
{
    public partial class TelaCadastroFornecedor : Form
    {
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
            DataTable data = new DataTable();
            data = new FornecedorController().BuscarFornec();
            dgvFornec.DataSource = data;
            DesaHabilitar();
        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(ttbNomeFornec.Text))
                listaErros.Add("\n O CAMPO NOME FORNECEDOR NÃO PODE FICAR VAZIO!");
            ttbNomeFornec.Focus();

            if (string.IsNullOrEmpty(ttbEmail.Text))
                listaErros.Add("\n O CAMPO E-MAIL NÃO PODE FICAR VAZIO!");
            ttbEmail.Focus();

            if (ttbEmail.Text.Contains(" "))
                listaErros.Add("\n O CAMPO E-MAIL NÃO PODE CONTER ESPAÇOS!");
            ttbEmail.Focus();

            if (!ttbEmail.Text.Contains("@"))
                listaErros.Add("\n NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: @");
            ttbEmail.Focus();

            if (!ttbEmail.Text.Contains(".com"))
                listaErros.Add("\n NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: .com");
            ttbEmail.Focus();

            if (string.IsNullOrEmpty(mktContatoPessoal.Text))                      // ttbContato.Text
                listaErros.Add("\n O CAMPO CONTATO NÃO PODE FICAR VAZIO!");
            mktContatoPessoal.Focus();

            if (string.IsNullOrEmpty(ttbNomeFan.Text))
                listaErros.Add("\n O CAMPO NOME FANTASIA NÃO PODE FICAR VAZIO!");
            ttbNomeFan.Focus();

            if (string.IsNullOrEmpty(ttbRazS.Text))
                listaErros.Add("\n O CAMPO RAZÃO SOCIAL NÃO PODE FICAR VAZIO!");
            ttbRazS.Focus();

            if (string.IsNullOrEmpty(mktCNPJ.Text))  //ttbCnpj.Text
                listaErros.Add("\n O CAMPO CNPJ NÃO PODE FICAR VAZIO!");
            mktCNPJ.Focus();

            if (string.IsNullOrEmpty(mktFixo.Text))
                listaErros.Add("\n O CAMPO CONTATO DA EMPRESA NÃO PODE FICAR VAZIO!");
            mktFixo.Focus();

            if (listaErros.Count > 0)
            {
                MostraErros(listaErros);
                return false;
            }
            else
            {
                bool ok = true;
                return ok;
            }
        }

        private void MostraErros(List<string> erros)
        {
            string mensagens = "";
            foreach (var item in erros)
                mensagens += item;

            MessageBox.Show(mensagens, "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btNGravar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                DataTable PjJaExiste = new FornecedorController().CNPJRepetido(mktCNPJ.Text);  ////ttbCnpj.Text
                if (PjJaExiste.Rows.Count > 0)
                {
                    MessageBox.Show("\n ESTE CNPJ JÁ ESTÁ CADASTRADO EM NOSSA BASE DE DADOS!\n\n" +
                    "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mktCNPJ.Focus();
                    return;
                }

                Fornecedor objForn = new Fornecedor(0,
                ttbNomeFornec.Text,
                ttbEmail.Text,
                mktContatoPessoal.Text,
                ttbNomeFan.Text,
                ttbRazS.Text,
                mktCNPJ.Text,           //ttbCnpj
                mktFixo.Text);

                bool ok = objForn.Gravar();

                if (ok == true)
                {
                    MessageBox.Show("REGISTRO INSERIDO COM SUCESSO!", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("ERRO AO GRAVAR!\n",
                    "ATENÇÃO, TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btNExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornec.CurrentRow.Cells == null)
            {
                MessageBox.Show("NÃO HÁ ITENS PARA EXCLUIR!\n\nCLIQUE EM VOLTAR!",
                "ATENÇÃO, TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvFornec.CurrentRow.Cells != null)
            {
                int idFornec = Convert.ToInt32(dgvFornec.CurrentRow.Cells[0].Value);
                string nomeFornec = dgvFornec.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("\nEXCLUIR CONTA DE: " + nomeFornec + " DO SISTEMA?",
                    "\nÁREA DE PERIGO: ESTA AÇÃO É IRREVERSÍVEL!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (new FornecedorController().Excluir(idFornec))
                        MessageBox.Show("REGISTRO EXCLUÍDO COM SUCESSO!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("ERRO AO EXCLUIR: " + nomeFornec,
                        "ATENÇÃO, TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvFornec.DataSource = new FornecedorController().BuscarFornec();
            }
        }
        private void Habilitar()
        {
            btNAlterar.Enabled = true;
            btNExcluir.Enabled = true;
        }
        private void DesaHabilitar()
        {
            dgvFornec.Columns["IdFornec"].Visible = false;
            btNAlterar.Enabled = false;
            btNExcluir.Enabled = false;
        }

        private void Limpar()
        {
            lbIdFornec.Text = "";
            ttbNomeFornec.Clear();
            ttbEmail.Clear();
            mktContatoPessoal.Clear();
            ttbNomeFan.Clear();
            ttbRazS.Clear();
            mktCNPJ.Clear(); // ttbCnpj.Clear();
            mktFixo.Clear();
        }

        private void btNLimpar_Click(object sender, EventArgs e)
            => Limpar();


        private void btNAlterar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                Fornecedor fornec = new Fornecedor(
                Convert.ToInt32(lbIdFornec.Text),
                ttbNomeFornec.Text,
                ttbEmail.Text,
                mktContatoPessoal.Text,
                ttbNomeFan.Text,
                ttbRazS.Text,
                mktCNPJ.Text,  //// ttbCnpj.Clear();
                mktFixo.Text);

                bool ok = fornec.Alterar();

                if (ok)
                {
                    MessageBox.Show("REGISTRO ALTERADO COM SUCESSO!", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFornec.DataSource = new FornecedorController().BuscarFornec();
                    Limpar();
                    DesaHabilitar();
                }
                else
                {
                    MessageBox.Show("ERRO AO ALTERAR REGISTRO!", "ATENÇÃO, TENTE NOVAMENTE!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btNProximo_Click(object sender, EventArgs e)
            => tabCadastroFonec.SelectedIndex = 1;


        private void dgvFornec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFornec.Rows.Count > 0)
            {
                Habilitar();
                lbIdFornec.Text = dgvFornec.CurrentRow.Cells[0].Value.ToString();
                ttbNomeFornec.Text = dgvFornec.CurrentRow.Cells[1].Value.ToString();
                ttbEmail.Text = dgvFornec.CurrentRow.Cells[2].Value.ToString();
                mktContatoPessoal.Text = dgvFornec.CurrentRow.Cells[3].Value.ToString();
                ttbNomeFan.Text = dgvFornec.CurrentRow.Cells[4].Value.ToString();
                ttbRazS.Text = dgvFornec.CurrentRow.Cells[5].Value.ToString();
                mktCNPJ.Text = dgvFornec.CurrentRow.Cells[6].Value.ToString();      //ttbCnpj.Clear();
                mktFixo.Text = dgvFornec.CurrentRow.Cells[7].Value.ToString();

                tabCadastroFonec.SelectedIndex = 0;
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
