using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;
using System.Text;

namespace ArmazemGP.View
{
    public partial class TelaCadastroAutorizacao : Form
    {
        public TelaCadastroAutorizacao()
        {
            InitializeComponent();
            if (Program.UsuarioLogado.NivelAcess == 1)
            {
                DataTable dtAuto = new DataTable();
                dtAuto = new AutorizacaoController().BuscarAutorizacao(Text);
                dgvAuto.DataSource = dtAuto;
            }
        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbLogin.Text))
                listaErros.Add("\nO CAMPO LOGIN NÃO PODE FICAR VAZIO!");
            ttbLogin.Focus();

            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\nO CAMPO SENHA NÃO PODE FICAR VAZIO!");
            ttbSenha.Focus();

            if (ttbLogin.Text.Contains(" "))
                listaErros.Add("O CAMPO E-MAIL NÃO PODE CONTER ESPAÇOS!");
            ttbLogin.Focus();

            if (!ttbLogin.Text.Contains("@"))
                MessageBox.Show("NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: @");
            ttbLogin.Focus();

            if (!ttbLogin.Text.Contains(".com"))
            {
                MessageBox.Show("NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: .com!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
            }

            DataTable jaExiste = new AutorizacaoController().VerSeJaExiste(ttbLogin.Text);

            if (jaExiste.Rows.Count > 0)
                listaErros.Add("ESTA CREDENCIAL JÁ EXISTE EM NOSSA BASE DE DADOS!" +
                "\n\nCADASTRE UMA NOVA CREDENCIAL E TENTE NOVAMENTE!");

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
        private void MostraErros(List<string> listaErros)
        {
            StringBuilder strb = new StringBuilder();
            foreach (var item in listaErros)
                strb.AppendLine(item);

            MessageBox.Show(strb.ToString(), "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btNCriarGravar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                Autorizacao autorizado = new Autorizacao(0, ttbLogin.Text, ttbSenha.Text);

                bool ok = autorizado.Gravar();
                if (ok)
                {
                    MessageBox.Show("\nNOVA SENHA AUTORIZATIVA CADASTRADA COM SUCESSO!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("ERRO AO TENTAR GRAVAR NOVA SENHA AUTORIZATIVA!\n\n" +
                    "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ttbLogin.Text))
            {
                MessageBox.Show("\nO CAMPO LOGIN NÃO PODE FICAR VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            if (string.IsNullOrEmpty(ttbSenha.Text))
            {
                MessageBox.Show("\nO CAMPO SENHA NÃO PODE FICAR VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                new TelaSenhaAutorizacao().ShowDialog();
                DataTable dt = new AutorizacaoController().BuscarAutorizacao(ttbLogin.Text);
                if (dt.Rows.Count > 0)
                {
                    string senhaDigitada = ttbSenha.Text.ToLower();
                    bool senhaEncontrada = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string senhaArmazenada = dt.Rows[i]["Senha"].ToString().ToLower();

                        if (senhaArmazenada == senhaDigitada)
                        {
                            senhaEncontrada = true;

                            //Autorização Concedida
                            new Autorizacao(
                            Convert.ToInt32(dt.Rows[i]["IdAut"].ToString()),
                            dt.Rows[i]["Login"].ToString(),
                            dt.Rows[i]["Senha"].ToString());

                            string nivelAcesso = dt.Rows[i]["Login"].ToString();
                            if (ttbLogin.Text == "")
                                btNExcluir.Enabled = false;
                            else
                                btNExcluir.Enabled = true;
                            if (nivelAcesso == ttbLogin.Text)
                            {
                                if (dgvAuto.CurrentRow.Cells == null)
                                {
                                    MessageBox.Show("NÃO HÁ ITENS NO RELATÓRIO PARA EXCLUIR!\n\n" +
                                    "CLIQUE EM VOLTAR E TENTE NOVAMENTE!",
                                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (dgvAuto.CurrentRow.Cells != null)
                                {
                                    int idColab = Convert.ToInt32(dgvAuto.CurrentRow.Cells[0].Value);
                                    string username = dgvAuto.CurrentRow.Cells[1].Value.ToString();

                                    if (MessageBox.Show("\nEXCLUIR O CADASTRO DE: " + username + " DO SISTEMA?",
                                        "\nÁREA DE PERIGO: ESTA AÇÃO É IRREVERSÍVEL!", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                    {
                                        if (new AutorizacaoController().Excluir(idColab))
                                            MessageBox.Show("REGISTRO EXCLUÍDO COM SUCESSO!",
                                            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        else
                                            MessageBox.Show("ERRO AO EXCLUIR: " + username + "\n\n" +
                                            "PARA EXCLUIR UMA AUTORIZAÇÃO, CERTIFIQUE-SE DE QUE ELA\n" +
                                            "NÃO ESTEJA REGISTRADA EM OUTRA TABELA NO BANCO E TENTE NOVAMENTE!",
                                            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    dgvAuto.DataSource = new AutorizacaoController().BuscarAut(ttbLogin.Text);
                                }

                                Autorizacao ObjAuto = new Autorizacao(0, ttbLogin.Text, ttbSenha.Text);

                                bool entradasOK = false;
                                if (TemEntradasValidas())
                                {
                                    entradasOK = ObjAuto.Excluir();

                                    if (entradasOK)
                                    {
                                        MessageBox.Show("AUTORIZAÇÃO EXCLUÍDA COM SUCESSO!",
                                        "REGISTRO EXCLUÍDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("ESTA CREDENCIAL NÃO ESTÁ CADASTRADA!\n" +
                                "CONSULTE SUAS ANOTAÇÕES E TENTE NOVAMENTE!",
                                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    if (!senhaEncontrada)
                    {
                        MessageBox.Show("DADOS INVÁLIDOS! TENTE NOVAMENTE",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        private void OcultaDadosDgvAuto()
            => dgvAuto.Visible = false;


        private void MostraDadosDgvAuto()  //   VERIFICAR A NECESSIDADE DESTE MÉTODO
        {
            dgvAuto.Visible = true;
            DataTable data = new DataTable();
            data = new AutorizacaoController().BuscarAuto(ttbLogin.Text);
            dgvAuto.DataSource = data;
        }

        private void btNLimpar_Click(object sender, EventArgs e)
        {
            ttbLogin.Clear();
            ttbSenha.Clear();
        }

        private void dgvAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable aut = new AutorizacaoController().BuscarAuto(ttbLogin.Text);

            if (aut.Rows.Count > 0)
            {
                if (Program.UsuarioLogado.NivelAcess == 1)
                {
                    lbAuto.Text = Convert.ToString(dgvAuto.CurrentRow.Cells[0].Value);
                    ttbLogin.Text = Convert.ToString(dgvAuto.CurrentRow.Cells[1].Value);
                    ttbSenha.Text = Convert.ToString(dgvAuto.CurrentRow.Cells[2].Value);
                    tabAutorizacao.SelectedIndex = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("NO MOMENTO SEU NÍVEL DE ACESSO NÃO PERMITE A VISUALIZAÇÃO DESTAS INFORMAÇÕES!",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("NÃO HÁ SENHAS DE AUTORIZAÇÃO GRAVADAS NO MOMENTO.",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
