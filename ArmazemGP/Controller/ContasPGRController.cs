using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;
using System.Data.SqlClient;

namespace ArmazemGP.Controller
{
    public class ContasPGRController
    {
        public bool GravarConta(ContasPGR obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO ContasPGR(NomeConta, CodConta, ValConta, DataInput, DataOut, Obs)
                VALUES(@NomeConta, @CodConta, @ValConta, @DataInput, @DataOut, @Obs)",
                "NomeConta", obj.NomeConta,
                "CodConta", obj.CodConta,
                "ValConta", obj.ValConta,
                "DataInput", obj.DataInput,
                "DataOut", obj.DataOut,
                "Obs", obj.Obs);
            }
        }

        public DataTable BuscarContas(int cod)
        {
            DataTable contas = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM ContasPGR
                WHERE CodConta = @cod",
                out contas, "@cod", cod);
                return contas;
            }
        }

        public DataTable BuscarContaREC(int codConta)
        {
            DataTable conta = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM ContasPGR
                WHERE CodConta = @var",
                out conta, "@var", codConta);
                return conta;
            }
        }

        public bool ExcluirConta(string text)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM ContasPGR
                WHERE NomeConta = @param", "@param", text);
            }
        }

        public bool AlterarConta(ContasPGR contasPGR)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"UPDATE ContasPGR
                SET NomeConta=@1, CodConta=@2, ValConta=@3, DataInput=@4, DataOut=@5, Obs=@6
                WHERE IdConta = @IdConta",
                "@1", contasPGR.NomeConta,
                "@2", contasPGR.CodConta,
                "@3", contasPGR.ValConta,
                "@4", contasPGR.DataInput,
                "@5", contasPGR.DataOut,
                "@6", contasPGR.Obs,
                "@IdConta", contasPGR.IdConta);
            }
        }

        public DataTable ContaRepetida(string cod)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM ContasPGR " +
                "WHERE NomeConta = @NomeConta";
                banco.Banco.ExecuteQuery(sql, out jaExiste, "@NomeConta", cod);
            }
            return jaExiste;
        }

        // add aqui:

        public decimal BuscarContasAPG(int codConta, DateTime dataIni, DateTime dataFin)
        {
            DataTable dt = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(ValConta) AS ContasAPG
                FROM ContasPGR
                WHERE CodConta = @CodConta
                AND DataOut >= @DataIni
                AND DataOut <= @DataFin",
                out dt,
                new SqlParameter("@CodConta", codConta),
                new SqlParameter("@DataIni", dataIni),
                new SqlParameter("@DataFin", dataFin));
            }
            if (dt.Rows.Count > 0)
            {
                decimal aPG = 0m;
                if (dt.Rows[0]["ContasAPG"] != DBNull.Value && decimal.TryParse(dt.Rows[0]["ContasAPG"].ToString(), out aPG))
                {
                    return aPG;
                }
            }
            return 0;
        }

        public decimal BuscarContasAPg()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT SUM(ValConta) AS ValAPG
                FROM ContasPGR
                WHERE CodConta = 1",
                out dt);
            }
            if (dt.Rows.Count > 0 && !Convert.IsDBNull(dt.Rows[0]["ValAPG"]))
            {
                decimal valorAPagar;
                if (decimal.TryParse(dt.Rows[0]["ValAPG"].ToString(), out valorAPagar))
                {
                    return valorAPagar;
                }
            }
            return 0;
        }
    }
}
