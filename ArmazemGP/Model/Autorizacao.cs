using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class Autorizacao
    {
        public int IdAut { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Autorizacao()
        {

        }

        public Autorizacao(int idAut, string login, string senha)
        {
            IdAut = idAut;
            Login = login;
            Senha = senha;
        }

        public bool Gravar()
            => new AutorizacaoController().Gravar(this);
        public DataTable BuscarAuto()
            => new AutorizacaoController().BuscarAut(this.Login);
        public bool Excluir()
            => new AutorizacaoController().Excluir(this.IdAut);
        public DataTable BuscarAutPRelatorio()
            => new AutorizacaoController().BuscarAutPRelatorio(Login);
    }
}
