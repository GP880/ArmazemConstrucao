using ArmazemGP.Controller;

namespace ArmazemGP.Model
{
    public class Produto
    {
        public int IdProd { get; private set; }
        public string NomeProd { get; private set; }
        public string NomeFanta { get; private set; }
        public int CodProd { get; private set; }
        public decimal Preco { get; private set; }
        public byte[] Foto { get; set; }

        public Produto()
        {

        }

        public Produto(int idProd, string nomeProd, int codProd, decimal preco)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
            CodProd = codProd;
            Preco = preco;
        }

        public Produto(int idProd, string nomeProd)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
        }

        public Produto(int idProd, string nomeProd, string nomeFanta, int codProd, decimal preco)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
            NomeFanta = nomeFanta;
            CodProd = codProd;
            Preco = preco;
        }

        public Produto(int idProd, string nomeProd, string nomeFanta, int codProd, decimal preco, byte[] foto)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
            NomeFanta = nomeFanta;
            CodProd = codProd;
            Preco = preco;
            Foto = foto;
        }

        public bool Gravar()
            => new ProdutoController().Gravar(this);
        public bool AtualizarQtd(int novaQtd)
            => new ProdutoController().AtualizarProd(this);
        public bool Alterar()
            => new ProdutoController().Alterar(this);
        public static string ObterNomeProd(int idProdSelecionado)
            => new ProdutoController().ObterNomeProd(idProdSelecionado.ToString());
    }
}
