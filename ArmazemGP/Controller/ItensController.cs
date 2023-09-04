using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class ItensController
    {
        public int GravarItens(Itens objItens)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Itens(IdVenda, IdItemVenda)
                VALUES(@IdVenda, @IdItemVenda)",
                "IdVenda", objItens.IdVenda,
                "IdItemVenda", objItens.IdItemVenda);
            }
            using(banco = new BancoInstance())
            {
                DataTable dt = new DataTable();
                banco.Banco.ExecuteQuery(
                @"SELECT IdItens FROM Itens order by IdItens Desc", out dt);
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }
    }
}
