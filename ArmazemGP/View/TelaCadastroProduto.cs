using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;
using System.Drawing.Imaging;

namespace ArmazemGP.View
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
            DataTable data = new DataTable();
            data = new ProdutoController().BuscarProd();
            dgvProd.DataSource = data;
            OcultarDadosDGV();
            DesaHabilitar();

        }
        private void SerializaCod()
        {
            if (ttbCodProd.Text == "0")
            {
                DataTable dtCod = new ProdutoController().BuscarProd();
                int maiorCod = 0;
                for (int i = 0; i < dtCod.Rows.Count; i++)
                {
                    int codAtual = Convert.ToInt32(dtCod.Rows[i]["CodProd"]);
                    if (codAtual > maiorCod)
                    {
                        maiorCod = codAtual;
                    }
                }// OS CÓDIGOS DOS PRODUTOS SERÃO SERIALIZADOS DE 1 EM 1
                int novoCod = maiorCod + 1;
                ttbCodProd.Text = novoCod.ToString();
            }
        }

        // VALIDAÇÃO DAS ENTRADAS
        #region
        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbNomeProd.Text))
                listaErros.Add("\n O CAMPO NOME DO PRODUTO NÃO PODE FICAR VAZIO!");
            ttbNomeProd.Focus();

            decimal nomeNum;
            if (decimal.TryParse(ttbNomeProd.Text, out nomeNum))
            {
                listaErros.Add("\n O CAMPO NOME DO PRODUTO NÃO PODE CONTER NÚMEROS\n" +
                "DIGITE APENAS LETRAS!");
                ttbNomeProd.Focus();
            }

            if (string.IsNullOrEmpty(ttbCodProd.Text))
                listaErros.Add("\n O CAMPO CÓDIGO DO PRODUTO NÃO PODE FICAR VAZIO!");
            ttbCodProd.Focus();

            if (ttbCodProd.Text.Contains(" "))
                listaErros.Add("\n O CAMPO CÓDIGO DO PRODUTO NÃO PODE CONTER ESPAÇOS!");
            ttbCodProd.Focus();

            if (string.IsNullOrEmpty(ttbPreco.Text))
                listaErros.Add("\n O CAMPO PREÇO NÃO PODE FICAR VAZIO!");
            ttbPreco.Focus();

            if (ttbPreco.Text.Contains(" "))
                listaErros.Add("\n O CAMPO PREÇO NÃO PODE CONTER ESPAÇOS!");
            ttbPreco.Focus();

            if (listaErros.Count > 0)
            {
                MostraErros(listaErros);
                return false;
            }
            else
            {
                return listaErros.Count == 0;
            }
        }
        private void MostraErros(List<string> erros)
        {
            string mensagem = string.Join(Environment.NewLine, erros);
            MessageBox.Show(mensagem,
            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DesaHabilitar()
        {
            btNAlterar.Enabled = false;
            btNExcluir.Enabled = false;
        }
        private void Habilitar()
        {
            btNAlterar.Enabled = true;
            btNExcluir.Enabled = true;
        }
        private void Limpar()
        {
            pctFotoProd.Image = null;
            ttbNomeProd.Clear();
            ttbNomeFanta.Clear();
            ttbCodProd.Clear();
            ttbPreco.Clear();
            lbIdProd.Text = "";

            string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\imagemFundoProd.jpg";

            // Verifica se o arquivo existe no endereço acima citado
            if (File.Exists(caminhoImagemIlustrativa))
            {
                // Carrega a imagem a partir do caminho mencionado na string acima
                Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);

                // Atribui a imagem ao nome de domínio da picture definida
                pctFotoProd.Image = imagemIlustrativa;
            }
        }
        private void btNLimpar_Click(object sender, EventArgs e)
            => Limpar();

        private void OcultarDadosDGV()
            => dgvProd.Columns["IdProd"].Visible = false;

        #endregion
        private void btNGravar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btNGravar;
            if (TemEntradasValidas())
            {
                DataTable jaExiste = new ProdutoController().ProdJaExiste(ttbCodProd.Text);
                if (jaExiste.Rows.Count > 0)
                {
                    MessageBox.Show("\n ESTE CÓDIGO [   " + ttbCodProd.Text.ToString() +
                    "   ] JÁ ESTÁ CADASTRADO EM NOSSA BASE DE DADOS!\n\n" +
                    "ALTERE O CÓDIGO E TENTE NOVAMENTE!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] foto = ValidarFoto();

                if (foto == null)
                    return;
                SerializaCod();
                Produto obj = new Produto(0,
                ttbNomeProd.Text,
                ttbNomeFanta.Text,
                Convert.ToInt32(ttbCodProd.Text),
                decimal.Parse(ttbPreco.Text),
                foto);

                Estoque estoque = new Estoque(0, 0, 1);

                bool ok = obj.Gravar(); // GRAVA O PRODUTO

                obj.Foto = foto;

                if (ok == true)
                {
                    DialogResult R1 = MessageBox.Show("REGISTRO INSERIDO COM SUCESSO!\n\n" +
                    "DESEJA CONTINUAR CADASTRANDO NOVOS PRODUTOS?", "ATENÇÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R1 == DialogResult.Yes)
                    {
                        Limpar();
                        // Se a foto ilustrativa estiver vazia preencha-a
                        if (pctFotoProd.Image == null)
                        {
                            // Caminho da imagem fixa
                            string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\imagemFundoProd.jpg";
                            // Verifica se o arquivo existe no endereço acima citado
                            if (File.Exists(caminhoImagemIlustrativa))
                            {
                                // Carrega a imagem a partir do caminho mencionado na string acima
                                Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);
                                // Atribui a imagem ao nome de domínio da picture definida
                                pctFotoProd.Image = imagemIlustrativa;
                            }
                        }
                        return;
                    }
                    else
                    {
                        Limpar();
                        new ScreenLogin().ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("OCORREU UM ERRO AO TENTAR REGISTRAR O PRODUTO!\n",
                    "ATENÇÃO TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void btNExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProd.CurrentRow.Cells != null)
            {
                int idProd = Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value);
                string prod = dgvProd.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("\nATENÇÃO,CUIDADO!\n\nEXCLUIR O PRODUTO: [ " + prod + " ]  DO SISTEMA?",
                    "\nÁREA DE PERIGO: ESTA AÇÃO É IRREVERSÍVEL!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (new ProdutoController().Excluir(idProd))
                        MessageBox.Show("REGISTRO EXCLUÍDO COM SUCESSO!",
                        "REGISTRO EXCLUÍDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("ERRO AO EXCLUIR: " + prod + "\n\n" +
                        "PARA EXCLUIR UM PRODUTO CERTIFIQUE-SE DE QUE ELE NÃO ESTEJA ARMAZENADO EM OUTRA" +
                        "TABELA NO BANCO QUE NÃO SEJA A DE PRODUTOS!",
                        "ATENÇÃO TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvProd.DataSource = new ProdutoController().BuscarProd();
            }
            else
            {
                MessageBox.Show("NÃO HÁ ITENS NO RELATÓRIO PARA EXCLUIR!\n\n" +
                "CLIQUE EM VOLTAR E TENTE NOVAMENTE!",
                "ATENÇÃO TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btNTransport_Click(object sender, EventArgs e)
        {
            Habilitar();
            if (dgvProd.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProd.CurrentRow;
                if (selectedRow != null)
                {
                    lbIdProd.Text = selectedRow.Cells[0].Value.ToString();
                    ttbNomeProd.Text = selectedRow.Cells[1].Value.ToString();
                    ttbNomeFanta.Text = selectedRow.Cells[3].Value.ToString();
                    ttbCodProd.Text = selectedRow.Cells[4].Value.ToString();
                    ttbPreco.Text = selectedRow.Cells[5].Value.ToString();

                    byte[] fotoBytes = (byte[])selectedRow.Cells[6].Value;
                    if (fotoBytes != null && fotoBytes.Length > 0)
                    {
                        Image foto = ConverterBytesParaImagem(fotoBytes);
                        pctFotoProd.Image = foto;
                    }
                    else
                    {
                        // Caso o caminho da imagem esteja vazio, atribui-se uma imagem padrão ao PictureBox
                        string caminhoImagemFixa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\imagemFundoProd.jpg";
                        if (File.Exists(caminhoImagemFixa))
                        {
                            // Carrega a imagem padrão a partir do arquivo
                            Image imagemFixa2 = Image.FromFile(caminhoImagemFixa);
                            pctFotoProd.Image = imagemFixa2;
                        }
                    }
                }
                else
                {
                    // Caso o caminho da imagem esteja vazio, atribui-se uma imagem padrão ao PictureBox
                    string caminhoImagemFixa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\imagemFundoProd.jpg";
                    if (File.Exists(caminhoImagemFixa))
                    {
                        // Carrega a imagem padrão a partir do arquivo
                        Image imagemFixa2 = Image.FromFile(caminhoImagemFixa);
                        pctFotoProd.Image = imagemFixa2;
                    }
                }
            }
        }
        private Image ConverterBytesParaImagem(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

        private void btNAlterar_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                Produto prod = new Produto(
                Convert.ToInt32(lbIdProd.Text),
                ttbNomeProd.Text,
                ttbNomeFanta.Text,
                Convert.ToInt32(ttbCodProd.Text),
                decimal.Parse(ttbPreco.Text),
                null); // Inicialmente defini-se a foto como null

                // Verificar se a PictureBox contém uma imagem
                if (pctFotoProd.Image != null)
                {
                    // Obter a foto validada
                    byte[] foto = ValidarFoto();
                    prod.Foto = foto; // Atribuir a foto ao objeto Produto
                }

                bool ok = prod.Alterar();

                if (ok)
                {
                    MessageBox.Show("REGISTRO ALTERADO COM SUCESSO!",
                    "REGISTRO ALTERADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProd.DataSource = new ProdutoController().BuscarProd();
                    Limpar();
                    DesaHabilitar();

                    string caminhoImagemFixa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\imagemFundoProd.jpg";
                    if (File.Exists(caminhoImagemFixa))
                    {
                        // Carrega a imagem padrão a partir do arquivo
                        Image imagemFixa2 = Image.FromFile(caminhoImagemFixa);
                        pctFotoProd.Image = imagemFixa2;
                    }
                }
                else
                {
                    MessageBox.Show("ERRO AO ALTERAR REGISTRO NO BANCO DE DADOS!\n" +
                    "TENTE NOVAMENTE!",
                    "NÃO ALTEROU! TENTE NOVAMENTE!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btNFotoProd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Title = "Selecionar Imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;
                    pctFotoProd.Image = Image.FromFile(caminhoArquivo);
                }
            }
        }

        private byte[] ValidarFoto()
        {
            MemoryStream ms = new MemoryStream();
            using (MemoryStream msx = ms = new MemoryStream())
            {
                if (TemEntradasValidas())
                {
                    Produto prod = new Produto();

                    if (pctFotoProd.Image == null)
                    {
                        // Retornar o valor atual do atributo Foto sem modificar
                        return prod.Foto;
                    }
                    if (pctFotoProd.Image == null)
                    {
                        MessageBox.Show("A IMAGEM É NULA!");
                        return prod.Foto;
                    }
                }

                // Verifica se a imagem é PNG, caso contrário, converte para PNG
                if (pctFotoProd.Image.RawFormat.Guid != ImageFormat.Png.Guid)
                {
                    Bitmap pngImage = new Bitmap(pctFotoProd.Image);
                    pngImage.Save(ms, ImageFormat.Png);
                }
                else
                {
                    pctFotoProd.Image.Save(ms, ImageFormat.Png);
                }
            }
            return ms.ToArray();
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
