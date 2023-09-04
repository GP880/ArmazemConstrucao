using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;
using System.Data.SqlClient;

namespace ArmazemGP.Controller
{
    public class EstoqueController : Produto
    {
        public bool Gravar(Estoque obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Estoque(Qtd)
                VALUES(@Qtd)",
                "Qtd", obj.Qtd);
            }
        }

        public int ObterEstoqueAtual(int idProd)
        {
            DataTable prod = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT Qtd
                FROM Estoque
                WHERE IdProd = @1", out prod, "@1", idProd);
                if (prod.Rows.Count > 0)
                return Convert.ToInt32(prod.Rows[0]["Qtd"].ToString());
                return 0;
            }
        }

        public DataTable BuscarEstoque()
        {
            DataTable prod = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Estoque", out prod);
                return prod;
            }
        }

        public DataTable BuscarEstoqueIdProd(object qtdEstoque)
        {
            DataTable data = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT Qtd FROM Estoque
                WHERE IdProd = @idProd", out data);
                return data;
            }
        }
        public DataTable BuscarEstoqueQtd(object qrdEstoque)
        {
            DataTable data = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT Qtd FROM Estoque
                WHERE IdProd = @IdProd", out data);
                return data;
            }
        }

        public DataTable BuscarEstoquePorId(int idProd)
        {
            DataTable data = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT IdEstoque, IdProd, Qtd", out data);
                return data;
            }
        }

        public int ObterQuantidadeProduto(int idProd, int novaQuantidade)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteNonQuery(
                @"SELECT Qtd
               FROM Estoque
               WHERE IdEstoque=@param", "@param", novaQuantidade);
                return idProd;
            }
        }
        //    STRING SENAC //       Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\george.filho\Desktop\Armazem.ConstruLar\ArmazemGP\ArmazemGP\DAO\Banco.mdf;Integrated Security=True
        //    STRING NOT GEO //     Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\George\Desktop\Armazem.ConstruLar\ArmazemGP\ArmazemGP\DAO\Banco.mdf;Integrated Security=True
        public int ObterQuantidadeProduto(int idProduto)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\Desktop\\Armazem.ConstruLar\\ArmazemGP\\ArmazemGP\\DAO\\Banco.mdf;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Qtd FROM Estoque WHERE IdProd = @param";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@param", idProduto);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int quantidade = Convert.ToInt32(result);
                        return quantidade;
                    }
                    return 0;
                }
            }
        }

        public int BuscarEstoqueId(int idProd)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteNonQuery(
                @"SELECT Qtd
                FROM Estoque
                WHERE IdEstoque=@param", "@param", IdProd);
                return idProd;
            }
        }

        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        public bool DebitarItensDoEstoque2(int idProd, int Qtd)           //SUB SELECT
        {                                                                 //REDUZIR
            BancoInstance Banco;
            using (Banco = new BancoInstance())
            {
                return Banco.Banco.ExecuteNonQuery(
                @"UPDATE Estoque
                SET Qtd = (SELECT Qtd FROM Estoque WHERE IdProd = @IdProd) - @Qtd
                WHERE IdProd = @IdProd",
                "@IdProd", idProd,
                "@Qtd", Qtd);
            }
        }
        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------

        public bool AtualizarEstoque(int idProd, int Qtd)                 //SUB SELECT
        {                                                                //ACRESCENTAR
            BancoInstance Banco;
            using (Banco = new BancoInstance())
            {
                DataTable dt = new DataTable();
                Banco.Banco.ExecuteQuery(
                @"SELECT Qtd
                FROM Estoque
                WHERE IdProd = @IdProd",
                out dt, "@IdProd", idProd);

                if (dt.Rows.Count > 0)
                {
                    //achou o id, atualizar. CASO SEJA UM PRODUTO NOVO NO BANCO,
                    //ENTÃO ELE SÓ CONSEGUE ABASTECER O ESTOQUE REALIZANDO UM:
                    //'INSERT INTO' COMO SEGUE NO BLOCO ELSE
                    return Banco.Banco.ExecuteNonQuery(
                    @"UPDATE Estoque
                    SET Qtd = (
                    SELECT Qtd
                    FROM Estoque
                    WHERE IdProd = @IdProd) + @Qtd
                    WHERE IdProd = @IdProd",
                    "@IdProd", idProd,
                    "@Qtd", Qtd);
                }
                else
                {
                    //não achou o registro para atualiza-lo, então, INSERT INTO (insere o registro)
                    return Banco.Banco.ExecuteNonQuery(
                    @"INSERT INTO Estoque(IdProd, Qtd)
                    VALUES(@idProd, @qtd)",
                    "@idProd", idProd,
                    "@qtd", Qtd);
                }
            }
        }
    }
}
