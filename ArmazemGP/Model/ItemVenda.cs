using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class ItemVenda
    {
        public int IdItemVenda { get; private set; }
        public int NumNotaFisc { get; private set; }
        public string Nome { get; private set; }
        public int IdProd { get; private set; }
        public int Qtd { get; private set; }
        public decimal SubTotal { get; private set; }
        public int IdVenda { get; private set; }
        public int IdColab { get; private set; }

        public ItemVenda()
        {

        }

        public ItemVenda(int idItemVenda, int idProd, int qtd, decimal subTotal, int idVenda, int idColab)
        {
            IdItemVenda = idItemVenda;
            IdProd = idProd;
            Qtd = qtd;
            SubTotal = subTotal;
            IdVenda = idVenda;
            IdColab = idColab;
        }

        public ItemVenda(int idItemVenda, string nome, int idProd, int qtd, decimal subTotal, int idVenda, int idColab)
        {
            IdItemVenda = idItemVenda;
            Nome = nome;
            IdProd = idProd;
            Qtd = qtd;
            SubTotal = subTotal;
            IdVenda = idVenda;
            IdColab = idColab;
        }

        public ItemVenda(int idItemVenda, int numNotaFisc, string nome, int idProd, int qtd, decimal subTotal, int idVenda, int idColab)
        {
            IdItemVenda = idItemVenda;
            NumNotaFisc = numNotaFisc;
            Nome = nome;
            IdProd = idProd;
            Qtd = qtd;
            SubTotal = subTotal;
            IdVenda = idVenda;
            IdColab = idColab;
        }

        public bool GravarItemVenda()
            => new ItemVendaController().GravarItemVenda(this);
        public bool ExcluirItemVenda(int lbIdProd)
            => new ItemVendaController().ExcluirItemVenda(lbIdProd);
    }
}
