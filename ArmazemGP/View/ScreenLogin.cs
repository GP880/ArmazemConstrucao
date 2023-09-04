using ArmazemGP.Controller;
using ArmazemGP.Model;
using System.Data;
using System.Security.Cryptography;
using System.Text;


namespace ArmazemGP.View
{
    public partial class ScreenLogin : Form
    {
        public ScreenLogin()
        {
            InitializeComponent();
            ttbEmail.Focus();
        }

        public void CarregandoLoginTelaPrincipal()
        {
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 40;
                while (value <= 100)
                {
                    pbgCarregarSistema.Invoke(new Action(() =>
                    {
                        lbInvisivel2.Text = "Carregando... " +
                        pbgCarregarSistema.Value.ToString() + "%";
                        pbgCarregarSistema.Value = value;
                        pbgCarregarSistema.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    DialogResult R1 = MessageBox.Show("LOGIN REALIZADO COM NÍVEL DE ACESSO: PROPRIETÁRIO" +
                    "\n\nSEJA BEM VINDO (a) Sr: " + Program.UsuarioLogado.NomeColab,
                    "ACESSO PERMITIDO NÍVEL MASTER!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        new TelaPrincipal().ShowDialog();
                        this.Hide();
                        this.Close();
                    }
                    return;
                }));
            });
            t.Start();
        }

