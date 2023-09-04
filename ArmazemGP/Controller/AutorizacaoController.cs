using ArmazemGP.DAO;
using ArmazemGP.Model;
using System.Data;
using System.Data.SqlClient;

namespace ArmazemGP.Controller
{
    public class AutorizacaoController
    {
        public bool Gravar(Autorizacao obj)
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"INSERT INTO Autorizacao(Login, Senha)
                VALUES(@Login, @Senha)",
                "@Login", obj.Login,
                "@Senha", obj.Senha);
            }
        }

        public bool Excluir(int idAut)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                @"DELETE FROM Autorizacao
                WHERE IdAut=@param", "@param", idAut);
            }
        }

        public DataTable BuscarAutorizacao(string senha)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Autorizacao", out dt);
                return dt;
            }
        }

        public DataTable BuscarAuto(string login)
        {
            DataTable auto = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                @"SELECT * FROM Autorizacao", out auto);
                return auto;
            }
        }

        public DataTable VerSeJaExiste(string email)
        {
            DataTable jaExiste = new DataTable();
            using (BancoInstance banco = new BancoInstance())
            {
                string sql = "SELECT * FROM Autorizacao" +
                "WHERE Login = @Email";
                banco.Banco.ExecuteQuery(
                sql,
                out jaExiste,
                "@Email", email);
            }
                return jaExiste;
        }
 
        public DataTable BuscarAut(string Login)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteNonQuery(
                @"SELECT Login
                FROM Autorizacao
                WHERE Email = @param", "@param", Login);
                return dt;
            }
        }

        public DataTable BuscarAutPRelatorio(string text)
        {
            DataTable dt = new DataTable();                      // VERIFICAR SE ESTA STRING É DO BANCO DE DADOS OU DA IMAGEM
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\George\\Desktop\\Armazem.ConstruLar\\ArmazemGP\\ArmazemGP\\DAO\\Banco.mdf;Integrated Security=True"))
            {
                string query = "SELECT * FROM Autorizacao WHERE Login = @param";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@param", text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
