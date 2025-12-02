using GestorDeMovimientos.Forms;

namespace GestorDeMovimientos
{
    internal static class Program
    {
        /// <summary>
        ///  Poder tener una gestion de los gastos e ingresos que realizas en tu dia a dia 
        ///  para saber en que gastas tu dinero y poder ahorrar mejor.
        /// </summary>
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            Configuration.ConfigManager.LoadOrCreateDefault();

            Application.Run(new FormPrincipal());
        }
    }
}