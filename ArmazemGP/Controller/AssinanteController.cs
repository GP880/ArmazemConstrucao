using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class AssinanteController
    {
        public bool Gravar(Assinantes ass)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Assinantes (IdProd, IdColab, Notificar) 
                VALUES (@IdProd, @IdColab, @Notificar)",
                "@IdProd", ass.IdProd,
                "@IdColab", ass.IdColab,
                "@Notificar", ass.Notificar);
            }
        }

        public List<Produto> ObterNotificacoesColab(int idColab)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            List<Produto> lista = new List<Produto>();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT P.IdProd, P.NomeProd
                FROM Assinantes A
                JOIN Produto P
                ON A.IdProd = P.IdProd
                WHERE IdColab = @IdColab
                AND Notificar = @var",
                out retorno,
                "@IdColab", idColab,
                "@var", true);
            }
            if (retorno.Rows.Count > 0)
            {
                for (int i = 0; i < retorno.Rows.Count; i++)
                {
                    lista.Add(new Produto(Convert.ToInt32(
                    retorno.Rows[i]["IdProd"].ToString()),
                    retorno.Rows[i]["NomeProd"].ToString()));
                }
            }
            return lista;
        }

        public DataTable ObterAssinantesProduto(int idProd)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Assinantes
                WHERE IdProd = @var",
                out retorno, "@var", idProd);
                return retorno;
            }
        }

        public bool AlterarStatusNotificacao(object idProduto)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"UPDATE Assinantes 
                SET Notificar = @var
                WHERE IdProd = @IdProd",
                "@var", true,
                "@IdProd", idProduto);
            }
        }

        public bool ExcluirNotificacao(int idColab, int idProd)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE Assinantes 
                WHERE IdProd = @IdProd
                AND IdColab = @IdColab",
                "@IdProd", idProd,
                "@IdColab", idColab);
            }
        }
    }
}
