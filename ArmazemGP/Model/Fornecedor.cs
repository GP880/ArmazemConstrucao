using ArmazemGP.Controller;

namespace ArmazemGP.Model
{
    public class Fornecedor
    {
        public int IdFornec { get; private set; }
        public string NomeFornec { get; private set; }
        public string Email { get; private set; }
        public string Contato { get; private set; }
        public string NomeFanta { get; private set; }
        public string RazSoci { get; private set; }
        public string Cnpj { get; private set; }
        public string TelEmp { get; private set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int idFornec, string nomeFornec, string email, string contato, string nomeFanta, string razSoci, string cnpj, string telEmp)
        {
            IdFornec = idFornec;
            NomeFornec = nomeFornec;
            Email = email;
            Contato = contato;
            NomeFanta = nomeFanta;
            RazSoci = razSoci;
            Cnpj = cnpj;
            TelEmp = telEmp;
        }

        public Fornecedor(string nomeFornec, string cnpj)
        {
            NomeFornec = nomeFornec;
            Cnpj = cnpj;
        }

        public bool Gravar()
            => new FornecedorController().Gravar(this);
        public bool Excluir()
            => new FornecedorController().Excluir(this);
        public bool Alterar()
            => new FornecedorController().Alterar(this);
    }
}
