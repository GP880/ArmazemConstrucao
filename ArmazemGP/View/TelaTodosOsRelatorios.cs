using ArmazemGP.Controller;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArmazemGP.View
{
    public partial class TelaTodosOsRelatorios : Form
    {
        #region
        public TelaTodosOsRelatorios()
        {
            InitializeComponent();
            OcultaFiltroDat();

            // COLABORADORES
            DataTable RelatorioColaborador = new ColaboradorController().BuscarColab();
            dgvColab.DataSource = RelatorioColaborador;

            // FORNECEDORES
            DataTable RelatorioFornecedor = new FornecedorController().BuscarFornec();
            dgvFornec.DataSource = RelatorioFornecedor;

            // PRODUTOS
            DataTable RelatorioProduto = new ProdutoController().BuscarProd();
            dgvRelatorioProdutos.DataSource = RelatorioProduto;

            // ESTOQUE
            DataTable RelatorioEstoque = new EstoqueController().BuscarEstoque();
            dgvEstoque.DataSource = RelatorioEstoque;

            if (Program.UsuarioLogado.NivelAcess != 1)
            {
                lbLogin.Visible = false;
                lbSenha.Visible = false;

                ttbLogin.Visible = false;
                ttbSenha.Visible = false;
                btNValidarLogin.Visible = false;

                lbFatTot.Visible = false;
                lbFT.Visible = false;

                lbDin.Visible = false;
                lbFatDin.Visible = false;

                lbPix.Visible = false;
                lbFatPix.Visible = false;

                lbDeb.Visible = false;
                lbFatDeb.Visible = false;

                lbCred.Visible = false;
                lbFatCred.Visible = false;

                lbDesc.Visible = false;
                lbFatDesc.Visible = false;

                lbSubTot.Visible = false;
                lbFatSubTot.Visible = false;

                lbcontaAPG.Visible = false;
                lbContasAPG.Visible = false;

                lbSaldo.Visible = false;
                lbFatSaldo.Visible = false;
            }
            else
            {
                OcultaSeNivel1();
                //-- VENDAS
                DataTable RelatorioVendas = new DataTable();
                RelatorioVendas = new VendaController().BuscarVenda();
                dgvVendas.DataSource = RelatorioVendas;
            }
            return;
        }
        private void Faturamento()
        {
            //-- VENDAS
            DataTable RelatorioVendas = new DataTable();
            RelatorioVendas = new VendaController().BuscarVenda();
            dgvVendas.DataSource = RelatorioVendas;
            //-- FATURAMENTO TOTAL
            decimal fatTotal = new VendaController().BuscarFaturaValorTotal();
            lbFatTot.Text = Convert.ToString(fatTotal);
            //-- FATURAMENTO PIX
            decimal fatPix = new VendaController().BuscarFatPix();
            lbFatPix.Text = Convert.ToString(fatPix);
            //-- FATURAMENTO DINHEIRO
            decimal fatDin = new VendaController().BuscarFatDin();
            lbFatDin.Text = Convert.ToString(fatDin);
            //-- // FATURAMENTO DEBITO
            decimal fatDeb = new VendaController().BuscarFatDeb();
            lbFatDeb.Text = Convert.ToString(fatDeb);
            //-- // FATURAMENTO CREDITO
            decimal fatCred = new VendaController().BuscarFatCred();
            lbFatCred.Text = Convert.ToString(fatCred);
            //-- FATURAMENTO SUBTOTAL
            decimal suBTot = new VendaController().BuscarSubTot();
            lbFatSubTot.Text = Convert.ToString(suBTot);
            //-- DESCONTOS CONCEDIDOS
            decimal descontos = new VendaController().BuscarDescontos();
            lbFatDesc.Text = Convert.ToString(descontos);
            //-- CONTAS A PAGAR
            decimal contasAPG = new ContasPGRController().BuscarContasAPg();
            lbContasAPG.Text = Convert.ToString(contasAPG);
            //-- NOTA FISCAL

            //-- SALDO
            decimal lucro = fatTotal - contasAPG;
            lbFatSaldo.Text = Convert.ToString(lucro);
            lbFatSaldo.Visible = true;
            lbSaldo.Visible = true;

            if (lucro > 0)
            {
                lbFatSaldo.ForeColor = Color.Blue;
                OcultaEMostraLabels();
                MostraLabels();
            }
            else
            {
                lbFatSaldo.ForeColor = Color.Red;
                OcultaEMostraLabels();
                MostraLabels();
            }
        }

        public void CarregandoDados()
        {
            pgbBarra.Maximum = 100;
            pgbBarra.Maximum = 100;
            pgbBarra.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 30;
                while (value <= 100)
                {
                    pgbBarra.Invoke(new Action(() =>
                    {
                        lbCarregando.Text = "Carregando... " +
                        pgbBarra.Value.ToString() + "%";
                        pgbBarra.Value = value;
                        pgbBarra.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    Faturamento();
                    lbCarregando.Visible = false;
                    pgbBarra.Visible = false;
                    return;
                }));
            });
            t.Start();
        }
        public void CarregandoNotas()
        {
            pgbBarra2.Maximum = 100;
            pgbBarra2.Maximum = 100;
            pgbBarra2.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 30;
                while (value <= 100)
                {
                    pgbBarra2.Invoke(new Action(() =>
                    {
                        lbCarregando.Text = "Carregando... " +
                        pgbBarra2.Value.ToString() + "%";
                        pgbBarra2.Value = value;
                        pgbBarra2.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    RelatorioNotasFiscais();
                    lbCarregando.Visible = false;
                    pgbBarra2.Visible = false;
                    return;
                }));
            });
            t.Start();
        }

        private void OcultaEMostraLabels()
        {
            lbFT.Visible = true;
            lbDin.Visible = true;
            lbPix.Visible = true;
            lbDeb.Visible = true;
            lbCred.Visible = true;
            lbDesc.Visible = true;
            lbSubTot.Visible = true;
            lbFatSubTot.Visible = true;

            lbLogin.Visible = false;
            lbSenha.Visible = false;
            ttbLogin.Visible = false;
            ttbSenha.Visible = false;
            btNValidarLogin.Visible = false;
        }

        private void OcultarLabels()
        {
            lbLogin.Visible = false;
            lbSenha.Visible = false;

            ttbLogin.Visible = false;
            ttbSenha.Visible = false;
            btNValidarLogin.Visible = false;

            lbFatTot.Visible = false;
            lbFT.Visible = false;

            lbDin.Visible = false;
            lbFatDin.Visible = false;

            lbPix.Visible = false;
            lbFatPix.Visible = false;

            lbDeb.Visible = false;
            lbFatDeb.Visible = false;

            lbCred.Visible = false;
            lbFatCred.Visible = false;

            lbDesc.Visible = false;
            lbFatDesc.Visible = false;

            lbSubTot.Visible = false;
            lbFatSubTot.Visible = false;

            lbcontaAPG.Visible = false;
            lbContasAPG.Visible = false;
        }

        private void MostraLabels()
        {
            lbLogin.Visible = false;
            lbSenha.Visible = false;

            ttbLogin.Visible = false;
            ttbSenha.Visible = false;

            btNValidarLogin.Visible = false;

            lbFatTot.Visible = true;
            lbFT.Visible = true;

            lbDin.Visible = true;
            lbFatDin.Visible = true;

            lbPix.Visible = true;
            lbFatPix.Visible = true;

            lbDeb.Visible = true;
            lbFatDeb.Visible = true;

            lbCred.Visible = true;
            lbFatCred.Visible = true;

            lbDesc.Visible = true;
            lbFatDesc.Visible = true;

            lbSubTot.Visible = true;
            lbFatSubTot.Visible = true;

            lbcontaAPG.Visible = true;
            lbContasAPG.Visible = true;

            lbSaldo.Visible = true;
            lbFatSaldo.Visible = true;

            btNBuscar.Enabled = true;
        }
        private void OcultaFiltroDat()
        {
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            mktDataIni.Visible = false;
            mktDataFin.Visible = false;
            ttbCodConta.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
        }

        private void OcultaSeNivel1()
        {
            lbLogin.Visible = false;
            ttbLogin.Visible = false;
            lbSenha.Visible = false;
            ttbSenha.Visible = false;
            btNValidarLogin.Visible = false;
        }

        #endregion

        private void btNValidarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ttbLogin.Text))
            {
                MessageBox.Show("O CAMPO LOGIN NÃO PODE SER VAZIO!",
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
            if (string.IsNullOrEmpty(ttbSenha.Text))
            {
                MessageBox.Show("O CAMPO SENHA NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbSenha.Focus();
                return;
            }
            else
            if (ttbSenha.Text.Contains(" "))
            {
                MessageBox.Show("O CAMPO SENHA NÃO PODE CONTER ESPAÇOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbLogin.Focus();
                return;
            }
            else
            {
                try
                {
                    DataTable buscaAuto = new AutorizacaoController().BuscarAutPRelatorio(ttbLogin.Text);

                    if (buscaAuto.Rows.Count != null)
                    {
                        string loginDigitado = ttbLogin.Text.ToString();
                        string senhaDigitada = ttbSenha.Text.ToString();

                        int idArmazenado = 0;
                        string loginArmazenado = "";
                        string senhaArmazenada = "";
                        bool senhaOK = false;
                        bool loginOK = false;

                        for (int i = 0; i < buscaAuto.Rows.Count; i++)
                        {
                            loginArmazenado = Convert.ToString(buscaAuto.Rows[i]["Login"].ToString());
                            senhaArmazenada = Convert.ToString(buscaAuto.Rows[i]["Senha"].ToString());

                            if (loginArmazenado == loginDigitado)
                            {
                                loginOK = true;
                                if (senhaArmazenada == senhaDigitada)
                                {
                                    senhaOK = true;
                                    MessageBox.Show("LOGIN REALIZADO COM SUCESSO!",
                                    "LOGIN OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    CarregandoDados();
                                    MostraLabels();
                                }
                                else
                                    senhaOK = false;
                            }
                            else
                                loginOK = false;
                        }

                        if (!senhaOK)
                        {
                            MessageBox.Show("SENHA DIGITADA NÃO CORRESPONDE!\n\n" +
                            "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!",
                            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        if (!loginOK)
                        {
                            MessageBox.Show("LOGIN DIGITADO NÃO CORRESPONDE!\n\n" +
                            "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!",
                            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS ARMAZENADOS!\n\n" +
                        "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!\n\n" +
                        "SAIU DO LOOPING NESTA OPERAÇÂO: if (buscaAuto.Rows.Count != null)",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OcultarLabels();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS ARMAZENADOS!\n\n" +
                    "VERIFIQUE SUAS ANOTAÇÕES E TENTE NOVAMENTE!\n\nGEROU ERRO NO TRY CATCH",
                    "ATENÇÃO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btNBuscar_Click(object sender, EventArgs e)
        {
            // CONTAS A PAGAR
            if (Program.UsuarioLogado.NivelAcess == 1)
            {
                CarregandoDados();
            }
            else
            {
                DialogResult R1 = MessageBox.Show("DESEJA INSERIR AS CREDENCIAIS DE ACESSO?",
                "ACESSO RESTRITO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == R1)
                {
                    ttbLogin.Focus();
                    lbLogin.Visible = true;
                    lbSenha.Visible = true;
                    ttbLogin.Visible = true;
                    ttbSenha.Visible = true;
                    btNValidarLogin.Visible = true;
                }
                return;
            }
        }
        private void RelatorioNotasFiscais()
        {
            //-- RELATÓRIO POR NOTA FISCAL
            DataTable NF = new DataTable();
            NF = new ItemVendaController().BuscarNF(Convert.ToInt32(ttbNotaFiscal.Text));
            dgvNF.DataSource = NF;
        }

        private void btNBuscarNF_Click(object sender, EventArgs e)
        {
            CarregandoNotas();
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
