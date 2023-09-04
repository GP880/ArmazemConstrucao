using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace ArmazemGP.View
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
            dgvCatalogo.DataSource = new ProdutoController().BuscarProd();
            OcultarCampos();
            OcultaCamposDeBusca();
            ttbQtd.Text = "1";
            int qtd = 0;

            int nivel;
            int.TryParse(lbNivelAccesUsuarioLogado.Text, out nivel);
            int niveAcces = Convert.ToInt32(Program.UsuarioLogado.NivelAcess.ToString());
            lbNivelAccesUsuarioLogado.Text = Convert.ToString(niveAcces);
            string nome = Convert.ToString(Program.UsuarioLogado.NomeColab.ToString());
            lbUsuarioLogado.Text = Convert.ToString(nome);
            ttbCodColab.Text = Convert.ToInt32(Program.UsuarioLogado.CodColab).ToString();

            // CONDIÇÕES DE APRESENTAÇÃO DA TELA VENDAS
            #region
            lbCodOperador.Text = ttbCodColab.Text.ToString();
            lbUrgente.Visible = false;
            lbPermissao.Text = Convert.ToString(0);
            btNExcluir.Enabled = true;
            btNAlterar.Enabled = true;
            ttbTotal.Enabled = false;
            ttbCodProd.Focus();

            lbAindaFaltam1.Visible = false;
            lbAindaFaltam2.Visible = false;

            if (niveAcces != 3)
            {
                DataTable data = new DataTable();
                data = new ItemVendaController().BuscarItemVenda();
            }
            else if (ttbDesc.Text == "")
                OcultarCampos();
            else if (ttbDesc.Text != "")
            {
                MostrarCampos();
                btNVender.Enabled = false;
            }
            else if (ttbLoginAuto.Text != "" && ttbSenhaAuto.Text != "")
                btNVender.Enabled = true;
            else if (nivel != 3)
            {
                DataTable data = new DataTable();
                data = new VendaController().BuscarVenda();
            }
            #endregion
        }

        //  BOTÕES DE LIMPEZA, EXCLUIR, SAIR, SELOS E TRATAMENTO DOS CAMPOS
        #region

        private void OcultaCamposDeBusca()
        {
            ttbPreco.Enabled = false;
            ttbTotal.Enabled = false;
            mktData.Enabled = false;
        }
        private void MostraCamposDeBusca()
        {
            ttbQtd.Enabled = true;
            ttbPreco.Enabled = false;
            ttbTotal.Enabled = false;
            mktData.Enabled = false;
        }
        public void LimparTudo()
        {
            // LIMPA dgvCesta AQUI
            dgvCesta.DataSource = null;
            // LIMPA LISTA Cesta AQUI
            Program.Cesta.Clear();

            subtotalTOTAL = 0;

            ttbDin.Text = string.Empty;
            ttbCodProd.Text = string.Empty;
            ttbDesc.Text = string.Empty;
            ttbNomeProd.Text = string.Empty;
            ttbQtd.Text = string.Empty;
            ttbLoginAuto.Text = string.Empty;
            ttbSenhaAuto.Text = string.Empty;
            ttbPreco.Text = string.Empty;
            ttbTotal.Text = string.Empty;
            ttbValFin.Text = string.Empty;
            ttbValFin.Text = "";
            ttbValFin.Clear();
            ttbDeb.Text = string.Empty;
            ttbCred.Text = string.Empty;
            ttbPix.Text = string.Empty;

            ttbLoginAuto.Visible = false;
            ttbSenhaAuto.Visible = false;
            lbCredenciais.Visible = false;
            lbLimpaLoginAuto.Visible = false;
            lbLimpaSenhaAuto.Visible = false;
            lbLoginAuto.Visible = false;
            lbSenhaAuto.Visible = false;
            btNAutorizar.Visible = false;

            lbValorFinal.Text = string.Empty;
            lbUrgente.Visible = false;
            lbQtdDisponivel.Text = string.Empty;
        }

        private void LimparCamposDeConsulta()
        {
            ttbCodProd.Text = string.Empty;
            ttbDesc.Text = string.Empty;
            ttbNomeProd.Text = string.Empty;
            //ttbQtd.Text = string.Empty;
            ttbQtd.Text = "1";
            ttbLoginAuto.Text = string.Empty;
            ttbSenhaAuto.Text = string.Empty;
            ttbPreco.Text = string.Empty;
            ttbTotal.Text = string.Empty;
            ttbDin.Text = string.Empty;
            ttbDeb.Text = string.Empty;
            ttbCred.Text = string.Empty;
            ttbPix.Text = string.Empty;

            // Caminho da imagem fixa
            string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\MicrosoftTeams-image.png";
            // Verifica se o arquivo existe no endereço acima citado
            if (File.Exists(caminhoImagemIlustrativa))
            {
                // Carrega a imagem a partir do caminho mencionado na string acima
                Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);
                // Atribui a imagem ao nome de domínio da picture definida
                pctProd.Image = imagemIlustrativa;
            }
        }

        private void OcultarCampos()
        {
            ttbLoginAuto.Visible = false;
            ttbSenhaAuto.Visible = false;
            lbLoginAuto.Visible = false;
            lbSenhaAuto.Visible = false;
            btNAutorizar.Visible = false;
            lbCredenciais.Visible = false;
            lbLimpaLoginAuto.Visible = false;
            lbLimpaSenhaAuto.Visible = false;
            pctFundoCrecenciais.Visible = false;
            pctOLHO.Visible = false;
        }
        private void OcultaBandeiras()
        {
            pctBandeiras.Visible = false;
            pctVisa.Visible = false;
            pctVisaElec.Visible = false;
            pctMasterC.Visible = false;
            pctDiners.Visible = false;
            pctElo.Visible = false;
            pctHiperC.Visible = false;
            pctAmex.Visible = false;
            pctPix.Visible = false;
            lbBandeirasQTrab.Visible = false;
        }
        private void MostrarBandeiras()
        {
            pctBandeiras.Visible = true;
            pctVisa.Visible = true;
            pctVisaElec.Visible = true;
            pctMasterC.Visible = true;
            pctDiners.Visible = true;
            pctElo.Visible = true;
            pctHiperC.Visible = true;
            pctAmex.Visible = true;
            pctPix.Visible = true;
            lbBandeirasQTrab.Visible = true;
        }
        private void MostrarCampos()
        {
            ttbLoginAuto.Visible = true;
            ttbSenhaAuto.Visible = true;
            lbLoginAuto.Visible = true;
            lbSenhaAuto.Visible = true;
            btNAutorizar.Visible = true;
            lbCredenciais.Visible = true;
            lbLimpaLoginAuto.Visible = true;
            lbLimpaSenhaAuto.Visible = true;
            pctFundoCrecenciais.Visible = true;
            pctOLHO.Visible = true;
            OcultaBandeiras();
        }
        private void btNLimpar_Click(object sender, EventArgs e)
            => LimparCamposDeConsulta();
        private void lbLimpar7_Click(object sender, EventArgs e)
            => ttbDesc.Clear();
        private void label17_Click(object sender, EventArgs e)
            => ttbLoginAuto.Clear();
        private void label16_Click(object sender, EventArgs e)
            => ttbSenhaAuto.Clear();
        private void lbLimpaDin_Click(object sender, EventArgs e)
            => ttbDin.Clear();
        private void lbLimpaCred_Click(object sender, EventArgs e)
            => ttbCred.Clear();
        private void lbLimpaDeb_Click(object sender, EventArgs e)
            => ttbDeb.Clear();
        private void label20_Click(object sender, EventArgs e)
            => ttbPix.Clear();
        private void label33_Click(object sender, EventArgs e)
            => ttbQtd.Clear();
        private void label34_Click(object sender, EventArgs e)
            => ttbCodProd.Clear();

        public bool CamposDeBuscaValidos()
        {
            List<string> listaErrosDeBusca = new List<string>();

            if (string.IsNullOrEmpty(ttbQtd.Text))
            {
                listaErrosDeBusca.Add("\n O CAMPO QUANTIDADE NÃO PODE SER VAZIO!");
                ttbQtd.Focus();
            }
            if (ttbDin.Text.Contains(" "))
            {
                listaErrosDeBusca.Add("\n O CAMPO DINHEIRO NÃO PODE CONTER ESPAÇOS!");
                ttbDin.Focus();
            }
            if (ttbCred.Text.Contains(" "))
            {
                listaErrosDeBusca.Add("\n O CAMPO CREDITO NÃO PODE CONTER ESPAÇOS!");
                ttbCred.Focus();
            }
            if (ttbDeb.Text.Contains(" "))
            {
                listaErrosDeBusca.Add("\n NO CAMPO DÉBITO NÃO PODE CONTER ESPAÇOS!");
                ttbDeb.Focus();
            }
            if (ttbPix.Text.Contains(" "))
            {
                listaErrosDeBusca.Add("\n NO CAMPO Pix NÃO PODE CONTER ESPAÇOS!");
                ttbDeb.Focus();
            }

            if (listaErrosDeBusca.Count > 0)
            {
                MostraErrosDeBusca(listaErrosDeBusca);
                return false;
            }
            else
            {
                bool temErros = true;
                return temErros;
            }
        }
        private void MostraErrosDeBusca(List<string> errosDeBusca)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in errosDeBusca)
                sb.AppendLine(item);

            MessageBox.Show(sb.ToString(), "ATENÇÃO: ERROS DE BUSCA!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // VALIDAÇÃO FINAL DOS CAMPOS ANTES DE BUSCAR NO BANCO
        public bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (ttbQtd.Text.Contains(" "))
                listaErros.Add("\n O CAMPO QUANTIDADE NÃO PODE CONTER ESPAÇOS!");
            else if (Regex.IsMatch(ttbQtd.Text, "[a-zA-Z]"))
                listaErros.Add("NO CAMPO QUANTIDADE NÃO PODE CONTER LETRAS ALFABÉTICAS!");
            ttbQtd.Focus();

            if (ttbCodProd.Text.Contains(" "))
                listaErros.Add("\n O CAMPO CÓDIGO DO PRODUTO NÃO PODE CONTER ESPAÇOS!");

            if (ttbDin.Text.Contains(" "))
                listaErros.Add("\n O CAMPO DINHEIRO NÃO PODE CONTER ESPAÇOS!");

            if (ttbCred.Text.Contains(" "))
                listaErros.Add("\n O CAMPO CREDITO NÃO PODE CONTER ESPAÇOS!");

            if (ttbDeb.Text.Contains(" "))
                listaErros.Add("\n NO CAMPO DÉBITO NÃO PODE CONTER ESPAÇOS!");

            if (ttbPix.Text.Contains(" "))
                listaErros.Add("\n NO CAMPO Pix NÃO PODE CONTER ESPAÇOS!");

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
            StringBuilder sb = new StringBuilder();
            foreach (var item in erros)
                sb.AppendLine(item);

            MessageBox.Show(sb.ToString(), "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btNExcluir_Click(object sender, EventArgs e)
        {
            MostrarCampos();

            if (lbPermissao.Text == Convert.ToString(1))
            {
                if (TemEntradasValidas())
                {
                    int lbIdPro = 0;
                    int.TryParse(lbIdProd.Text, out lbIdPro);
                    int lbQtdDisp = 0;
                    int.TryParse(lbQtdDisponivel.Text, out lbQtdDisp);
                    decimal subTotal = 0m;
                    decimal.TryParse(ttbTotal.Text, out subTotal);
                    int idColab = 0;
                    int.TryParse(lbIdColab.Text, out idColab);

                    //  OBJETO ESTOQUE
                    ItemVenda objIvtemV = new ItemVenda(0, lbIdPro, lbQtdDisp, subTotal, 0, idColab);

                    int codColab = 0;
                    int.TryParse(ttbCodColab.Text, out codColab);
                    int lbIdProduto = 0;
                    int.TryParse(lbIdProd.Text, out lbIdProduto);
                    decimal total = 0m;
                    decimal.TryParse(ttbTotal.Text, out total);
                    int lbIdColaborador = 0;
                    int.TryParse(lbIdColab.Text, out lbIdColaborador);
                    decimal desconto = 0m;
                    decimal.TryParse(ttbDesc.Text, out desconto);

                    //  OBJETO VENDA
                    Venda objVenda = new Venda(0, codColab, lbIdPro, total, lbIdColaborador, desconto);
                    bool vendaOK = objVenda.Excluir();
                    bool itemVendaOK = objIvtemV.ExcluirItemVenda(lbIdProduto);
                    if (vendaOK)
                    {
                        MessageBox.Show("VENDA EXCLUÍDA COM SUCESSO!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (itemVendaOK)
                    {
                        MessageBox.Show("ITEM_VENDA EXCLUÍDO COM SUCESSO!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (!vendaOK)
                    {
                        MessageBox.Show("ERRO AO TENTAR EXCLUIR A VENDA!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (!itemVendaOK)
                    {
                        MessageBox.Show("ERRO AO TENTAR EXCLUIR O ITEM_VENDA!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("O CAMPO DESCONTO NÃO PODE SER VAZIO\n\n" +
                    "ADICIONE QUALQUER VALOR PARA PROSSEGUIR!", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("VERIFIQUE SUAS CREDENCIAIS E TENTE NOVAMENTE!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            if (dgvCesta.Rows.Count > 0)
            {
                DialogResult R1 = MessageBox.Show("AINDA EXISTEM ITENS DENTRO DO CARRINHO! \n\n" +
                "SE SAIR AGORA TODOS OS ITENS ESCOLHIDOS SE PERDERÃO!\n\n" +
                "TEM CERTEZA DE QUE QUER SAIR?",
                "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R1 == DialogResult.Yes)
                {
                    if (Program.UsuarioLogado.NivelAcess != 1)
                    {
                        LimparTudo();
                        this.Hide();
                        new ScreenLogin().ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                    return;
            }
            else
            {
                if (MessageBox.Show("Fechar janela?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (Program.UsuarioLogado.NivelAcess != 1)
                    {
                        LimparTudo();
                        this.Close();
                        new ScreenLogin().ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        #endregion

        //  BOTÃO BUSCAR PELO CÓDIGO
        private void ttbBuscarProd_Click(object sender, EventArgs e)
        {
            if (!CamposDeBuscaValidos())
            {
                return;
            }
            OcultarCampos();

            if (string.IsNullOrEmpty(ttbQtd.Text))
            {
                MessageBox.Show("\n O CAMPO QUANTIDADE NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(ttbQtd.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("NO CAMPO QUANTIDADE NÃO PODE CONTER SÍMBOLOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbQtd.Focus();
                return;
            }
            if (Regex.IsMatch(ttbQtd.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("NO CAMPO QUANTIDADE NÃO PODE CONTER LETRAS ALFABÉTICAS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(ttbCodProd.Text))
            {
                MessageBox.Show("O CAMPO CÓDIGO DO PRODUTO NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (ttbCodProd.Text.Contains(" "))
            {
                MessageBox.Show("\n O CAMPO CÓDIGO DO PRODUTO NÃO PODE CONTER ESPAÇOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (Regex.IsMatch(ttbCodProd.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("NO CAMPO CÓDIGO DO PRODUTO NÃO PODE CONTER SÍMBOLOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            else
            {
                if (CamposDeBuscaValidos())
                {
                    DataTable dtQtdEstoque = new ProdutoController().BuscarProdPorCodigo(Convert.ToInt32(ttbCodProd.Text));
                    ttbQtd.Focus();

                    if (dtQtdEstoque.Rows.Count > 0)
                    {
                        // ENCONTROU PROD DISPONÍVEL NO ESTOQUE
                        ProdutoOutput objProdCesta = new ProdutoOutput(
                        Convert.ToInt32(dtQtdEstoque.Rows[0]["IdProd"]),
                                        dtQtdEstoque.Rows[0]["NomeProd"].ToString(),
                        Convert.ToInt32(dtQtdEstoque.Rows[0]["CodProd"]),
                      Convert.ToDecimal(dtQtdEstoque.Rows[0]["Preco"]),
                        Convert.ToInt32(dtQtdEstoque.Rows[0]["Qtd"]));

                        lbQtdDisponivel.Text = Convert.ToString(objProdCesta.QtdProduto);

                        ttbNomeProd.Text = objProdCesta.NomeProd.ToString();

                        MostraCamposDeBusca();
                        btNVender.Enabled = true;

                        byte[] foto = (byte[])dtQtdEstoque.Rows[0]["Foto"];
                        using (MemoryStream ms = new MemoryStream(foto))
                        {
                            pctProd.Image = Image.FromStream(ms);
                        }

                        int Qtd = 0;
                        int.TryParse(ttbQtd.Text, out Qtd);

                        DataTable dtProd = new DataTable();
                        ProdutoController ctrProd = new ProdutoController();
                        dtProd = ctrProd.BuscarProd();

                        dgvCatalogo.DataSource = dtProd;

                        lbQtdDisponivel.Text = Convert.ToString(objProdCesta.QtdProduto);

                        // MOSTRA A QTD DISPONÍVEL EM ESTOQUE
                        lbIdProd.Text = objProdCesta.IdProd.ToString();

                        //PEGA O VALOR DO PRODUTO
                        ttbPreco.Text = Convert.ToString(objProdCesta.Preco);

                        //MULTIPLICA O PREÇO PELA QTD SOLICITADA
                        //-------------------------------------------------------------

                        decimal RS = Convert.ToDecimal(ttbPreco.Text);
                        // qtd = 0;
                        int qtd = Convert.ToInt32(Qtd);

                        decimal Subtotal = RS * qtd;                // OPERAÇÃO de MULTIPLICAÇÃO

                        // GERA O SUBTOTAL
                        ttbTotal.Text = Convert.ToString(Subtotal);
                        //-------------------------------------------------------------

                        // TRAS A FATURA TOTAL DAS VENDAS E EXIBE ESTE VALOR DE ACORDO O FILTRO NA CONTROLLER
                        decimal subTotal = new ProdutoController().BuscarSubTotalDaVenda();

                        lbValorFinal.Text = Convert.ToString(subTotal);

                        ttbTotal.Enabled = false;
                        ttbPreco.Enabled = false;
                        ttbDesc.Enabled = true;

                        DataTable dtDados = new EstoqueController().BuscarEstoque();

                        for (int linhas = 0; linhas < dtDados.Rows.Count; linhas++)
                        {
                            if (lbIdProd.Text == dtDados.Rows[linhas]["IdProd"].ToString())
                            {
                                int qtdDisp = 0;
                                int.TryParse(lbQtdDisponivel.Text, out qtdDisp);

                                qtdDisp = Convert.ToInt32(objProdCesta.QtdProduto);
                                int disponivel = 0;
                                disponivel = Convert.ToInt32(qtdDisp);
                                int solicitado = 0;
                                solicitado = Convert.ToInt32(qtd);
                                // string nomeProd = ttbNomeProd.Text;

                                if (ttbQtd.Text == Convert.ToString(0) || ttbQtd.Text == "")
                                {
                                    MessageBox.Show("A QUANTIDADE NÃO PODE SER ZERO!\n\n" +
                                    "INSIRA UMA QUANTIDADE VÁLIDA E TENTE NOVAMENTE",
                                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                if (disponivel < solicitado)
                                {
                                    if (disponivel > 0)
                                    {
                                        MessageBox.Show("DISPONÍVEL EM ESTOQUE:  [  " + disponivel + "  ] UNIDADE (S).\n\n" +
                                        "" + "LEVE:  [  " + disponivel + "  ]  AGORA \n\n" +
                                        "SOLICITE SER NOTIFICADO QUANDO O PRODUTO CEHGAR!",
                                        "REDUZA A QUANTIDADE SOLICITADA!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        btNVender.Enabled = false;
                                        ttbQtd.Enabled = true;
                                        return;
                                    }
                                    else
                                    {
                                        var prodEstoque = new Estoque(0, Convert.ToInt32(lbIdProd.Text), Convert.ToInt32(ttbQtd.Text));
                                        var colab = new Colaborador(Program.UsuarioLogado.IdColab);
                                        Assinantes ass = new Assinantes(0, colab.IdColab, prodEstoque.IdProd);

                                        btNVender.Enabled = false;
                                        DialogResult R1 = MessageBox.Show("CARO COLABORADOR (A) [   " + Program.UsuarioLogado.NomeColab.ToUpper() +
                                        "   ] ESTE PRODUTO ESTÁ EM FALTA NO MOMENTO!\n\n" +
                                        "DESEJA RECEBER UMA NOTIFICAÇÃO QUANDO ESTE PRODUTO CHEGAR?",
                                        "PRODUTO EM FALTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (R1 == DialogResult.Yes)
                                        {
                                            bool notificado = ass.Gravar();     //     <------------------------------------ O REGISTRO DO ASSINANTE ACONTECE AQUI

                                            if (notificado)
                                            {
                                                MessageBox.Show("SOLICITAÇÃO REGISTRADA!\n\nASSIM QUE O PRODUTO CHEGAR ENVIAREMOS UMA NOTIFICAÇÃO!",
                                                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return;
                                            }
                                            else
                                                MessageBox.Show("NÃO FOI POSSÍVEL REGISTRAR A NOTIFICAÇÃO!",
                                                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        if (objProdCesta.QtdProduto > 10 && objProdCesta.QtdProduto < 50)
                        {
                            btNVender.Enabled = true;
                            MessageBox.Show("NÃO DEIXE SEUS CLIENTES ESPERANDO!\n\n" +
                            "SOLICITE REPOSIÇÃO IMEDIATA AO SEU FORNECEDOR!", "\n\n" +
                            "ESTADO DA QUANTIDADE CHEGANDO AO NÍVEL CRÍTICO DE ABASTECIMENTO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbUrgente.Visible = true;
                        }
                        else
                        if (objProdCesta.QtdProduto < 10)
                        {
                            btNVender.Enabled = true;
                            MessageBox.Show("O ESTADO CRÍTICO DA QUANTIDADE DESTE ITEM PODE DEIXA-LO SEM ESTOQUE!",
                            "SOLICITE REPOSIÇÃO IMEDIATA AO SEU FORNECEDOR!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbUrgente.Visible = true;
                            lbQtdDisponivel.Text = Convert.ToString(objProdCesta.QtdProduto);
                        }
                    }
                    else
                    {
                        btNVender.Enabled = false;  //     <-------------------------------------------------------------------- CLIQUEI NA LUPA, A QTD ERA ZERO, CAIU AQUI
                        DialogResult R1 = MessageBox.Show("CARO COLABORADOR [ " + Program.UsuarioLogado.NomeColab +
                        " ] SENTIMOS MUITO, MAS ESTE PRODUTO ESTÁ EM FALTA NO MOMENTO!\n\n" +
                        "CASO O PRODUTO JÁ TENHA CHEGADO,\n\nDESEJA DISPONIBILIZAR ESTE PRODUTO EM ESTOQUE AGORA?",
                        "PRODUTO EM FALTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (R1 == DialogResult.Yes)
                        {
                            if (lbNivelAccesUsuarioLogado.Text != "3")
                            {
                                new TelaCadastroQtd().ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                DialogResult R3 = MessageBox.Show("DESEJA INSERIR AS CREDENCIAIS PARA TER ACESSO A ESTA OPERAÇÃO?",
                                "CREDENCIAIS NECESSARÁRIAS!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (R3 == DialogResult.Yes)
                                {
                                    new TelaSenhaAutorizacao().ShowDialog();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            DialogResult R2 = MessageBox.Show("DESEJA RECEBER UMA NOTIFICAÇÃO NA TELA QUANDO ESTE PRODUTO CHEGAR?",
                            "SEJA NOTIFICADO QUANDO O PRODUTO CHEGAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (R2 == DialogResult.Yes)
                            {
                                var listaProdutos = new NotificarController().BuscarProdutoNotificacao(Program.UsuarioLogado.IdColab);

                                if (listaProdutos.Count > 0)
                                {
                                    string mensagem = "COLABORADOR:   " + Program.UsuarioLogado.NomeColab.ToUpper() + "   SUA ESPERA TERMINOU!\n" +
                                    "O PRODUTO SELECIONADO ESTÁ DISPONIVEL EM NOSSA LOJA ENQUANTO DURAR O ESTOQUE";
                                    string produtos = "";

                                    foreach (var item in listaProdutos)
                                        produtos += "\n" + item.NomeProd.ToString();
                                    DialogResult dr = MessageBox.Show(mensagem + produtos + "\n" +
                                    "DESEJA VER ESTA LISTA DE NOTIFICAÇÕES NOVAMENTE?", "NOTIFICAÇÕES",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (dr == DialogResult.No)
                                    {
                                        //Limpar a lista de notificação
                                        new NotificarController().RemoverNotificacoes(Program.UsuarioLogado.IdColab, listaProdutos);

                                        //Inativar o botão de ver notificações
                                    }
                                    else
                                        return;
                                }
                            }
                        }
                    }
                }
            }
        }
        // CÁLCULO DO DESCONTO
        #region 

        private void ttbSubtrairQtd_Click(object sender, EventArgs e)
        {
            if (ttbCodProd.Text != "")
            {
                ttbQtd.Text = Convert.ToString(campoQtd--);

                int qtd = 0;
                decimal preco = 0m;
                decimal totalOK = 0m;
                decimal total = 0m;
                decimal ValorFinal = 0m;
                if (ttbNomeProd.Text == "")
                {
                    MessageBox.Show("APÓS INSERIR O CÓDIGO DO PRODUTO, \n" +
                    "VOCÊ DEVE PESQUISÁ-LO CLICANDO NA LUPA!\n\n" +
                    "A LUPA ESTÁ LOGO ABAIXO DO SINAL [ + ] \n",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (Convert.ToInt32(ttbQtd.Text) > 0)
                {
                    preco = Convert.ToDecimal(ttbPreco.Text);
                    qtd = Convert.ToInt32(ttbQtd.Text);

                    total = preco * qtd;           // OPERAÇÃO de MULTIPLICAÇÃO

                    ttbTotal.Text = total.ToString();

                    decimal.TryParse(ttbTotal.Text, out totalOK);

                    if (lbValorFinal.Text != "")
                    {
                        ValorFinal = Convert.ToDecimal(lbValorFinal.Text) + totalOK;
                        lbValorFinal.Text = ValorFinal.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("O CAMPO QUANTIDADE NÃO PODE SER VAZIO!",
                    "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("O CAMPO CÓDIGO DO PRODUTO NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion
        //  BOTÃO VENDER [ SEM ] E [ COM ] DESCONTO
        #region

        bool vendaOK = false;
        bool debitouEstoqueOK = false;
        bool itemVendaOK = false;
        bool itensOK = false;
        bool pgto = false;
        int iten2 = 0;
        int iten3 = 0;
        int numNotFisc = 0; // SERIALIZA NOTA FISCAL
        int numVenda = 0; // SERIALIZA VENDA

        private void SerializaCod()
        {
            numNotFisc++;
            if (numNotFisc != 0)
            {
                DataTable dtNota = new VendaController().BuscarVenda();
                int maiorNota = 0;
                for (int i = 0; i < dtNota.Rows.Count; i++)
                {
                    int codAtual = Convert.ToInt32(dtNota.Rows[i]["NumNotaFisc"]);
                    if (codAtual > maiorNota)
                    {
                        maiorNota = codAtual;
                    }
                }// OS CÓDIGOS DOS PRODUTOS SERÃO SERIALIZADOS DE 1 EM 1
                int novaNota = maiorNota + 1;
                lbNotaFiscal.Text = novaNota.ToString();
            }
        }

        private void SerializaNF() // O MÉTODO SerializaCod() É SIMILAR A ESTE MAS NÃO UTILIZEI ELE NESTE CASO PQ, PREVENDO A ESCALABILIDADE DO CÓDIGO FUTURAMENTE
        {                          // PODEREI REALIZAR MODIFICAÇÕES QUE PODEM COMPROMETER A SERIALIZAÇÃO DA NOTA
            numVenda++;
            if (numVenda != 0)
            {
                DataTable dtVenda = new VendaController().BuscarVenda();
                int ultimaVenda = 0;
                for (int i = 0; i < dtVenda.Rows.Count; i++)
                {
                    int vendaAtual = Convert.ToInt32(dtVenda.Rows[i]["NumNotaFisc"]);
                    if (vendaAtual > ultimaVenda)
                    {
                        ultimaVenda = vendaAtual;
                    }
                }// AS NOTAS FISCAIS SERÃO SERIALIZADAS DE 1 EM 1
                int novaVenda = ultimaVenda + 1;
                lbSerializaVenda.Text = novaVenda.ToString();
            }
        }

        private void btNVender_Click(object sender, EventArgs e)
        {
            if (ttbDin.Text != "" || ttbCred.Text != "" || ttbDeb.Text != "" || ttbPix.Text != "")
            {
                SerializaCod();
                SerializaNF();

                int IdColab = 0;
                int.TryParse(lbIdColab.Text, out IdColab);
                int NF = 0;
                int.TryParse(lbNotaFiscal.Text, out NF);
                int NumSerieIdVenda = 0;
                int.TryParse(lbSerializaVenda.Text, out NumSerieIdVenda);
                int IdProd = 0;
                int.TryParse(lbIdProd.Text, out IdProd);
                int Qtd = 0;
                int.TryParse(ttbQtd.Text, out Qtd);
                int CodColab = 0;
                int.TryParse(ttbCodColab.Text, out CodColab);
                decimal Desc = 0m;
                decimal.TryParse(ttbDesc.Text, out Desc);
                decimal SubTot = 0m;
                decimal.TryParse(ttbTotal.Text, out SubTot);
                decimal Din = 0m;
                decimal.TryParse(ttbDin.Text, out Din);
                decimal Deb = 0m;
                decimal.TryParse(ttbDeb.Text, out Deb);
                decimal Cred = 0m;
                decimal.TryParse(ttbCred.Text, out Cred);
                decimal Pix = 0m;
                decimal.TryParse(ttbPix.Text, out Pix);
                decimal ValFin = 0m;
                decimal.TryParse(ttbValFin.Text, out ValFin);
                decimal Bruto = 0m;
                decimal Troco = 0m;
                decimal Resto = 0m;

                if (ttbDin.Text.Contains(" "))
                {
                    MessageBox.Show("\n O CAMPO DINHEIRO NÃO PODE CONTER ESPAÇOS!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbDin.Focus();
                    return;
                }
                else if (ttbCred.Text.Contains(" "))
                {
                    MessageBox.Show("O CAMPO CRÉDITO NÃO PODE CONTER ESPAÇOS!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbCred.Focus();
                    return;
                }
                else if (ttbDeb.Text.Contains(" "))
                {
                    MessageBox.Show("\n O CAMPO DÉBITO NÃO PODE CONTER ESPAÇOS!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbDeb.Focus();
                    return;
                }
                else if (ttbPix.Text.Contains(" "))
                {
                    MessageBox.Show("\n O CAMPO Pix NÃO PODE CONTER ESPAÇOS!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbPix.Focus();
                    return;
                }

                if (dgvCesta.Rows.Count > 0)
                {
                    Bruto = (Din + Desc + Deb + Cred + Pix);
                    Resto = (ValFin % Bruto);

                    if (Bruto >= ValFin)
                    {
                        Troco = (Bruto - ValFin);
                        if (TemEntradasValidas())
                        {
                            // CONVERTENDO OS DADOS PARA O CORRETO FORMATO
                            lbIdColab.Text = Convert.ToString(Program.UsuarioLogado.IdColab);
                            lbCodProd.Text = dgvCatalogo.CurrentRow.Cells[2].Value.ToString();
                            lbIdProd.Text = dgvCatalogo.CurrentRow.Cells[0].Value.ToString();

                            OcultarCampos();
                            DataTable busca = new DataTable();

                            ColaboradorController colabCtr = new ColaboradorController();
                            busca = colabCtr.BuscarColabPorCod(ttbCodColab.Text);

                            lbCodColab.Text = Convert.ToString(Program.UsuarioLogado.CodColab);
                            EstoqueController estoqueController = new EstoqueController();

                            iten2++;
                            iten3++;

                            //  PARA CONSTRUTORES ANTIGOS ANTES DE TER ADICIONADO A DATA
                            #endregion

                            decimal ValTot = (Din + Deb + Cred + Pix - Desc);
                            decimal pgto = (ValFin - Desc);

                            // VENDER [ SEM ] DESCONTO
                            if (Resto == 0)
                            {
                                lbAindaFaltam1.Visible = false;
                                lbAindaFaltam2.Visible = false;
                                MessageBox.Show("\n\nVALOR EM DINHEIRO  R$  " + Din + " (+)\n" +
                                "\nVALOR EM CRÉDITO  R$  " + Cred + " (+)\n" +
                                "\nVALOR EM DÉBITO  R$  " + Deb + " (+)\n" +
                                "\nVALOR EM Pix  R$  " + Pix + " (+)\n" +
                                "\nVALOR DO DESCONTO R$  " + Desc + "(-)\n" +
                                "\nSUBTOTAL R$  " + Bruto + "\n" +
                                "\n_____________________________________\n" +
                                "\nTOTAL DO PAGAMENTO  R$  " + pgto +
                                "\n---------------------------------------------",
                                "CONFERÊNCIA DOS VALORES!", // Linha de baixo
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            if (Troco != 0)
                            {
                                MessageBox.Show("\n\nTROCO R$ " + Troco + " \n\n SEPARE O TROCO E REPASSE-O AO CLIENTE!",
                                "AGUARDE O TROCO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            if (ttbDesc.Text == "")
                            {
                                if (Program.Cesta.Count > 0)
                                {
                                    if (ttbCred.Text != "" && rdbAmex.Checked == true || rdbDiners.Checked == true ||
                                                              rdbElo.Checked == true || rdbHiper.Checked == true ||
                                                              rdbMaster.Checked == true || rdbVisa.Checked == true)
                                    {
                                        
                                        TelaParcelas telaParcelas = new TelaParcelas(
                                        Cred, rdbMaster.Checked, rdbElo.Checked, rdbHiper.Checked, rdbDiners.Checked, rdbAmex.Checked);
                                        telaParcelas.ShowDialog();
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Selecione a Bandeira do Cartão!",
                                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }

                                    //    OBJETO VENDA
                                    Venda objVenda = new Venda(0, NF, CodColab, 0, ValTot, IdColab, Desc, Din, Deb, Cred, Pix);
                                    // PEGA A DATA
                                    objVenda.Data = DateTime.Now;
                                    int idVenda = objVenda.Gravar();

                                    //    OBJETO ITENS------------------------
                                    Itens objItens = new Itens(0, idVenda, iten3); // <--- VER A UTILIDADE DESTES 2 PARÂMETROS
                                    int IdIten = objItens.GravarItens(objItens);

                                    foreach (ItemVenda item in Program.Cesta)
                                    {
                                        //    OBJETO ITEMVENDA---------------------------------------------------------------------
                                        ItemVenda objItemVenda = new ItemVenda(0, NumSerieIdVenda, item.Nome, item.IdProd, item.Qtd, item.SubTotal, IdIten, item.IdColab);
                                        itemVendaOK = objItemVenda.GravarItemVenda();

                                        //    OBJETO ESTOQUE-------------------------------------------------------------
                                        Estoque objEstoque = new Estoque(0, IdProd, Qtd);
                                        debitouEstoqueOK = estoqueController.DebitarItensDoEstoque2(item.IdProd, item.Qtd); // MÉTODO  SUB-SELECT
                                    }

                                    if (debitouEstoqueOK && itemVendaOK)
                                    {
                                        DataTable dtProd = new DataTable();
                                        ProdutoController ctrProd = new ProdutoController();
                                        dtProd = ctrProd.BuscarProd();

                                        if (MessageBox.Show("VENDA [   SEM DESCONTO   ] REALIZADA COM SUCESSO!\n\n" +
                                            "DESEJA REALIZAR OUTRA OPERAÇÃO?", "VENDA REALIZADA!",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            LimparTudo();
                                            OcultarCampos();
                                            MostrarBandeiras();
                                            ttbQtd.Text = "1";
                                            ttbCodProd.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            this.Hide();
                                            new ScreenLogin().ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("NÃO GRAVOU ITENS!\n",
                                        "ERRO EM ITENS_CONTROLLER!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                MessageBox.Show("NÃO FORAM ENCONTRADOS ITENS NO CARRINHO!\n",
                                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                                // VENDER [ COM ] DESCONTO
                                #region
                            }
                            else
                            {
                                if (Program.UsuarioLogado.NivelAcess == 1)
                                {
                                    //    OBJETO VENDA
                                    Venda objVenda = new Venda(0, NF, CodColab, 0, ValTot, IdColab, Desc, Din, Deb, Cred, Pix);
                                    // PEGA A DATA
                                    objVenda.Data = DateTime.Now;
                                    int idVenda = objVenda.Gravar();

                                    //    OBJETO ITENS------------------------
                                    Itens objItens = new Itens(0, idVenda, iten3); // <--- VER A UTILIDADE DESTES 2 PARÂMETROS
                                    int IdIten = objItens.GravarItens(objItens);

                                    foreach (ItemVenda item in Program.Cesta)
                                    {
                                        ItemVenda objItemVenda = new ItemVenda(0, NumSerieIdVenda, item.Nome, item.IdProd, item.Qtd, item.SubTotal, IdIten, item.IdColab);
                                        itemVendaOK = objItemVenda.GravarItemVenda();

                                        //    OBJETO ESTOQUE-------------------------------------------------------------
                                        Estoque objEstoque = new Estoque(0, IdProd, Qtd);
                                        debitouEstoqueOK = estoqueController.DebitarItensDoEstoque2(item.IdProd, item.Qtd); // MÉTODO  SUB-SELECT
                                    }

                                    if (debitouEstoqueOK && itemVendaOK)
                                    {
                                        DataTable dtProd = new DataTable();
                                        ProdutoController ctrProd = new ProdutoController();
                                        dtProd = ctrProd.BuscarProd();

                                        if (MessageBox.Show("VENDA [    COM DESCONTO    ] REALIZADA COM SUCESSO!\n\n" +
                                            "DESEJA REALIZAR OUTRA OPERAÇÃO?", "VENDA REALIZADA!",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            LimparTudo();
                                            OcultarCampos();
                                            MostrarBandeiras();
                                            ttbQtd.Text = "1";
                                            return;
                                        }
                                        else
                                        {
                                            this.Hide();
                                            new ScreenLogin().ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("NÃO GRAVOU ITENS!\n",
                                        "ERRO EM ITENS_CONTROLLER!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    return;
                                }
                                else
                                {
                                    MostrarCampos();
                                    ttbLoginAuto.Focus();
                                    DataTable dados = new AutorizacaoController().BuscarAutorizacao(ttbLoginAuto.Text);
                                    if (dados.Rows.Count > 0)
                                    {
                                        string senhaDigitada = ttbSenhaAuto.Text.ToLower();
                                        string loginDigitado = ttbLoginAuto.Text.ToLower();
                                        for (int i = 0; i < dados.Rows.Count; i++)
                                        {
                                            string senhaArmazenada = dados.Rows[i]["Senha"].ToString().ToLower();
                                            string loginArmazenado = dados.Rows[i]["Login"].ToString().ToLower();
                                            if (senhaArmazenada == senhaDigitada && loginArmazenado == loginDigitado)
                                            {
                                                Program.UsuarioAutorizado = new Autorizacao(
                                                Convert.ToInt32(dados.Rows[i]["IdAut"].ToString()),
                                                dados.Rows[i]["Login"].ToString(),
                                                dados.Rows[i]["Senha"].ToString());

                                                lbCodColab.Text = Convert.ToString(Program.UsuarioLogado.CodColab);

                                                //    OBJETO VENDA
                                                Venda objVenda = new Venda(0, CodColab, 0, ValTot, IdColab, Desc, Din, Deb, Cred, Pix);
                                                // PEGA A DATA
                                                objVenda.Data = DateTime.Now;
                                                int idVenda = objVenda.Gravar();

                                                //    OBJETO ITENS------------------------
                                                Itens objItens = new Itens(0, idVenda, iten3); // <--- VER A UTILIDADE DESTES 2 PARÂMETROS
                                                int IdIten = objItens.GravarItens(objItens);

                                                foreach (ItemVenda item in Program.Cesta)
                                                {
                                                    ItemVenda objItemVenda = new ItemVenda(0, NumSerieIdVenda, item.Nome, item.IdProd, item.Qtd, item.SubTotal, IdIten, item.IdColab);
                                                    itemVendaOK = objItemVenda.GravarItemVenda();

                                                    //    OBJETO ESTOQUE-------------------------------------------------------------
                                                    Estoque objEstoque = new Estoque(0, IdProd, Qtd);
                                                    debitouEstoqueOK = estoqueController.DebitarItensDoEstoque2(item.IdProd, item.Qtd); // MÉTODO  SUB-SELECT
                                                }

                                                if (debitouEstoqueOK && itemVendaOK)
                                                {
                                                    DataTable dtProd = new DataTable();
                                                    ProdutoController ctrProd = new ProdutoController();
                                                    dtProd = ctrProd.BuscarProd();

                                                    if (MessageBox.Show("VENDA [    COM DESCONTO    ] REALIZADA COM SUCESSO!\n\n" +
                                                        "DESEJA REALIZAR OUTRA OPERAÇÃO?", "VENDA REALIZADA!",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                                    {
                                                        LimparTudo();
                                                        OcultarCampos();
                                                        MostrarBandeiras();
                                                        ttbQtd.Text = "1";
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        this.Hide();
                                                        new ScreenLogin().ShowDialog();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("NÃO GRAVOU ITENS!\n",
                                                    "ERRO EM ITENS_CONTROLLER!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    return;
                                                }
                                                return;
                                            }
                                            else
                                            {
                                                MessageBox.Show("DIGITE AS CREDENCIAIS DE ACESSO!", "CONSULTAR AUTORIZAÇÃO!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                return;
                                            }
                                        }
                                    }
                                    else
                                        MessageBox.Show("AINDA NÃO EXISTEM AUTORIZAÇÕES CADASTRADAS!", "ATENÇÃO!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        decimal FaltaDinheiro = 0m;
                        if (ValFin > Bruto)
                        {
                            FaltaDinheiro = Resto;
                            lbAindaFaltam2.Text = FaltaDinheiro.ToString();
                            lbAindaFaltam1.Visible = true;
                            lbAindaFaltam2.Visible = true;

                            MessageBox.Show("\n\nATENÇÃO!\n\n" +
                            "_____________________________________________________________\n\n" +
                            "AINDA FALTAM R$    " + FaltaDinheiro + "   À RECEBER DO CLIENTE! " +
                            "\n_____________________________________________________________\n\n" +
                            "AGUARDE O RESTANTE DO PAGAMENTO! ! !",
                            "FALTA DINHEIRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("PARECE QUE AINDA NÃO HÁ ITENS NO CARRINHO!\n\n" +
                    "VERIFIQUE ISTO E TENTE NOVAMENTE!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("VOCÊ PRECISA INSERIR PELO MENOS UMA DAS FORMAS DE PAGAMENTO QUE OFERECEMOS!\n\n" +
                "SÃO ELAS: CRÉDITO, DÉBITO, PIX ou DINHEIRO.",
                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ttbDin.Focus();
                return;
            }
        }
        #endregion

        //  BOTÕES: VALIDAR AUTORIZAÇÃO E AUTORIZAR
        #region

        private void ValidarAutorizacao()
        {
            // BUSCANDO AUTORIZAÇÃO
            DataTable dt = new AutorizacaoController().BuscarAutorizacao(ttbLoginAuto.Text);
            if (dt.Rows.Count > 0)
            {
                string senhaDigitada = ttbSenhaAuto.Text.ToLower();
                string loginDigitado = ttbLoginAuto.Text.ToLower();
                bool permissaoOK = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string loginArmazenado = dt.Rows[i]["Login"].ToString().ToLower();
                    string senhaArmazenada = dt.Rows[i]["Senha"].ToString().ToLower();
                    if (senhaArmazenada == senhaDigitada && loginArmazenado == loginDigitado)
                    {
                        permissaoOK = true;// AUTORIZAÇÃO CONCEDIDA

                        new Autorizacao(
                        Convert.ToInt32(dt.Rows[i]["IdAut"].ToString()),
                        dt.Rows[i]["Login"].ToString(),
                        dt.Rows[i]["Senha"].ToString());

                        if (permissaoOK == true)
                        {
                            MessageBox.Show("CLIQUE EM [ VENDER ] PARA FINALIZAR A VENDA!",
                            "VENDA AUTORIZADA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            decimal Desc = 0m;
                            decimal.TryParse(ttbDesc.Text, out Desc);
                            decimal SubTot = 0m;
                            decimal.TryParse(ttbTotal.Text, out SubTot);

                            decimal ValComDesc = (SubTot - Desc);           // OPERAÇÃO DE DESCONTO ACONTECE AQUI
                            ttbTotal.Text = Convert.ToString(ValComDesc);

                            btNAutorizar.Visible = false;

                            btNAlterar.Enabled = true;
                            btNExcluir.Enabled = true;
                            lbPermissao.Text = Convert.ToString(1);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("ESTA CREDENCIAL NÃO ESTÁ CADASTRADA!\n" +
                            "CONSULTE O ADMINISTRADOR E TENTE NOVAMENTE!", "ATENÇÃO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (senhaArmazenada != senhaDigitada)
                    {
                        MessageBox.Show("SENHA INVÁLIDA! CONSULTE SUAS CREDENCIAIS E TENTE NOVAMENTE!",
                        "VERIFIQUE SUAS ANOTAÇÕES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (loginArmazenado != loginDigitado)
                    {
                        MessageBox.Show("LOGIN INVÁLIDO! CONSULTE SUAS CREDENCIAIS E TENTE NOVAMENTE!",
                        "VERIFIQUE SUAS ANOTAÇÕES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("AINDA NÃO FOI CRIADA NENHUMA SENHA!\n\n" +
                "SOLICITE AO ADMINISTRADOR DO SISTEMA A CRIAÇÃO DE UMA CREDENCIAL DE ACESSO: LOGIN E SENHA DE ACESSO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btNAutorizar_Click(object sender, EventArgs e)
            => ValidarAutorizacao();
        #endregion
        private void btNAlterar_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            if (lbPermissao.Text == Convert.ToString(1))
            {
                if (TemEntradasValidas())
                {
                    Produto prod = new Produto(
                    Convert.ToInt32(lbIdProd.Text),
                    ttbNomeProd.Text,
                    Convert.ToInt32(ttbCodProd.Text),
                    decimal.Parse(ttbPreco.Text));

                    bool ok = prod.Alterar();

                    if (ok)
                    {
                        MessageBox.Show("REGISTRO ALTERADO COM SUCESSO!", "REGISTRO ALTERADO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCatalogo.DataSource = new ProdutoController().BuscarProd();
                        lbPermissao.Text = Convert.ToString(0);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("ERRO AO ALTERAR REGISTRO NO BANCO DE DADOS!\nTENTE NOVAMENTE!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("VERIFIQUE SUAS CREDENCIAIS E TENTE NOVAMENTE!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btNLimparCarrinho_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA DE QUE DESEJA CANCELAR ESTA VENDA?\n\n" +
            "ESTA AÇÃO EXCLUIRÁ TODOS OS PRODUTOS SELECIONADOS PERMANENTEMENTE!",
            "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                LimparTudo();
            else
                return;
        }
        private static List<ItemVenda> Carrinho = new List<ItemVenda>();

        // VARIÁVEL QUE ARMAZENA O VALOR FINAL TOTAL DA COMPRA DO CARRINHO
        // DEVE FICAR FORA DO ESCOPO DO EVENTO DO BOTÃO ttbAdicionar_Click
        //
        //
        //
        decimal subtotalTOTAL = 0m;
        //
        //
        //  CASO CONTRÁRIO, TODA VEZ ELA SERÁ ZERADA, "REINICIALIZADA" PELO EVENTO Click
        //__________________________________________________________________

        // ADICIONA MAIS QUANTIDADE
        private void btNAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbIdProd.Text) && !string.IsNullOrEmpty(ttbCodProd.Text) &&
                !string.IsNullOrEmpty(ttbQtd.Text) && !string.IsNullOrEmpty(ttbPreco.Text) &&
                !string.IsNullOrEmpty(ttbTotal.Text))
            {
                DataTable dtQtdEstoque = new ProdutoController().BuscarProdPorCodigo(Convert.ToInt32(ttbCodProd.Text));

                if (dtQtdEstoque.Rows.Count > 0)
                {
                    int maisQtd = 0;
                    maisQtd = Convert.ToInt32(ttbQtd.Text.ToString());

                    if (MessageBox.Show("ADICIONAR  + " + maisQtd + " ITEN (S) AO CARRINHO?", "ADICIONAR ITEM AO CARRINHO!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(lbIdProd.Text) &&
                            !string.IsNullOrEmpty(ttbQtd.Text) &&
                            !string.IsNullOrEmpty(ttbTotal.Text))
                        {
                            int idProd = 0;
                            int.TryParse(lbIdProd.Text, out idProd);
                            int.TryParse(ttbQtd.Text, out maisQtd);
                            decimal subTotal = 0m;
                            decimal.TryParse(ttbTotal.Text, out subTotal);
                            int idColab = 0;
                            lbIdColab.Text = Convert.ToString(Program.UsuarioLogado.IdColab);
                            int.TryParse(lbIdColab.Text, out idColab);
                            // OBJETO ITEMVENDA PARA A LISTA ItemVenda DO MÉTODO CESTA_PROD()
                            ItemVenda itemVenda = new ItemVenda(0, ttbNomeProd.Text, idProd, maisQtd, subTotal, 0, idColab);
                            // ADICIONA ITEM AO CARRINHO
                            Program.Cesta.Add(itemVenda);
                            // ATUALIZA O dgvCesta COM OS DADOS DO CARRINHO "LISTA"
                            dgvCesta.DataSource = null;
                            dgvCesta.DataSource = Program.Cesta;

                            subtotalTOTAL += subTotal; // ATUALIZA O TOTAL À PAGAR
                            ttbValFin.Text = Convert.ToString(subtotalTOTAL);
                            campoQtd = 1;
                            LimparCamposDeConsulta();
                            ttbCodProd.Focus();
                            ttbQtd.Text = "1";
                            // Se a foto ilustrativa estiver vazia preencha-a
                            if (pctProd.Image == null)
                            {
                                // Caminho da imagem fixa
                                string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\materiaisX.PNG";
                                // Verifica se o arquivo existe no endereço acima citado
                                if (File.Exists(caminhoImagemIlustrativa))
                                {
                                    // Carrega a imagem a partir do caminho mencionado na string acima
                                    Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);
                                    // Atribui a imagem ao nome de domínio da picture definida
                                    pctProd.Image = imagemIlustrativa;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ANTES DE ADICIONAR ITENS AO CARRINHO VOCÊ DEVE BUSCÁ-LOS CLICANDO NA LUPA!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //ADICIONAR UMA IMAGEM GIF BRILHOSA AQUI APONTANDO PARA A LUPA
                return;
            }
        }

        int campoQtd = 1;
        private void ttbAumentarQtd_Click(object sender, EventArgs e)
        {
            ttbQtd.Text = Convert.ToString(campoQtd++);
            if (Regex.IsMatch(ttbCodProd.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("NO CAMPO CÓDIGO NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (ttbCodProd.Text.Contains(" "))
            {
                MessageBox.Show("\n O CAMPO CÓDIGO NÃO PODE CONTER ESPAÇOS VAZIOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (Regex.IsMatch(ttbCodProd.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("NO CAMPO CÓDIGO NÃO PODE CONTER SÍMBOLOS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (Regex.IsMatch(ttbCodProd.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("NO CAMPO CÓDIGO NÃO PODE CONTER LETRAS ALFABÉTICAS!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbCodProd.Focus();
                return;
            }
            if (ttbCodProd.Text != "")
            {

                DataTable dtQtdEstoque = new ProdutoController().BuscarProdPorCodigo(Convert.ToInt32(ttbCodProd.Text));

                decimal total = 0m;
                decimal ValorFinal = 0m;
                decimal totalOK = 0m;
                decimal.TryParse(ttbTotal.Text, out totalOK);
                int qtdDisp = 0;
                int.TryParse(lbQtdDisponivel.Text, out qtdDisp);
                int qtdSolicitada = 0;
                int.TryParse(ttbQtd.Text, out qtdSolicitada);
                decimal preco = 0m;

                if (dtQtdEstoque.Rows.Count > 0)
                {
                    int qtdEstoque = 0;
                    // ENCONTROU PROD DISPONÍVEL NO ESTOQUE
                    ProdutoOutput objProdCesta = new ProdutoOutput(
                    Convert.ToInt32(dtQtdEstoque.Rows[0]["IdProd"]),
                                    dtQtdEstoque.Rows[0]["NomeProd"].ToString(),
                    Convert.ToInt32(dtQtdEstoque.Rows[0]["CodProd"]),
                  Convert.ToDecimal(dtQtdEstoque.Rows[0]["Preco"]),
                    Convert.ToInt32(dtQtdEstoque.Rows[0]["Qtd"]));

                    lbQtdDisponivel.Text = Convert.ToString(objProdCesta.QtdProduto);
                    ttbNomeProd.Text = objProdCesta.NomeProd.ToString();
                    qtdEstoque = Convert.ToInt32(dtQtdEstoque.Rows[0]["Qtd"]);
                    ttbPreco.Text = Convert.ToString(dtQtdEstoque.Rows[0]["Preco"]);

                    if (qtdSolicitada > qtdEstoque)
                    {
                        var prodEstoque = new Estoque(0, Convert.ToInt32(lbIdProd.Text), Convert.ToInt32(ttbQtd.Text)); // < --------------------------lbIdProd.Text ESTÁ RECEBENDO "" VAZIO E DANDO ERRO VERIFICAR AQUI
                        var colab = new Colaborador(Program.UsuarioLogado.IdColab);

                        Assinantes ass = new Assinantes(0, colab.IdColab, prodEstoque.IdProd);

                        btNVender.Enabled = false;
                        DialogResult R1 = MessageBox.Show("CARO COLABORADOR (A) [   " + Program.UsuarioLogado.NomeColab.ToUpper() +
                        "   ] ESTE PRODUTO ESTÁ EM FALTA NO MOMENTO!\n\n" +
                        "DESEJA RECEBER UMA NOTIFICAÇÃO QUANDO ESTE PRODUTO CHEGAR?",
                        "PRODUTO EM FALTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (R1 == DialogResult.Yes)
                        {
                            bool notificado = ass.Gravar();     //     <------------------------------------ O REGISTRO DO ASSINANTE ACONTECE AQUI

                            if (notificado)
                            {
                                MessageBox.Show("SOLICITAÇÃO REGISTRADA!\n\nASSIM QUE O PRODUTO CHEGAR ENVIAREMOS UMA NOTIFICAÇÃO!",
                                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                                MessageBox.Show("NÃO FOI POSSÍVEL REGISTRAR A NOTIFICAÇÃO!",
                                "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        if (lbValorFinal.Text != "")
                        {
                            ValorFinal = Convert.ToDecimal(lbValorFinal.Text) + totalOK;
                            lbValorFinal.Text = ValorFinal.ToString();

                            if (ttbPreco.Text != "")
                            {
                                preco = Convert.ToDecimal(ttbPreco.Text);
                                total = preco * qtdSolicitada;           // OPERAÇÃO de MULTIPLICAÇÃO

                                ttbTotal.Text = total.ToString();
                            }
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O CAMPO CÓDIGO DO PRODUTO NÃO PODE SER VAZIO!",
                "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btNTransportar_Click(object sender, EventArgs e)
        {
            if (dgvCesta.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCesta.CurrentRow;
                if (selectedRow != null)
                {
                    lbIdItensVendidos.Text = selectedRow.Cells[0].Value.ToString();
                    ttbNomeProd.Text = selectedRow.Cells[1].Value.ToString();
                    lbIdProd.Text = selectedRow.Cells[2].Value.ToString();
                    ttbQtd.Text = selectedRow.Cells[3].Value.ToString();
                    ttbPreco.Text = selectedRow.Cells[4].Value.ToString();
                    ttbPix.Text = selectedRow.Cells[5].Value.ToString();
                    lbIdColab.Text = selectedRow.Cells[6].Value.ToString();
                }
            }
        }

        private void btNZero_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "0";

        private void btNUm_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "1";

        private void btNDois_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "2";

        private void btNTres_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "3";

        private void btNQuatro_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "4";

        private void btNCinco_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "5";

        private void btNSeis_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "6";

        private void btNSete_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "7";

        private void btNOito_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "8";

        private void btNNove_Click(object sender, EventArgs e)
            => ttbCodProd.Text += "9";

        private void pctOLHO_Click(object sender, EventArgs e)
        {
            if (ttbSenhaAuto.UseSystemPasswordChar == true)
            {
                ttbSenhaAuto.UseSystemPasswordChar = false;
                pctOLHO.Text = "VISUALIZAR";
            }
            else
            {
                ttbSenhaAuto.UseSystemPasswordChar = true;
                pctOLHO.Text = "OCULTAR";
            }
        }

        private void btNNotificar_Click(object sender, EventArgs e)
        {
            var listaParaNotificar = new NotificarController().BuscarProdutoNotificacao(Program.UsuarioLogado.IdColab);
            var adicionarNomeProd = new List<string>();

            foreach (DataGridViewRow row in dgvNotificar.Rows)
            {
                if (row.Cells["NomeColab"].Value != null)
                {
                    var nomeProd = row.Cells["NomeProd"].Value.ToString();
                    adicionarNomeProd.Add("\n" + nomeProd);
                }
            }

            if (listaParaNotificar.Count > 0)
            {
                btNNotificar.Visible = true;
                dgvNotificar.Visible = true;

                string produtosAssinados = "COLABORADOR: " + Program.UsuarioLogado.NomeColab + "\n\n\tSUA ESPERA TERMINOU!\n" +
                "\n\nOS PRODUTOS ABAIXO ESTARÃO DISPONÍVEIS NA LOJA: \n\n\n" +
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
                    btNNotificar.Visible = false;
                    dgvNotificar.Visible = false;
                }
                else
                {
                    btNNotificar.Visible = true;
                    dgvNotificar.Visible = true;
                }
            }
            else
            {
                btNNotificar.Visible = false;
                dgvNotificar.Visible = false;
            }
        }
    }
}
