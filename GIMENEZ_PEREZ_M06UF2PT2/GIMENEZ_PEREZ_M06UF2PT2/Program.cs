using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2{
    static class Program{
        /// <summary>
        /// Main
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());

        }
    }
}

/*
    DELETE FROM public.clients;
    DELETE FROM public.factura;
    DELETE FROM public.comanda;
    DELETE FROM public.factura_detall;
    ALTER SEQUENCE clients_id_client_seq RESTART WITH 1
    ALTER SEQUENCE factura_n_factura_seq RESTART WITH 1
    ALTER SEQUENCE comanda_id_comanda_seq RESTART WITH 1
*/
