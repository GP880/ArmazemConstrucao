using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class ProdutoController
    {
        public bool Gravar(Produto obj) 
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Produto(NomeProd, NomeFanta, CodProd, Preco, Foto)
                VALUES(@NomeProd, @NomeFanta, @CodProd, @Preco, @Foto)",
                "@NomeProd", obj.NomeProd,
                "@NomeFanta", obj.NomeFanta,
                "@CodProd", obj.CodProd,
                "@Preco", obj.Preco,
                "@Foto", obj.Foto);
            }
        }

        public DataTable BuscarProd()
        {
            DataTable prod = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT p.IdProd, p.NomeProd, e.Qtd, p.NomeFanta, p.CodProd, p.Preco, p.Foto
                FROM Produto p
                JOIN Estoque e
                ON p.IdProd = e.IdProd", out prod);
                return prod;
            }
        }
        
        public bool AtualizarProd(Produto produto) // Método da TelaCadastroQtd 
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"UPDATE Produto
                SET NomeProd=@1, NomeFanta=@2, CodProd=@3, Preco=@4, Foto=@5, IdProd=@6
                WHERE IdProd=@IdProd",
                "@1", produto.NomeProd,
                "@2", produto.NomeFanta,
                "@3", produto.CodProd,
                "@4", produto.Preco,
                "@5", produto.Foto,
                "@6", produto.IdProd); //"@IdProd", produto.IdProd);
            }
        }

        public bool Excluir(int idProd)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Produto
                WHERE IdProd = @param", "@param", idProd);
            }
        }

        public bool Alterar(Produto prod)
        {
            using (BancoInstance banco = new BancoInstance())
            {
                // Verificar se a foto do produto foi alterada
                string query;
                if (prod.Foto == null)
                {
                    // Manter a foto existente no banco de dados
                    query = @"UPDATE Produto
                            SET NomeProd = @1, NomeFanta = @2, CodProd = @3, Preco = @4
                            WHERE IdProd = @5";
                }
                else
                {
                    // Atualizar a foto do produto no banco de dados
                    query = @"UPDATE Produto
                            SET NomeProd = @1, NomeFanta = @2, CodProd = @3, Preco = @4, Foto = @5
                            WHERE IdProd = @6";
                }

                return banco.Banco.ExecuteNonQuery(query,
                "@1", prod.NomeProd,
                "@2", prod.NomeFanta,
                "@3", prod.CodProd,
                "@4", prod.Preco,
                "@5", prod.Foto,
                "@6", prod.IdProd);
            }
        }

        public DataTable BuscarProdPorNome(string text)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT IdProd NomeProd, NomeFanta, CodProd, Preco, Foto
                FROM Produto
                WHERE NomeProd like @var",
                out dt, "@var", "%" + text + "%");
                return dt;
            }
        }

        public DataTable BuscarProdPorCodigo(int cod)   // BUSCA POR CÓDIGO
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT p.IdProd, p.NomeProd, p.NomeFanta, p.CodProd, p.Preco, e.Qtd, p.Foto
                FROM Produto p
                JOIN Estoque e
                ON e.IdProd = p.IdProd 
                WHERE CodProd = @var",
                out dt, "@var",  cod.ToString());
                return dt;
            }
        }
       
        public string ObterNomeProd(string text)    // BUSCA POR PARTES DO NOME
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Produto
                WHERE NomeProd like @var", out dt, "@var", "%" + text + "%");
            }
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["NomeProd"].ToString();
            else
                return string.Empty;
        }

        public decimal BuscarSubTotalDaVenda()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(SubTotal) AS ValAPG
                FROM ItemVenda",
                out dt);
            }
            if(dt.Rows.Count > 0 && dt.Rows[0]["ValAPG"] != DBNull.Value)
            {
                decimal valorAPagar;
                if (decimal.TryParse(dt.Rows[0]["ValAPG"].ToString(), out valorAPagar))
                {
                    return valorAPagar;
                }
            }
            return 0;
        }

        public DataTable ProdJaExiste(string codigo)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM Produto " +
                "WHERE CodProd = @CodProd";
                banco.Banco.ExecuteQuery(sql, out jaExiste, "@CodProd", codigo);
            }
            return jaExiste;
        }
    }
}
