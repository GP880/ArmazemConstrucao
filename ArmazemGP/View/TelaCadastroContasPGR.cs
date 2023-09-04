using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Text;

namespace ArmazemGP.View
{
    public partial class TelaCadastroContasPGR : Form
    {
        public TelaCadastroContasPGR()
        {
            InitializeComponent();
            mktDataInputPG.Enabled = false;
            lbAReceber.Visible = false;
            lbAPagar.Visible = false;
        }

        private void btNBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ttbRelatPG.Text))
            {
                if (Program.UsuarioLogado.NivelAcess == 1 && ttbRelatPG.Text == "1" || ttbRelatPG.Text == "2")
                {
                    int codConta = 0;
                    int.TryParse(ttbRelatPG.Text, out codConta);
                    var valorContas = new ContasPGRController().BuscarContas(codConta);
                    dgvRelatorioAPG.DataSource = valorContas;

                    if (ttbRelatPG.Text == "1")
                    {
                        lbAReceber.Visible = false;
                        lbAPagar.Visible = true;
                    }
                    else if (ttbRelatPG.Text == "2")
                    {
                        lbAPagar.Visible = false;
                        lbAReceber.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("VOCÊ PRECISA TER NÍVEL DE ACESSO = 1 PARA ACESSAR ESTAS INFORMAÇÕES!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("OS CAMPOS DE DATAS E CÓDIGO NÃO PODEM SER VAZIOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool TemEntradasValidasCadastro()
        {
            List<string> listaErros = new List<string>();

            decimal nomeConta;
            if (decimal.TryParse(ttbNomeContaPG.Text, out nomeConta))
            {
                listaErros.Add("\nO CAMPO NOME DA CONTA NÃO PODE CONTER NÚMEROS\n\nDIGITE APENAS LETRAS!");
                ttbNomeContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbNomeContaPG.Text.ToLower()))
            {
                listaErros.Add("O CAMPO NOME DA CONTA NÃO PODE SER VAZIO!");
                ttbNomeContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbCodContaPG.Text))
            {
                listaErros.Add("O CAMPO CÓDIGO NÃO PODE SER VAZIO!");
                ttbCodContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(mktDataInputPG.Text))
            {
                listaErros.Add("O CAMPO DATA DE LANÇAMENTO NÃO PODE SER VAZIO!");
                mktDataInputPG.Focus();
            }
            else if (string.IsNullOrEmpty(mktDataOutVencPG.Text))
            {
                listaErros.Add("O CAMPO DATA DE VENCIMENTO NÃO PODE SER VAZIO!");
                mktDataOutVencPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbValorContaPG.Text))
            {
                listaErros.Add("O CAMPO VALOR DA CONTA NÃO PODE SER VAZIO!");
                ttbValorContaPG.Focus();
            }
            else if (ttbCodContaPG.Text != "1" && ttbCodContaPG.Text != "2")
            {
                listaErros.Add("O CAMPO CÓDIGO DA CONTA DEVE SER (1 OU 2)\n\n" +
                "'1' SE REFERE A CONTAS A PAGAR E '2' A RECEBER!");
                ttbCodContaPG.Focus();
            }
            else if(ttbObs.Text.Length < 0 || ttbObs.Text.Length > 200)
            {
                listaErros.Add("O campo observações não pode conter mais do que 200 caracteres!");
                ttbObs.Focus();
            }


            DataTable dtConsulta = new ContasPGRController().ContaRepetida(ttbNomeContaPG.Text);
            if (dtConsulta.Rows.Count > 0)
            {
                listaErros.Add("ESTA CONTA JÁ ESTÁ CADASTRADA EM NOSSA BASE DE DADOS!\n\n" +
                "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!");
                ttbNomeContaPG.Focus();
            }

            if (listaErros.Count > 0)
            {
                MostraErros(listaErros);
                return false;
            }
            else
                return true;
        }
        private void MostraErros(List<string> erros)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in erros)
                sb.AppendLine(item);

            MessageBox.Show(sb.ToString(), "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btNGravarPG_Click(object sender, EventArgs e)
        {
            int lbidPG;
            int.TryParse(lbIdCAPG.Text, out lbidPG);

            int lbidR;
            int.TryParse(lbIdCAR.Text, out lbidR);

            decimal valPG;
            decimal.TryParse(ttbValorContaPG.Text, out valPG);

            int codConta;
            int.TryParse(ttbCodContaPG.Text, out codConta);

            // OBJETO CONTAS A PAGAR
            ContasPGR objContasPGR = new ContasPGR(lbidPG, ttbNomeContaPG.Text, codConta, valPG, ttbObs.Text);

            objContasPGR.DataInput = DateTime.Now;

            DateTime dataOut;
            if (DateTime.TryParse(mktDataOutVencPG.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut))
                objContasPGR.DataOut = dataOut;
            else
            {
                MessageBox.Show("A DATA DE PAGAMENTO É INVÁLIDA!",
                "ERRO NA DATA DE VENCIMENTO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mktDataOutVencPG.Focus();
            }

            if (TemEntradasValidasCadastro())
            {
                bool contaOK = objContasPGR.GravarConta();

                if (contaOK)
                {
                    MessageBox.Show("CONTA GRAVADA COM SUCESSO!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("OCORREU UM ERRO E A CONTA NÃO FOI GRAVADA!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbNomeContaPG.Focus();
                    return;
                }
            }
        }
        private void Habilitar()
        {
            btNAlterarPG.Enabled = true;
            btNExcluirPG.Enabled = true;
        }

        private void btNAlterarPG_Click(object sender, EventArgs e)
        {
            int lbidPG;
            int.TryParse(lbIdCAPG.Text, out lbidPG);

            int lbidR;
            int.TryParse(lbIdCAR.Text, out lbidR);

            decimal valPG;
            decimal.TryParse(ttbValorContaPG.Text, out valPG);

            int codConta;
            int.TryParse(ttbCodContaPG.Text, out codConta);

            // OBJETO CONTAS A PAGAR
            ContasPGR objContasPGR = new ContasPGR(lbidPG, ttbNomeContaPG.Text, codConta, valPG);

            objContasPGR.DataInput = DateTime.Now;

            DateTime dataOut;
            if (DateTime.TryParse(mktDataOutVencPG.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut))
                objContasPGR.DataOut = dataOut;
            else
            {
                MessageBox.Show("A DATA DE PAGAMENTO É INVÁLIDA!",
                "ERRO NA DATA DE VENCIMENTO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mktDataOutVencPG.Focus();
            }

            if (TemEntradasValidasAlterar())
            {
                bool contaOK = objContasPGR.AlterarConta();

                if (contaOK)
                {
                    MessageBox.Show("CONTA ALTERADA COM SUCESSO!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("OCORREU UM ERRO E A CONTA NÃO FOI ALTERADA!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbNomeContaPG.Focus();
                    return;
                }
            }
        }

        public bool TemEntradasValidasAlterar()
        {
            List<string> listaErros = new List<string>();

            decimal nomeConta;
            if (decimal.TryParse(ttbNomeContaPG.Text, out nomeConta))
            {
                listaErros.Add("\nO CAMPO NOME DA CONTA NÃO PODE CONTER NÚMEROS\n\nDIGITE APENAS LETRAS!");
                ttbNomeContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbNomeContaPG.Text.ToLower()))
            {
                listaErros.Add("O CAMPO NOME DA CONTA NÃO PODE SER VAZIO!");
                ttbNomeContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbCodContaPG.Text))
            {
                listaErros.Add("O CAMPO CÓDIGO NÃO PODE SER VAZIO!");
                ttbCodContaPG.Focus();
            }
            else if (string.IsNullOrEmpty(mktDataInputPG.Text))
            {
                listaErros.Add("O CAMPO DATA DE LANÇAMENTO NÃO PODE SER VAZIO!");
                mktDataInputPG.Focus();
            }
            else if (string.IsNullOrEmpty(mktDataOutVencPG.Text))
            {
                listaErros.Add("O CAMPO DATA DE VENCIMENTO NÃO PODE SER VAZIO!");
                mktDataOutVencPG.Focus();
            }
            else if (string.IsNullOrEmpty(ttbValorContaPG.Text))
            {
                listaErros.Add("O CAMPO VALOR DA CONTA NÃO PODE SER VAZIO!");
                ttbValorContaPG.Focus();
            }
            else if (ttbCodContaPG.Text != "1" && ttbCodContaPG.Text != "2")
            {
                listaErros.Add("O CAMPO CÓDIGO DA CONTA DEVE SER (1 OU 2)\n\n" +
                "'1' SE REFERE A CONTAS A PAGAR E '2' A RECEBER!");
                ttbCodContaPG.Focus();
            }

            if (listaErros.Count > 0)
            {
                MostraErro(listaErros);
                return false;
            }
            else
                return true;
        }
        private void MostraErro(List<string> erros)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in erros)
                sb.AppendLine(item);

            MessageBox.Show(sb.ToString(), "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvRelatorioAPG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRelatorioAPG.Rows.Count > 0)
            {
                Habilitar();
                lbIdCAPG.Text = dgvRelatorioAPG.CurrentRow.Cells[0].Value.ToString();
                ttbNomeContaPG.Text = dgvRelatorioAPG.CurrentRow.Cells[1].Value.ToString();
                ttbCodContaPG.Text = dgvRelatorioAPG.CurrentRow.Cells[2].Value.ToString();
                ttbValorContaPG.Text = dgvRelatorioAPG.CurrentRow.Cells[3].Value.ToString();
                mktDataInputPG.Text = dgvRelatorioAPG.CurrentRow.Cells[4].Value.ToString();
                mktDataOutVencPG.Text = dgvRelatorioAPG.CurrentRow.Cells[5].Value.ToString();
                tabContas.SelectedIndex = 0;
            }
        }

        private void LimparCampos()
        {
            ttbNomeContaPG.Clear();
            ttbCodContaPG.Clear();
            ttbValorContaPG.Clear();
            mktDataInputPG.Clear();
            mktDataOutVencPG.Clear();
            ttbObs.Clear();
        }

        private void btNLimpar_Click(object sender, EventArgs e)
            => LimparCampos();

        private void btNExcluirPG_Click(object sender, EventArgs e)
        {
            int lbidPG;
            int.TryParse(lbIdCAPG.Text, out lbidPG);

            int lbidR;
            int.TryParse(lbIdCAR.Text, out lbidR);

            decimal valPG;
            decimal.TryParse(ttbValorContaPG.Text, out valPG);

            int codConta;
            int.TryParse(ttbCodContaPG.Text, out codConta);

            // OBJETO CONTAS A PAGAR
            ContasPGR objContasPGR = new ContasPGR(lbidPG, ttbNomeContaPG.Text, codConta, valPG, ttbObs.Text);

            objContasPGR.DataInput = DateTime.Now;

            DateTime dataOut;
            if (DateTime.TryParse(mktDataOutVencPG.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut))
                objContasPGR.DataOut = dataOut;
            else
            {
                MessageBox.Show("A DATA DE PAGAMENTO É INVÁLIDA!",
                "ERRO NA DATA DE VENCIMENTO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mktDataOutVencPG.Focus();
            }

            if (TemEntradasValidasCadastro())
            {
                bool contaOK = objContasPGR.ExcluirConta();

                if (contaOK)
                {
                    MessageBox.Show("CONTA EXCLUÍDA COM SUCESSO!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    return;
                }
                else
                {
                    MessageBox.Show("OCORREU UM ERRO E A CONTA NÃO FOI EXCLUÍDA!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbNomeContaPG.Focus();
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
