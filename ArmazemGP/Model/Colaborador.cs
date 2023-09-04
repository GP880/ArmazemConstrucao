using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class Colaborador
    {
        public int IdColab { get; private set; }
        public int CodColab { get; private set; }
        public string NomeColab { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Contato { get; private set; }
        public int NivelAcess { get; private set; }
        public byte[] Foto { get; set; }

        public Colaborador()
        {

        }

        public Colaborador(int idColab, int codColab, string nomeColab, string email, string senha, int nivelAcess)
        {
            IdColab = idColab;
            CodColab = codColab;
            NomeColab = nomeColab;
            Email = email;
            Senha = senha;
            NivelAcess = nivelAcess;
        }
        public Colaborador(int idColab, string nomeColab, string email, string senha, int nivelAcess)
        {
            IdColab = idColab;
            NomeColab = nomeColab;
            Email = email;
            Senha = senha;
            NivelAcess = nivelAcess;
        }

        public Colaborador(int idColab, int codColab, string nomeColab, string email, string senha, int nivelAcess, byte[] foto)
        {
            IdColab = idColab;
            CodColab = codColab;
            NomeColab = nomeColab;
            Email = email;
            Senha = senha;
            NivelAcess = nivelAcess;
            Foto = foto;
        }

        public Colaborador(int idColab, int codColab, string nomeColab, string email, string senha, string contato, int nivelAcess, byte[] foto)
        {
            IdColab = idColab;
            CodColab = codColab;
            NomeColab = nomeColab;
            Email = email;
            Senha = senha;
            Contato = contato;
            NivelAcess = nivelAcess;
            Foto = foto;
        }

        public Colaborador(int idColab)
        {
            IdColab = idColab;
        }

        public bool Gravar()
            => new ColaboradorController().Gravar(this);
        public bool Alterar()
            => new ColaboradorController().Alterar(this);
        public bool Excluir()
            => new ColaboradorController().Excluir(this.IdColab);
        public DataTable ColabJaExiste()
            => new ColaboradorController().ColabJaExiste(this.Email);
    }
}
