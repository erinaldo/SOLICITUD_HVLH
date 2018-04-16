using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



using Solicitud_de_Servicio_Interno_HVLH.Vista.Admin;

namespace Solicitud_de_Servicio_Interno_HVLH
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Frm_RegistrarAcceso());
            Application.Run(new FrmProbandoNroTick());
        }
    }
}
