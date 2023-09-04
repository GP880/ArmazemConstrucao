using ArmazemGP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmazemGP.View
{
    public partial class TelaParcelas : Form
    {
        public TelaParcelas(decimal Cred, bool rdbMaster, bool rdbElo, bool rdbHiper, bool rdbDiners, bool rdbAmex)
        {
            InitializeComponent();

            ttbAParcelar.Text = Convert.ToString(Cred);

            double valorApagar = 0;

            MontaComboParcelas(rdbMaster, rdbElo, rdbHiper, rdbDiners, rdbAmex);
        }

        private void MontaComboParcelas(bool rdbMaster, bool rdbElo, bool rdbHiper, bool rdbDiners, bool rdbAmex)
        {
            double  taxaJuros = 0.0;
            int qtdParcelas = 12;

            if (rdbMaster)
            {
                taxaJuros = 0.03;
            }
            else if (rdbElo == true)
            {
                 taxaJuros = 0.08;
            }
            else if (rdbHiper == true)
            {
                 taxaJuros = 0.02;
            }
            else if (rdbDiners == true)
            {
                 taxaJuros = 0.05;
            }
            else if (rdbAmex == true)
            {
                 taxaJuros = 0.09;
            }

            double valorParcela = Convert.ToDouble(ttbAParcelar.Text) / qtdParcelas * Math.Pow(1 + taxaJuros, qtdParcelas);

            cbbParcelas.Items.Clear();
            cbbParcelas.Items.Add("--Selecione--");

            for(int i = 1; i <= qtdParcelas; i++)
            {
                double valorAtual = Convert.ToDouble(ttbAParcelar.Text) / i * Math.Pow(1 + taxaJuros, i);
                cbbParcelas.Items.Add($"{i} X de R$ {valorAtual:F2}");
            }

            cbbParcelas.SelectedIndex = 0; //cbbParcelas.FindStringExact("--Selecione--");
            cbbParcelas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btNConfirma_Click(object sender, EventArgs e)
        {
            // A partir daqui será Registrado cada parcela com os juros adequados à taxa de cada cartão...

            // PRECISA DEFINIR UMA CLASSE Parcelas E UMA CONTROLLER Parcelas, BEM COMO UMA TABELA Parcelas
            // PARA REGISTRAR AS PARCELAS DE CADA CLIENTE
            // NAVEGANDO NO BANCO Cliente e PEGANDO COMO REFERÊNCIA O IdCliente.
            this.Close();
        }
    }
}