        public void CarregandoLoginTelaGerente()
        {
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 40;
                while (value <= 100)
                {
                    pbgCarregarSistema.Invoke(new Action(() =>
                    {
                        lbInvisivel2.Text = "Carregando... " +
                        pbgCarregarSistema.Value.ToString() + "%";
                        pbgCarregarSistema.Value = value;
                        pbgCarregarSistema.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    MessageBox.Show("LOGIN REALIZADO COM NÍVEL DE ACESSO: GERENTE" +
                    "\n\nSEJA BEM VINDO (a) Sr: " + Program.UsuarioLogado.NomeColab,
                    "ACESSO PERMITIDO NÍVEL GERENTE!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        new TelaPrincipal().ShowDialog();
                        //this.Hide();
                        this.Close();
                    }
                }));
            });
            t.Start();
        }

        public void CarregandoLoginTelaVendedor()
        {
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 40;
                while (value <= 90)
                {
                    pbgCarregarSistema.Invoke(new Action(() =>
                    {
                        lbInvisivel2.Text = "Carregando... " + pbgCarregarSistema.Value.ToString() + "%";
                        pbgCarregarSistema.Value = value;
                        pbgCarregarSistema.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    MessageBox.Show("LOGIN REALIZADO COM NÍVEL DE ACESSO: VENDEDOR" +
                    "\n\nSEJA BEM VINDO (a) Sr: " + Program.UsuarioLogado.NomeColab,
                    "ACESSO PERMITIDO NÍVEL VENDEDOR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        new TelaVenda().ShowDialog();
                        pbgCarregarSistema.Visible = false;
                        //this.Hide();
                        this.Close();
                    }
                }));
            });
            t.Start();
        }

        public void CarregandoLoginTela1ºCadastro()
        {
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Maximum = 100;
            pbgCarregarSistema.Minimum = 0;
            Thread t = new Thread(() =>
            {
                int value = 40;
                while (value <= 90)
                {
                    pbgCarregarSistema.Invoke(new Action(() =>
                    {
                        lbInvisivel2.Text = "Carregando... " + pbgCarregarSistema.Value.ToString() + "%";
                        pbgCarregarSistema.Value = value;
                        pbgCarregarSistema.Visible = true;
                    }));
                    Thread.Sleep(30);
                    value++;
                }
                Invoke(new Action(() =>
                {
                    MessageBox.Show("LOGIN REALIZADO COM LOGIN E SENHA DE ADMINISTRADOR\n\n" +
                    "CADASTRO DO 1º COLABORADOR!",
                    "ACESSO NÍVEL: ADMINISTRADOR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    {
                        new TelaCadastroColaborador().ShowDialog();
                        //this.Hide();
                        this.Close();
                    }
                }));
            });
            t.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA REALMENTE SAIR?",
                "SAIR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void pctVisualizar_Click(object sender, EventArgs e)
        {
            if (ttbSenha.UseSystemPasswordChar == true)
            {
                ttbSenha.UseSystemPasswordChar = false;
                pctVisualizar.Text = "VISUALIZAR";
            }
            else
            {
                ttbSenha.UseSystemPasswordChar = true;
                pctVisualizar.Text = "OCULTAR";
            }
        }

        private bool TemEntradasValidas()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbEmail.Text))
            {
                listaErros.Add("O CAMPO E-MAIL NÃO PODE FICAR VAZIO!");
                ttbEmail.Focus();
            }
            else
            if (ttbEmail.Text.Contains(" "))
            {
                listaErros.Add("O CAMPO E-MAIL NÃO PODE CONTER ESPAÇOS!");
                ttbEmail.Focus();
            }
            else
            if (!ttbEmail.Text.Contains("@"))
            {
                if (ttbEmail.Text == "admin" && ttbSenha.Text == "1234")
                {

                }
                else
                    listaErros.Add("NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: @");
                ttbEmail.Focus();
            }
            else
            if (!ttbEmail.Text.Contains(".com"))
            {
                if (ttbEmail.Text == "admin" && ttbSenha.Text == "1234")
                {

                }
                else
                    listaErros.Add("NO CAMPO E-MAIL FALTA O SEGUINTE SÍMBOLO: .com");
                ttbEmail.Focus();
            }

            DataTable dados = new ColaboradorController().BuscarColab(ttbEmail.Text);

            if (listaErros.Count > 0)
            {
                MostraErros(listaErros);
                return false;
            }
            return true;
        }

        //método para gerar o hash da senha:

        public static string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Converte para representação hexadecimal
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TemEntradasValidas())
            {
                DataTable dados = new ColaboradorController().BuscarColab(ttbEmail.Text);

                string senhaHash = GerarHashSenha(ttbSenha.Text);

                if (dados.Rows.Count > 0)
                {
                    string loginDigitado = ttbEmail.Text.ToLower();
                    //  senhaHash = ttbSenha.Text.ToLower();  // senhaDigitada
                    bool loginOK = false;
                    bool senhaOK = false;
                    for (int i = 0; i < dados.Rows.Count; i++)
                    {
                        string loginArmazenado = dados.Rows[i]["EmailLogin"].ToString().ToLower();
                        string senhaArmazenada = dados.Rows[i]["Senha"].ToString().ToLower();

                        if (loginArmazenado == loginDigitado)
                        {
                            loginOK = true;
                            if (senhaArmazenada == senhaHash)  // senhaDigitada
                            {
                                senhaOK = true;
                                Program.UsuarioLogado = new Colaborador(
                                Convert.ToInt32(dados.Rows[i]["IdColab"].ToString()),
                                Convert.ToInt32(dados.Rows[i]["CodColab"].ToString()),
                                dados.Rows[i]["NomeColab"].ToString(),
                                dados.Rows[i]["EmailLogin"].ToString(),
                                dados.Rows[i]["Senha"].ToString(),
                                Convert.ToInt32(dados.Rows[i]["NivelAcces"].ToString()));

                                int nivelAcesso = Convert.ToInt32(dados.Rows[i]["NivelAcces"]);
                                switch (nivelAcesso)
                                {
                                    case 1:
                                        CarregandoLoginTelaPrincipal();
                                        break;
                                    case 2:
                                        CarregandoLoginTelaGerente();
                                        break;
                                    case 3:
                                        CarregandoLoginTelaVendedor();
                                        break;
                                }
                                break;
                            }
                        }
                    }
                    if (!loginOK)
                    {
                        lbErrorLogin.Text = "VERIFIQUE O LOGIN";
                        lbErrorLogin.ForeColor = Color.Red;
                        return;
                    }
                    else
                    if (!senhaOK)
                    {
                        lbErroSenha.Text = "VERIFIQUE A SENHA";
                        lbErroSenha.ForeColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    DialogResult op = MessageBox.Show("AINDA NÃO FORAM CADASTRADOS COLABORADORES NO BANCO DE DADOS!" +
                    "\n\nDESEJA REALIZAR O PRIMEIRO CADASTRO?", "ATENÇÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (op == DialogResult.Yes && ttbEmail.Text == "admin" && ttbSenha.Text == "1234")
                        CarregandoLoginTela1ºCadastro();
                    else
                        MessageBox.Show("DADOS INVÁLIDOS! \n\n" +
                        "DIGITE O LOGIN E SENHA DE ADMINISTRADOR E TENTE NOVAMENTE!",
                        "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void MostraErros(List<string> erros)
        {
            string mensagens = "";
            foreach (var item in erros)
                mensagens = mensagens + item;

            MessageBox.Show(mensagens, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
