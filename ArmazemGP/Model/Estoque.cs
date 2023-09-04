using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class Estoque
    {
        public int IdEstoque { get; private set; }
        public int IdProd { get; private set; }
        public int Qtd { get; private set; }

        public Estoque()
        {

        }

        public Estoque(int idEstoque, int idProd, int qtd)
        {
            IdEstoque = idEstoque;
            IdProd = idProd;
            Qtd = qtd;
        }

        public bool Gravar()
            => new EstoqueController().Gravar();
        public DataTable BuscarEstoque()
            => new EstoqueController().BuscarEstoque();
        public static int ObterQuantidadeProduto(int idProdSelecionado, int novaQuantidade)
            => new EstoqueController().ObterQuantidadeProduto(idProdSelecionado, novaQuantidade);
        public static int ObterQuantidadeProduto(int idProdSelecionado, object novaQuantidade)
            => new EstoqueController().ObterQuantidadeProduto(idProdSelecionado, (int)novaQuantidade);
        public static int ObterQuantidadeProduto(int idProdSelecionado)
            => new EstoqueController().ObterQuantidadeProduto((int) idProdSelecionado);
        public DataTable BuscarEstoqueQtd()
            => new EstoqueController().BuscarEstoqueQtd(this);
    }
}
