using ArmazemGP.Controller;

namespace ArmazemGP.Model
{
    public class Notificar
    {
        public int IdProd { get; private set; }
        public int IdColab { get; private set; }

        public Notificar()
        {

        }

        public Notificar(int idProd, int idColab)
        {
            IdProd = idProd;
            IdColab = idColab;
        }

        public bool AdicionarNotificacao()
            => new NotificarController().AdicionarNotificacao(this);
    }
}
