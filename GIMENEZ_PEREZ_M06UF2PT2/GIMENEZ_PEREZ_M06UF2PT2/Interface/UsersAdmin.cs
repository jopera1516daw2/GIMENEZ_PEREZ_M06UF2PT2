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
    /// Clase del formulario "UsersAdmin"
    /// </summary>
    public partial class UsersAdmin : Form{
        /// <summary>
        /// Constructor
        /// </summary>
        public UsersAdmin(){
            InitializeComponent();
        }
        /// <summary>
        /// Método que retrocede al formulario principal para los administradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin();
            u.Show();

            this.Hide();
        }
        /// <summary>
        /// Método que crea un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crear_CheckedChanged(object sender, EventArgs e){
            if (crear.Checked == true){
                eliminar.Checked = false;
            }
            else{
                eliminar.Checked = true;
            }
        }
        /// <summary>
        /// Método que elimina un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminar_CheckedChanged(object sender, EventArgs e){
            if (eliminar.Checked == true){
                crear.Checked = false;
            }
            else{
                crear.Checked = true;
            }
        }
        /// <summary>
        /// Método que gestiona la opción que has seleccionado ya sea eliminar o crear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e){
            msg.Visible = false;
            if (crear.Checked == true){
                DB db = new DB();
                int nextId = -1;
                try{
                    var entra = true;
                    var lengthC = db.TableClients.Count();
                    foreach (var c in db.TableClients){
                        if (entra == true){
                            nextId = c.id_client + 1;
                            entra = false;
                        }
                    }
                    Console.WriteLine(nextId);
                    if (nextId == -1 || nextId == 0){
                        nextId = 1;
                    }
                    var cliente = new TableClients{
                        usuario = usuario.Text,
                        password = contraseña.Text,
                        type = 0,
                        codi_postal = 0,
                        telefon = 0,
                        fax = 0,
                        email = "",
                        poblacio = "",
                        provincia = "",
                        adreca = "",
                        cognom1 = "",
                        nom = "",
                        cognom2 = "",
                        id_client = nextId
                    };
                    db.TableClients.Add(cliente);
                    db.SaveChanges();
                    msg.Text = "Usuario creado correctamente";
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Visible = true;
                }
                catch (Exception ex){
                    Console.WriteLine(ex);
                    msg.Text = "Error al crear el usuario";
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Visible = true;
                }
            }
            else{
                try{
                    DB db = new DB();
                    db.TableClients.RemoveRange(db.TableClients.Where(x => x.usuario == usuario.Text && x.password == contraseña.Text));
                    db.SaveChanges();
                    msg.Text = "Usuario eliminado correctamente";
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Visible = true;
                }
                catch (Exception ex){
                    msg.Text = "Error al eliminar el usuario";
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Visible = true;
                }
            }
        }
    }
}
