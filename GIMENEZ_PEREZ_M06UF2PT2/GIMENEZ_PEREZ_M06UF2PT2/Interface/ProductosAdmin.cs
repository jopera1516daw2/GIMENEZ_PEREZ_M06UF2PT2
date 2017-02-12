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
    /// Clase del formulario "ProductosAdmin"
    /// </summary>
    public partial class ProductosAdmin : Form {
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductosAdmin(){
            InitializeComponent();
        }
        /// <summary>
        /// Método que retrocede al formulario anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin();
            u.Show();

            this.Hide();
        }
        /// <summary>
        /// Método que gestiona visualmente la creación producto que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crear_CheckedChanged(object sender, EventArgs e) {
            if (crear.Checked == true){
                eliminar.Checked = false;
                precio.Visible = true;
                lprecio.Visible = true;
            }
            else{
                eliminar.Checked = true;
                precio.Visible = false;
                lprecio.Visible = false;
            }
        }
        /// <summary>
        /// Método que gestiona visualmente la eliminación del susodicho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminar_CheckedChanged(object sender, EventArgs e){
            if (eliminar.Checked == true){
                crear.Checked = false;
                precio.Visible = false;
                lprecio.Visible = false;
            }
            else{
                crear.Checked = true;
                precio.Visible = true;
                lprecio.Visible = true;
            }
        }
        /// <summary>
        /// Método que gestiona la eliminación/creación del producto dependiendo de lo que hayamos seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e){
            msg.Visible = false;
            if (crear.Checked == true){
                DB db = new DB();
                int nextId = -1;
                try{
                    var count = db.TableProductes.Count();
                    foreach (var p in db.TableProductes){
                        if (--count == 0){
                            nextId = p.Id_producte + 1;
                        }
                    }
                    if (nextId == -1 || nextId == 0){
                        nextId = 1;
                    }
                    var producte = new TableProductes{
                        Producte = producto.Text,
                        Preu = float.Parse(precio.Text),
                        Id_producte = nextId
                    };
                    db.TableProductes.Add(producte);
                    db.SaveChanges();
                    msg.Text = "Producto creado correctamente";
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Visible = true;
                }
                catch (Exception ex){
                    Console.WriteLine(ex);
                    msg.Text = "Error al crear el producto";
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Visible = true;
                }
            }
            else{
                try{
                    DB db = new DB();
                    db.TableProductes.RemoveRange(db.TableProductes.Where(x => x.Producte == producto.Text));
                    db.SaveChanges();
                    msg.Text = "Producto eliminado correctamente";
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Visible = true;
                }
                catch (Exception ex){
                    msg.Text = "Error al eliminar el producto";
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Visible = true;
                }
            }
        }
    }
}
