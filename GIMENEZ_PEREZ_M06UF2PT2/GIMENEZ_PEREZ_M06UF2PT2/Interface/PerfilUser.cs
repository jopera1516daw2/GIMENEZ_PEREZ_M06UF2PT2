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
    /// CLase del formulario "PerfilUser"
    /// </summary>
    public partial class PerfilUser : Form{
        /// <summary>
        /// Constructor 
        /// </summary>
        public PerfilUser(){
            InitializeComponent();
            DB db = new DB();
            Config config = Config.getInstance();

            usuario.Text = config.currentUser;
            foreach (var c in db.TableClients){
                if (c.usuario == config.currentUser){
                    password.Text = c.password;
                    nombre.Text = c.nom;
                    apellido1.Text = c.cognom1;
                    apellido2.Text = c.cognom2;
                    cpostal.Text = Convert.ToString(c.codi_postal);
                    provincia.Text = c.provincia;
                    poblacion.Text = c.poblacio;
                    telefono.Text = Convert.ToString(c.telefon);
                    fax.Text = Convert.ToString(c.fax);
                    direccion.Text = c.adreca;
                    email.Text = c.email;
                }
            }
        }
        /// <summary>
        /// Método para regresar al anterior formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser();
            u.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para guardar los datos que hemos modificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            msgconfirm.Visible = false;
            msgerror.Visible = false;
            String pass = password.Text;
            String n = nombre.Text;
            String a1 = apellido1.Text;
            String a2 = apellido2.Text;
            int cp = Convert.ToInt32(cpostal.Text);
            String pv = provincia.Text;
            String pb = poblacion.Text;
            int tlf = Convert.ToInt32(telefono.Text);
            int fx = Convert.ToInt32(fax.Text);
            String dir = direccion.Text;
            String em = email.Text;
            Config config = Config.getInstance();
            try{
                using (var db = new DB()){
                    var result = db.TableClients.Where(c2 => c2.usuario == config.currentUser).SingleOrDefault();
                    result.password = pass;
                    result.nom = n;
                    result.cognom1 = a1;
                    result.cognom2 = a2;
                    result.codi_postal = cp;
                    result.provincia = pv;
                    result.poblacio = pb;
                    result.telefon = tlf;
                    result.fax = fx;
                    result.adreca = dir;
                    result.email = em;
                    db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    msgconfirm.Visible = true;
                    config.currentDireccion = dir;
                }
            }
            catch (Exception ex){
                msgerror.Visible = true;
            }
        }
    }
}
