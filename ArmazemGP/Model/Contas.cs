using ArmazemGP.Controller;
using System.Data;

namespace ArmazemGP.Model
{
    public class ContasPGR
    {
        public int IdConta { get; private set; }
        public string NomeConta { get; private set; }
        public int CodConta { get; private set; }
        public decimal ValConta { get; private set; }
        public DateTime DataInput { get; set; }
        public DateTime DataOut { get; set; }
        public string Obs { get; set; }

        public ContasPGR()
        {

        }

        public ContasPGR(int idConta, string nomeConta, int codConta, decimal valConta)
        {
            IdConta = idConta;
            NomeConta = nomeConta;
            CodConta = codConta;
            ValConta = valConta;
        }

        public ContasPGR(int idConta, string nomeConta, int codConta, decimal valConta, DateTime dataInput, DateTime dataOut)
        {
            IdConta = idConta;
            NomeConta = nomeConta;
            CodConta = codConta;
            ValConta = valConta;
            DataInput = dataInput;
            DataOut = dataOut;
        }

        public ContasPGR(int idConta, string nomeConta, int codConta, decimal valConta, string obs)
        {
            IdConta = idConta;
            NomeConta = nomeConta;
            CodConta = codConta;
            ValConta = valConta;
            Obs = obs;
        }

        public bool GravarConta()
            => new ContasPGRController().GravarConta(this);

        public decimal BuscarContasAPG()
            => new ContasPGRController().BuscarContasAPG(this.CodConta, DataInput, DataOut);

        public DataTable BuscarContaREC()
            => new ContasPGRController().BuscarContaREC(this.CodConta);

        public bool ExcluirConta()
            => new ContasPGRController().ExcluirConta(this.NomeConta);

        public bool AlterarConta()
            => new ContasPGRController().AlterarConta(this);
    }
}
