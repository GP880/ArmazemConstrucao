using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;
using System.Drawing.Imaging;

namespace ArmazemGP.View
{
    public partial class TelaCadastroColaborador : Form
    {
        public TelaCadastroColaborador()
        {
            InitializeComponent();
            DataTable data = new DataTable();
            data = new ColaboradorController().BuscarColab();
            dgvColab.DataSource = data;
            DesaHabilitar();
        }
        //  VALIDAÇÃO DOS CAMPOS
        #region
        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\n O CAMPO NOME NÃO PODE FICAR VAZIO!");
            ttbNome.Focus();

            decimal nomeNum;
            if (decimal.TryParse(ttbNome.Text, out nomeNum))
                listaErros.Add("\n O CAMPO NOME NÃO PODE CONTER NÚMEROS\n" +
                "DIGITE APENAS LETRAS!");
            ttbNome.Focus();

            if (string.IsNullOrEmpty(ttbEmail.Text))
                listaErros.Add("\n O CAMPO EMAIL NÃO PODE FICAR VAZIO!");
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

            if (ttbSenha.Text.Length < 5 || ttbSenha.Text.Length > 8)
                listaErros.Add("\n SENHA INVÁLIDA! CRIE UMA SENHA ALFANUMÉRICA COM NO MÍNIMO [ 5 ] E " +
                "MÁXIMO DE [ 8 ] CARACTERES");

            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\n O CAMPO SENHA NÃO PODE FICAR VAZIO!");
            ttbSenha.Focus();

            DataTable codRepetido = new ColaboradorController().CoDRepetido(ttbCodColab.Text);
            if (codRepetido.Rows.Count > 0)
                listaErros.Add("\n ESTE CÓDIGO JÁ EXISTE EM NOSSA BASE DE DADOS\n\nESCOLHA OUTRO E TENTE NOVAMENTE!");
            ttbCodColab.Focus();

            if (string.IsNullOrEmpty(ttbCodColab.Text))
                listaErros.Add("\n O CAMPO CÓDIGO DO COLABORADOR NÃO PODE FICAR VAZIO!");
            ttbCodColab.Focus();

            if (string.IsNullOrEmpty(mktContato.Text))
                listaErros.Add("\n O CAMPO CONTATO NÃO PODE SER VAZIO!");
            mktContato.Focus();

            DataTable jaExiste = new ColaboradorController().ColabJaExiste(ttbEmail.Text);
            if (jaExiste.Rows.Count > 0)
                listaErros.Add("\nESTE COLABORADOR JÁ EXISTE EM NOSSA BASE DE DADOS!" +
                "\n\nCADASTRE UM OUTRO COLABORADOR E TENTE NOVAMENTE!");

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

