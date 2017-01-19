using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var db = new DB();
            var pet = new TableProducte { Id_producte = 2, Producte = "Harambe's soul", Preu = 100 };
            db.TableProductes.Add(pet);
            db.SaveChanges();

            var productes = db.TableProductes;
            foreach (var p in productes)
            {
                Console.WriteLine(p.Producte);
            }
            Console.Read();
        }
    }
}
