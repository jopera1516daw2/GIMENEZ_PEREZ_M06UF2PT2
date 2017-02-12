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
    /// Clase del formulario "RestorePass"
    /// </summary>
    public partial class RestorePass : Form{
        /// <summary>
        /// Constructor
        /// </summary>
        public RestorePass(){
            InitializeComponent();
            msgconfirm.Visible = false;
            msgerror.Visible = false;
        }
        /// <summary>
        /// Método que comprueba que tanto el nombre del usuario como su "nickName" sean iguales para modificar la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            msgconfirm.Visible = false;
            msgerror.Visible = false;
            bool correcto = false;

            try{
                using (var db = new DB()){
                    var result = db.TableClients.Where(c2 => c2.usuario == rpUser.Text && c2.nom == rpNombre.Text).SingleOrDefault();
                    result.password = rpNewPassword.Text;
                    db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    correcto = true;
                }
            }
            catch (Exception ex){
                correcto = false;
                Console.WriteLine(ex);
            }

            if (correcto){
                msgconfirm.Visible = true;
            }
            else{
                msgerror.Visible = true;
            }
        }
        /// <summary>
        /// Método que retrocede al formulario en el que estabas antes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            Login l1 = new Login();
            l1.Show();

            this.Hide();
        }
        
    }
}
