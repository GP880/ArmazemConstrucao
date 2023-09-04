using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class Venda
    {
        public int IdVenda { get; private set; }
        public int NumNotaFisc { get; private set; }
        public int CodColab { get; private set; }
        public int IdItens { get; private set; }
        public decimal ValTot { get; private set; }
        public int IdColab { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Dinheiro { get; private set; }
        public decimal CartDeb { get; private set; }
        public decimal CartCred { get; private set; }
        public decimal Pix { get; private set; }


        public List<ItemVenda> ItensVenda { get; private set; }
        public DateTime Data { get; set; }


        public Venda()
        {

        }

        public Venda(int idVenda, decimal valTot, int idColab, decimal desconto)
        {
            IdVenda = idVenda;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
        }

        public Venda(int idVenda, int codColab, decimal valTot, int idColab, decimal desconto)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
        }

        public Venda(int idVenda, int codColab, int idItens, decimal valTot, int idColab, decimal desconto)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
        }

        public Venda(int idVenda, int codColab, int idItens, decimal valTot, int idColab, decimal desconto, List<ItemVenda> itensVenda, DateTime data)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
            ItensVenda = itensVenda;
            Data = data;
        }

        public Venda(int idVenda, decimal dinheiro)
        {
            IdVenda = idVenda;
            Dinheiro = dinheiro;
        }

        public Venda(int idVenda, int codColab, int idItens, decimal valTot, int idColab, decimal desconto, decimal dinheiro)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
            Dinheiro = dinheiro;
        }

        public Venda(int idVenda, int codColab, int idItens, decimal valTot, int idColab, decimal desconto, decimal dinheiro, decimal cartDeb, decimal cartCred)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
            Dinheiro = dinheiro;
            CartDeb = cartDeb;
            CartCred = cartCred;
        }

        public Venda(int idVenda, int codColab, int idItens, decimal valTot, int idColab, decimal desconto, decimal dinheiro, decimal cartDeb, decimal cartCred, decimal pix)
        {
            IdVenda = idVenda;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
            Dinheiro = dinheiro;
            CartDeb = cartDeb;
            CartCred = cartCred;
            Pix = pix;
        }

        public Venda(int idVenda, int numNotaFisc, int codColab, int idItens, decimal valTot, int idColab, decimal desconto, decimal dinheiro, decimal cartDeb, decimal cartCred, decimal pix)
        {
            IdVenda = idVenda;
            NumNotaFisc = numNotaFisc;
            CodColab = codColab;
            IdItens = idItens;
            ValTot = valTot;
            IdColab = idColab;
            Desconto = desconto;
            Dinheiro = dinheiro;
            CartDeb = cartDeb;
            CartCred = cartCred;
            Pix = pix;
        }

        public int Gravar()
            => new VendaController().Gravar(this);
        
        public bool Excluir()
            => new VendaController().Excluir(IdVenda);

        public DataTable BuscarVenda()
            => new VendaController().BuscarVenda();
    }
}
