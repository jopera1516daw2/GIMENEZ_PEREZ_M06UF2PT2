using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    public partial class FacturasUser : Form
    {
        public FacturasUser()
        {
            InitializeComponent();

            //table.RowCount = table.RowCount;
            //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            table.Controls.Add(new Label() { Text = "Factura" }, 0, 0);
            table.Controls.Add(new Label() { Text = "Producto" }, 1, 0);
            table.Controls.Add(new Label() { Text = "Cantidad" }, 2, 0);
            table.Controls.Add(new Label() { Text = "Importe" }, 3, 0);

            DB db = new DB();
            Config config = Config.getInstance();
            config.currentUser = "user";
            foreach (var c in db.TableClients)
            {
                if (c.usuario == config.currentUser)
                {
                    Console.WriteLine(c.usuario);
                    Console.WriteLine(c.id_client);
                    foreach (var f in db.TableFactura)
                    {
                        if (f.id_client == c.id_client)
                        {
                            Console.WriteLine(f.n_factura);
                            foreach (var fd in db.TableFactura_detall)
                            {
                                if (fd.n_factura == f.n_factura)
                                {
                                    Console.WriteLine(Convert.ToString(f.n_factura) + " / " + Convert.ToString(fd.id_producte) + " / " + Convert.ToString(fd.quantitat) + " / " + Convert.ToString(fd.preu) + " / ");
                                    table.RowCount = table.RowCount + 1;
                                    table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                                    table.Controls.Add(new Label() { Text = Convert.ToString(f.n_factura) }, 0, table.RowCount + 1);
                                    table.Controls.Add(new Label() { Text = Convert.ToString(fd.id_producte) }, 1, table.RowCount + 1);
                                    table.Controls.Add(new Label() { Text = Convert.ToString(fd.quantitat) }, 2, table.RowCount + 1);
                                    table.Controls.Add(new Label() { Text = Convert.ToString(fd.preu) }, 3, table.RowCount + 1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
