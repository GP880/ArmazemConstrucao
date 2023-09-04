using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace ArmazemGP.Controller
{
    public class ColaboradorController
    {
        public bool Gravar(Colaborador obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                string senhaHash = GerarHashSenha(obj.Senha);

                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Colaborador(CodColab, NomeColab, EmailLogin, Senha, Contato, NivelAcces, Foto)
                VALUES(@CodColab, @NomeColab, @EmailLogin, @Senha, @Contato, @NivelAcces, @Foto)",
                "@CodColab", obj.CodColab,
                "@NomeColab", obj.NomeColab,
                "@EmailLogin", obj.Email,
                "@Senha", senhaHash,
                "@Contato", obj.Contato,
                "@NivelAcces", obj.NivelAcess,
                "@Foto", obj.Foto);
            }
        }

        public static string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Converte para representação hexadecimal
                }
                return builder.ToString();
            }
        }

        public DataTable BuscarColab(string text)
        {
            DataTable prod = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Colaborador", out prod);
                return prod;
            }
        }

        public bool Excluir(int idColab)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Colaborador
                WHERE IdColab=@param", "@param", idColab);
            }
        }

        public bool Alterar(Colaborador colab)
        {
            using (BancoInstance banco = new BancoInstance())
            {
                // Verificar se a foto do produto foi alterada
                string query;
                if (colab.Foto == null)
                {
                    // Manter a foto existente no banco de dados
                    query = @"UPDATE Colaborador
                            SET CodColab = @1, NomeColab = @2, EmailLogin = @3, Senha = @4, Contato = @5, NivelAcces = @6
                            WHERE IdColab = @6";
                }
                else
                {
                    // Atualizar a foto do produto no banco de dados
                    query = @"UPDATE Colaborador
                            SET CodColab = @1, NomeColab = @2, EmailLogin = @3, Senha = @4, Contato = @5, NivelAcces = @6, Foto = @7
                            WHERE IdColab = @7";
                }

                string senhaHash = GerarHashSenha(colab.Senha);

                return banco.Banco.ExecuteNonQuery(query,
                 "@1", colab.CodColab,
                 "@2", colab.NomeColab,
                 "@3", colab.Email,
                 "@4", senhaHash,
                 "@5", colab.Contato,
                 "@6", colab.NivelAcess,
                 "@7", colab.Foto,
                 "@8", colab.IdColab);
            }
        }

        internal DataTable BuscarColab()
        {
            DataTable prod = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Colaborador", out prod);
                return prod;
            }
        }
        public DataTable BuscarColabPorCod(string text)
        {
            DataTable codColab = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT IdColab, CodColab, NomeColab, EmailLogin, Senha, Contato, NilvelAcces, Foto", out codColab);
                return codColab;
            }
        }

        public DataTable ColabJaExiste(string text)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM Colaborador " +
                "WHERE EmailLogin = @EmailLogin";
                banco.Banco.ExecuteQuery(sql, out jaExiste, "@EmailLogin", text);
            }
            return jaExiste;
        }

        public DataTable CoDRepetido(string cod)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM Colaborador " +
                "WHERE CodColab = @CodColab";
                banco.Banco.ExecuteQuery(sql, out jaExiste, "@CodColab", cod);
            }
            return jaExiste;
        }
    }
}
