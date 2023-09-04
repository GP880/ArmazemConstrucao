namespace ArmazemGP.Model
{
    public class ProdutoOutput
    {
        public int IdProd { get; private set; }
        public string NomeProd { get; private set; }
        public int CodProd { get; private set; }
        public decimal Preco { get; private set; }
        public int QtdProduto { get; private set; }
        public byte[] Foto { get; private set; }

        public ProdutoOutput() 
        { 

        }

        public ProdutoOutput(int idProd, string nomeProd, int codProd, decimal preco, int qtdProduto)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
            CodProd = codProd;
            Preco = preco;
            QtdProduto = qtdProduto;
        }

        public ProdutoOutput(int idProd, string nomeProd, int codProd, decimal preco, int qtdProduto, byte[] foto)
        {
            IdProd = idProd;
            NomeProd = nomeProd;
            CodProd = codProd;
            Preco = preco;
            QtdProduto = qtdProduto;
            Foto = foto;
        }
    }
}
