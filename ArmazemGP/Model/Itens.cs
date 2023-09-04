using ArmazemGP.Controller;

namespace ArmazemGP.Model
{
    public class Itens
    {
        public int IdItens { get; private set; }
        public int IdVenda { get; private set; }
        public int IdItemVenda { get; private set; }

        public Itens()
        {

        }

        public Itens(int idItens, int idVenda, int idItemVenda)
        {
            IdItens = idItens;
            IdVenda = idVenda;
            IdItemVenda = idItemVenda;
        }

        public int GravarItens(Itens objItens)
            => new ItensController().GravarItens(objItens);
    }
}