        private bool EntradasValidas()
        {
            List<string> listaErros = new List<string>();
            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\n O CAMPO NOME NÃO PODE FICAR VAZIO!");
            ttbNome.Focus();

            decimal nomeNum;
            if (decimal.TryParse(ttbNome.Text, out nomeNum))
                listaErros.Add("\n O CAMPO NOME NÃO PODE CONTER NÚMEROS\n" +
                "DIGITE APENAS LETRAS!");
            ttbNome.Focus();

            if (string.IsNullOrEmpty(ttbEmail.Text))
                listaErros.Add("\n O CAMPO EMAIL NÃO PODE FICAR VAZIO!");
            ttbEmail.Focus();

            if (ttbEmail.Text.Contains(" "))
                MessageBox.Show("\n O CAMPO E-MAIL NÃO PODE CONTER ESPAÇOS!");
            ttbEmail.Focus();

            if (!ttbEmail.Text.Contains("@"))
                MessageBox.Show("\n NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: @");
            ttbEmail.Focus();

            if (!ttbEmail.Text.Contains(".com"))
                MessageBox.Show("\n NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: .com");
            ttbEmail.Focus();

            if (string.IsNullOrEmpty(ttbSenha.Text))
                listaErros.Add("\n O CAMPO SENHA NÃO PODE FICAR VAZIO!");
            ttbSenha.Focus();

            if (string.IsNullOrEmpty(ttbCodColab.Text))
                listaErros.Add("\n O CAMPO CÓDIGO DO COLABORADOR NÃO PODE FICAR VAZIO!");
            ttbCodColab.Focus();

            if (string.IsNullOrEmpty(mktContato.Text))
                listaErros.Add("\n O CAMPO CONTATO NÃO PODE SER VAZIO!");
            mktContato.Focus();

            if (listaErros.Count > 0)
            {
                MostraErro(listaErros);
                return false;
            }
            else
            {
                bool ok = true;
                return ok;
            }
        }
        private void MostraErro(List<string> erros)
        {
            string mensagens = "";
            foreach (var item in erros)
                mensagens += item;

            MessageBox.Show(mensagens, "ATENÇÃO!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        // CARREGAMENTO DA FOTO
        #region
        private void btNCarregarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Title = "Selecionar Imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;
                    pctFotoColab.Image = Image.FromFile(caminhoArquivo);
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

                    if (pctFotoColab.Image == null)
                    {
                        // Retornar o valor atual do atributo Foto sem modificar
                        return prod.Foto;
                    }
                    if (pctFotoColab.Image == null)
                    {
                        MessageBox.Show("A IMAGEM É NULA!");
                        return prod.Foto;
                    }
                }

                // Verifica se a imagem é PNG, caso contrário, converte para PNG
                if (pctFotoColab.Image.RawFormat.Guid != ImageFormat.Png.Guid)
                {
                    Bitmap pngImage = new Bitmap(pctFotoColab.Image);
                    pngImage.Save(ms, ImageFormat.Png);
                }
                else
                {
                    pctFotoColab.Image.Save(ms, ImageFormat.Png);
                }
            }
            return ms.ToArray();
        }
        #endregion
        private void SerializaCod()
        {
            if (ttbCodColab.Text == "0")
            {
                DataTable dtCod = new ColaboradorController().BuscarColab();
                int maiorCod = 0;
                for (int i = 0; i < dtCod.Rows.Count; i++)
                {
                    int codAtual = Convert.ToInt32(dtCod.Rows[i]["CodColab"]);
                    if (codAtual > maiorCod)
                    {
                        maiorCod = codAtual;
                    }
                }// OS CÓDIGOS DOS VENDEDORES SERÃO SERIALIZADOS DE 100 EM 100
                int novoCod = maiorCod + 100;
                ttbCodColab.Text = novoCod.ToString();
            }
        }
        private void btNGravar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btNGravar;
            if (TemEntradasValidas())
            {
                byte[] foto = ValidarFoto();

                if (foto == null)
                    return;
                SerializaCod();
                Colaborador objColab = new Colaborador(0,
                Convert.ToInt32(ttbCodColab.Text),
                ttbNome.Text,
                ttbEmail.Text,
                ttbSenha.Text,
                mktContato.Text,
                Convert.ToInt32(ttbNivelAcesso.Text),
                foto);

                bool ok = objColab.Gravar();

                objColab.Foto = foto;

                if (ok == true)
                {
                    DialogResult R1 = MessageBox.Show("REGISTRO INSERIDO COM SUCESSO!\n\n" +
                    "DESEJA CONTINUAR CADASTRANDO NOVOS COLABORADORES?", "ATENÇÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R1 == DialogResult.Yes)
                    {
                        Limpar();
                        // Se a foto ilustrativa estiver vazia preencha-a
                        if (pctFotoColab.Image == null)
                        {
                            // Caminho da imagem fixa // NOT GEO  C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens
                            //                              SENAC C:\Users\george.filho\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens
                            string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\foto3x4.Perfil.PNG";
                            // Verifica se o arquivo existe no endereço acima citado
                            if (File.Exists(caminhoImagemIlustrativa))
                            {
                                // Carrega a imagem a partir do caminho mencionado na string acima
                                Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);
                                // Atribui a imagem ao nome de domínio da picture definida
                                pctFotoColab.Image = imagemIlustrativa;
                                return;
                            }
                        }
                        return;
                    }
                    else
                    {
                        Limpar();
                        new ScreenLogin().ShowDialog();
                        // this.Close();
                    }
                }
                else
                    MessageBox.Show("OCORREU UM ERRO AO TENTAR REGISTRAR O COLABORADOR!\n",
                    "ATENÇÃO TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void btNExcluir_Click(object sender, EventArgs e)
        {
            if (dgvColab.CurrentRow.Cells == null)
            {
                MessageBox.Show("NÃO HÁ ITENS NO RELATÓRIO PARA EXCLUIR!\n\n" +
                "CLIQUE EM VOLTAR E TENTE NOVAMENTE!", "ATENÇÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvColab.CurrentRow.Cells != null)
            {
                int idColab = Convert.ToInt32(dgvColab.CurrentRow.Cells[0].Value);
                string username = dgvColab.CurrentRow.Cells[2].Value.ToString();

                if (MessageBox.Show("\nEXCLUIR O CADASTRO DE: " + username + " DO SISTEMA?",
                    "\nÁREA DE PERIGO: ESTA AÇÃO É IRREVERSÍVEL!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (new ColaboradorController().Excluir(idColab))
                    {
                        MessageBox.Show("REGISTRO EXCLUÍDO COM SUCESSO!", "ATENÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    else
                        MessageBox.Show("ERRO AO EXCLUIR: " + username + "\n\n" +
                        "PARA EXCLUIR UM COLABORADOR, CERTIFIQUE-SE DE QUE ELE\n" +
                        "NÃO ESTEJA REGISTRADO EM OUTRA TABELA NO BANCO E TENTE NOVAMENTE!",
                        "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvColab.DataSource = new ColaboradorController().BuscarColab();
            }
        }
        private void DesaHabilitar()
        {
            btNExcluir.Enabled = false;
            btNAlterar.Enabled = false;
        }
        private void Habilitar()
        {
            btNExcluir.Enabled = true;
            btNAlterar.Enabled = true;
        }

        private void btNAlterar_Click(object sender, EventArgs e)
        {
            if (EntradasValidas())
            {
                Colaborador colab = new Colaborador(
                Convert.ToInt32(Program.UsuarioLogado.IdColab.ToString()),
                Convert.ToInt32(ttbCodColab.Text),
                ttbNome.Text,
                ttbEmail.Text,
                ttbSenha.Text,
                mktContato.Text,
                Convert.ToInt32(ttbNivelAcesso.Text),
                null); // Inicialmente defini-se a foto como null

                // Verificar se a PictureBox contém uma imagem
                if (pctFotoColab.Image != null)
                {
                    // Obter a foto validada
                    byte[] foto = ValidarFoto();
                    colab.Foto = foto; // Atribuir a foto ao objeto Produto
                }

                bool ok = colab.Alterar();

                if (ok)
                {
                    MessageBox.Show("REGISTRO ALTERADO COM SUCESSO!", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvColab.DataSource = new ColaboradorController().BuscarColab();
                    Limpar();
                    DesaHabilitar();
                }
                else
                {
                    MessageBox.Show("ERRO AO ALTERAR O REGISTRO!", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void Limpar()
        {
            pctFotoColab.Image = null;
            ttbNome.Clear();
            ttbEmail.Clear();
            ttbSenha.Clear();
            mktContato.Clear();
            ttbCodColab.Clear();
            ttbNivelAcesso.Clear();
            string caminhoImagemIlustrativa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\foto3x4.Perfil.PNG";
            // Verifica se o arquivo existe no endereço acima citado
            if (File.Exists(caminhoImagemIlustrativa))
            {
                // Carrega a imagem a partir do caminho mencionado na string acima
                Image imagemIlustrativa = Image.FromFile(caminhoImagemIlustrativa);
                // Atribui a imagem ao nome de domínio da picture definida
                pctFotoColab.Image = imagemIlustrativa;
            }
        }
        private void btNLimpar_Click(object sender, EventArgs e)
            => Limpar();

        private void dgvColab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvColab.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvColab.CurrentRow;
                if (selectedRow != null)
                {
                    Habilitar();
                    lbIdColab.Text = selectedRow.Cells[0].Value.ToString();
                    ttbCodColab.Text = selectedRow.Cells[1].Value.ToString();
                    ttbNome.Text = selectedRow.Cells[2].Value.ToString();
                    ttbEmail.Text = selectedRow.Cells[3].Value.ToString();
                    mktContato.Text = selectedRow.Cells[5].Value.ToString();
                    ttbNivelAcesso.Text = selectedRow.Cells[5].Value.ToString();

                    byte[] fotoBytes = (byte[])selectedRow.Cells[6].Value;
                    if (fotoBytes != null && fotoBytes.Length > 0)
                    {
                        Image foto = ConverterBytesParaImagem(fotoBytes);
                        pctFotoColab.Image = foto;
                    }
                    else
                    {
                        // Caso o caminho da imagem esteja vazio, atribui-se uma imagem padrão ao PictureBox
                        string caminhoImagemFixa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\foto3x4.Perfil.PNG";
                        if (File.Exists(caminhoImagemFixa))
                        {
                            // Carrega a imagem padrão a partir do arquivo
                            Image imagemFixa2 = Image.FromFile(caminhoImagemFixa);
                            pctFotoColab.Image = imagemFixa2;
                        }
                    }
                }
                else
                {
                    // Caso o caminho da imagem esteja vazio, atribui-se uma imagem padrão ao PictureBox
                    string caminhoImagemFixa = @"C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\Imagens\foto3x4.Perfil.PNG";
                    if (File.Exists(caminhoImagemFixa))
                    {
                        // Carrega a imagem padrão a partir do arquivo
                        Image imagemFixa2 = Image.FromFile(caminhoImagemFixa);
                        pctFotoColab.Image = imagemFixa2;
                    }
                }
                tabCadastroColab.SelectedIndex = 0;
            }
            else
                MessageBox.Show("ERRO! NÃO FOI POSSÍVEL CONVERTER A STRING EM IMAGEM!\n" +
                "TENTE NOVAMENTE!", "ATENÇÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private Image ConverterBytesParaImagem(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

        private void pctOlhoSenha_Click(object sender, EventArgs e)
        {
            if (ttbSenha.UseSystemPasswordChar == true)
                ttbSenha.UseSystemPasswordChar = false;
            else
                ttbSenha.UseSystemPasswordChar = true;
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
