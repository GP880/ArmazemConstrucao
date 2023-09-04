using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;

namespace ArmazemGP.Controller
{
    public class FornecedorController
    {
        public bool Gravar(Fornecedor obj)
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Fornecedor(NomeFornec, Email, Contato, NomeFanta, RazSoci, Cnpj, TelEmp)
                VALUES(@NomeFornec, @Email, @Contato, @NomeFanta, @RazSoci, @Cnpj, @TelEmp)",
                "@NomeFornec",obj.NomeFornec,
                "@Email", obj.Email,
                "@Contato", obj.Contato,
                "@NomeFanta", obj.NomeFanta,
                "@RazSoci", obj.RazSoci,
                "@Cnpj", obj.Cnpj,
                "@TelEmp", obj.TelEmp);
            }
        }

        public DataTable VerSeJaExiste(string text)
        {
            DataTable jaExiste = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT IdFornec, NomeFornec, Email, Contato, NomeFanta, RazSoci, Cnpj, TelEmp", out jaExiste);
                return jaExiste;
            }
        }

        public DataTable BuscarFornec()
        {
            DataTable fornec = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Fornecedor", out fornec);
                return fornec;
            }
        }

        public bool Excluir(Fornecedor fornecedor)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Fornecedor
                WHERE IdFornec=@param", "@param", fornecedor);
            }
        }

        public bool Alterar(Fornecedor fornecedor)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"UPDATE Fornecedor
                SET NomeFornec=@1, Email=@2, Contato=@3, NomeFanta=@4, RazSoci=@5, Cnpj=@6, TelEmp=@7
                WHERE IdFornec = @idFornec",
                "@1", fornecedor.NomeFornec,
                "@2", fornecedor.Email,
                "@3", fornecedor.Contato,
                "@4", fornecedor.NomeFanta,
                "@5", fornecedor.RazSoci,
                "@6", fornecedor.Cnpj,
                "@7", fornecedor.TelEmp,
                "@IdFornec", fornecedor.IdFornec);
            }
        }

        public bool Excluir(int idFornec)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Fornecedor
                WHERE IdFornec=@param", "@param", idFornec);
            }
        }

        public DataTable CNPJRepetido(string pj)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM Fornecedor " +
                "WHERE Cnpj = @Cnpj";
                banco.Banco.ExecuteQuery(sql, out jaExiste, "@Cnpj", pj);
            }
            return jaExiste;
        }
    }
}
