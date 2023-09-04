using ArmazemGP.Controller;

namespace ArmazemGP.Model
{
    public class Assinantes
    {
        public int IdAss { get; private set; }
        public int IdColab { get; private set; }
        public int IdProd { get; private set; }
        public bool Notificar { get; private set; }

        public Assinantes()
        {

        }

        public Assinantes(int idAss, int idColab, int idProd)
        {
            IdAss = idAss;
            IdColab = idColab;
            IdProd = idProd;
            Notificar = false;
        }

        public bool Gravar()
            => new AssinanteController().Gravar(this);

    }
}
