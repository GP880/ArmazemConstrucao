using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.View
{
    public partial class TelaSenhaAutorizacao : Form
    {
        public TelaSenhaAutorizacao()
        {
            InitializeComponent();
        }

        private void btNAutorizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ttbSenha.Text))
            {
                MessageBox.Show("O CAMPO SENHA NÃO PODE FICAR VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            if (ttbSenha.Text.Contains(" "))
            {
                MessageBox.Show("O CAMPO SENHA NÃO PODE CONTER ESPAÇOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            if (string.IsNullOrEmpty(ttbLogin.Text))
            {
                MessageBox.Show("O CAMPO LOGIN NÃO PODE FICAR VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
                return;
            }
            else
            if (ttbLogin.Text.Contains(" "))
            {
                MessageBox.Show("O CAMPO LOGIN NÃO PODE CONTER ESPAÇOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
                return;
            }
            else
            if (!ttbLogin.Text.Contains("@"))
            {
                MessageBox.Show("NO CAMPO LOGIN FALTA O SEGUINTE SÍMBOLO: @",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
                return;
            }
            else
            if (!ttbLogin.Text.Contains(".com"))
            {
                MessageBox.Show("NO CAMPO LOGIN FALTA O SEGUINTE SÍMBOLO: .com",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
                return;
            }
            else
            {
                // fazer aqui a verificação na coluna Autorização
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

                            if (nivelAcesso == ttbLogin.Text)
                            {
                                MessageBox.Show("PERMISSÃO CONCEDIDA COM SUCESSO!",
                                "BOM TRABALHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new TelaCadastroProduto().ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("ESTA CREDENCIAL NÃO ESTÁ CADASTRADA!\n" +
                                "CONSULTE A ADMINISTRADOR DO SISTEMA E TENTE NOVAMENTE!",
                                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    if (!senhaEncontrada)
                    {
                        MessageBox.Show("DADOS INVÁLIDOS! TENTEN NOVAMENTE!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("ERRO AO SOLICITAR PERMISSÃO!\n\n" +
                    "CONSULTE SUAS ANOTAÇÕES E TENTE NOVAMENTE",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
