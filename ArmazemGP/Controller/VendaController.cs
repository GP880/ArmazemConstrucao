using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class VendaController
    {
        public int Gravar(Venda obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Venda(IdItens, NumNotaFisc, CodColab, ValTot, IdColab, Desconto, Dinheiro, CartDeb, CartCred, Pix, Data)
                VALUES(@IdItens, @NumNotaFisc, @CodColab, @ValTot, @IdColab, @Desconto, @Dinheiro, @CartDeb, @CartCred, @Pix, @Data)",
                "IdItens", obj.IdItens,
                "NumNotaFisc", obj.NumNotaFisc,
                "CodColab", obj.CodColab,
                "ValTot", obj.ValTot,
                "IdColab", obj.IdColab,
                "Desconto", obj.Desconto,
                "Dinheiro", obj.Dinheiro,
                "CartDeb", obj.CartDeb,
                "CartCred", obj.CartCred,
                "Pix", obj.Pix,
                "Data", obj.Data);
            }
            using(banco = new BancoInstance())
            {
                DataTable dt = new DataTable();
                banco.Banco.ExecuteQuery(
                    @"SELECT IdVenda FROM Venda ORDER BY IdVenda Desc", out dt);
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }

        public bool Excluir(int idVenda)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Venda
                WHERE IdVenda = @param", "@param", idVenda);
            }
        }

        public DataTable BuscarVenda()
        {
            DataTable venda = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT NumNotaFisc, CodColab, ValTot, Desconto, Dinheiro, CartDeb, CartCred, Pix, Data
                FROM Venda", out venda);
                return venda;
            }
        }

        public decimal BuscarFatCred()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(CartCred) AS FatCred
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["FatCred"] != DBNull.Value)
            {
                decimal fatCred;
                if (decimal.TryParse(dt.Rows[0]["FatCred"].ToString(), out fatCred))
                {
                    return fatCred;
                }
            }
            return 0;
        }

        public decimal BuscarFatDeb()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(CartDeb) AS FatDeb
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["FatDeb"] != DBNull.Value)
            {
                decimal fatDeb;
                if (decimal.TryParse(dt.Rows[0]["FatDeb"].ToString(), out fatDeb))
                {
                    return fatDeb;
                }
            }
            return 0;
        }

        public decimal BuscarFaturaValorTotal()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(ValTot) AS FatTotal
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0)
            {
                decimal valorTotal;
                if (dt.Rows[0]["FatTotal"] != DBNull.Value && decimal.TryParse(dt.Rows[0]["FatTotal"].ToString(), out valorTotal))
                {
                    return valorTotal;
                }
            }
            return 0;
        }

        public decimal BuscarFatPix()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(Pix) AS FatPix
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["FatPix"] != DBNull.Value)
            {
                decimal fatPix;
                if (decimal.TryParse(dt.Rows[0]["FatPix"].ToString(), out fatPix))
                {
                    return fatPix;
                }
            }
            return 0;
        }

        public decimal BuscarFatDin()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(Dinheiro) AS FatDin
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["FatDin"] != DBNull.Value)
            {
                decimal fatDin;
                if (decimal.TryParse(dt.Rows[0]["FatDin"].ToString(), out fatDin))
                {
                    return fatDin;
                }
            }
            return 0;
        }

        public decimal BuscarDescontos()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(Desconto) AS Descontos
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["Descontos"] != DBNull.Value)
            {
                decimal descontos;
                if (decimal.TryParse(dt.Rows[0]["Descontos"].ToString(), out descontos))
                {
                    return descontos;
                }
            }
            return 0;
        }

        public decimal BuscarSubTot()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(ValTot + Desconto) AS SubTot
                FROM Venda",
                out dt);
            }
            if (dt.Rows.Count > 0 && dt.Rows[0]["SubTot"] != DBNull.Value)
            {
                decimal SubTot;
                if (decimal.TryParse(dt.Rows[0]["SubTot"].ToString(), out SubTot))
                {
                    return SubTot;
                }
            }
            return 0;
        }
    }
}
