using ArmazemGP.Model;
using ArmazemGP.View;

namespace ArmazemGP
{
    public static class Program
    {
        public static Colaborador UsuarioLogado = new Colaborador();
        public static Autorizacao UsuarioAutorizado = new Autorizacao();
        public static List<ProdutoOutput> Carrinho = new List<ProdutoOutput>();
        public static List<ItemVenda> Cesta = new List<ItemVenda>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ScreenLogin());
        }
    }
}