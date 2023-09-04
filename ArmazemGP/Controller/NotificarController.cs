using ArmazemGP.Model;

namespace ArmazemGP.Controller
{
    public class NotificarController
    {
        public bool AdicionarNotificacao(Notificar not)
            => new AssinanteController().AlterarStatusNotificacao(not.IdProd);

        public void RemoverNotificacoes(int IdColab, List<Produto> lista)
        {
            foreach (var item in lista)
            new AssinanteController().ExcluirNotificacao(IdColab, item.IdProd);
            MessageBox.Show("VOCÊ NÃO RECEBERÁ MAIS NOTIFICAÇÕES SOBRE ESTE PRODUTO!",
            "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Produto> BuscarProdutoNotificacao(int idColab)
            => new AssinanteController().ObterNotificacoesColab(idColab);
    }
}
