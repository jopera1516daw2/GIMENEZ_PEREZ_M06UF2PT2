using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2.Interface{
    /// <summary>
    /// Clase del formulario "FacturaUser"
    /// </summary>
    public partial class FacturasUser : Form{
        /// <summary>
        /// Constructor
        /// </summary>
        public FacturasUser(){
            InitializeComponent();

            //table.RowCount = table.RowCount;
            //table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            table.Controls.Add(new Label() { Text = "Factura" }, 0, 0);
            table.Controls.Add(new Label() { Text = "Producto" }, 1, 0);
            table.Controls.Add(new Label() { Text = "Cantidad" }, 2, 0);
            table.Controls.Add(new Label() { Text = "Importe" }, 3, 0);

            try{
                int id = 0;
                var factura = new List<int>();

                DB db = new DB();
                Config config = Config.getInstance();
                config.currentUser = "user";
                foreach (var c in db.TableClients){
                    if (c.usuario == config.currentUser){
                        id = c.id_client;
                    }
                }
                
                int contador = 0;
                foreach (var f in db.TableFactura){
                    if (f.id_client == id){
                        factura.Add(f.n_factura);
                        contador++;
                    }
                }
                
                for (int i = 0; i < factura.Count; i++){
                    foreach (var fd in db.TableFactura_detall){
                        if (fd.n_factura == factura[i]){
                            Console.WriteLine(Convert.ToString(fd.n_factura) + " / " + Convert.ToString(fd.id_producte) + " / " + Convert.ToString(fd.quantitat) + " / " + Convert.ToString(fd.preu) + " / ");

                            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            table.RowCount += 1;
                            table.Controls.Add(new Label() { Text = Convert.ToString(fd.n_factura) }, 0, table.RowCount - 1);
                            table.Controls.Add(new Label() { Text = Convert.ToString(fd.id_producte) }, 1, table.RowCount - 1);
                            table.Controls.Add(new Label() { Text = Convert.ToString(fd.quantitat) }, 2, table.RowCount - 1);
                            table.Controls.Add(new Label() { Text = Convert.ToString(fd.preu) }, 3, table.RowCount - 1);
                        }
                    }
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex); // or log to file, etc.
                //throw;
            }
        }
        /// <summary>
        /// Método para regresar al formulario anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser();
            u.Show();

            this.Hide();
        }
    }
}
