using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class ItemVendaController
    {
        public bool GravarItemVenda(ItemVenda objItemVenda)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO ItemVenda(NumNotaFisc, IdProd, Nome, Qtd, SubTotal, IdVenda, IdColab)
                VALUES(@NumNotaFisc, @IdProd, @Nome, @Qtd, @SubTotal, @IdVenda, @IdColab)",
                "@NumNotaFisc", objItemVenda.NumNotaFisc,
                "@IdProd", objItemVenda.@IdProd,
                "@Nome", objItemVenda.Nome,
                "@Qtd", objItemVenda.Qtd,
                "@SubTotal", objItemVenda.SubTotal,
                "@IdVenda", objItemVenda.IdVenda,
                "@IdColab", objItemVenda.IdColab);
            }
        }

        public DataTable BuscarItemVenda()
        {
            DataTable venda = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT NumNotaFisc, IdProd, Nome, Qtd, SubTotal, IdVenda, IdColab
                FROM ItemVenda", out venda);
                return venda;
            }
        }

        public bool ExcluirItemVenda(int idProd)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM ItemVenda
                WHERE IdProd = @param", "@param", idProd);
            }
        }

        public DataTable BuscarNF(int nota)
        {
            DataTable dt = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT NumNotaFisc as Nº_Nota_Fiscal,
                         IdProd       as Código_Produto,
                         Nome         as Produto,
                         Qtd          as Quantidade,
                         SubTotal     as Sub_Total,
                         IdColab      as Código_Vendedor
                FROM ItemVenda
                WHERE NumNotaFisc = @param",
                out dt, "@param", nota.ToString());
                return dt;
            }
        }
    }
}
