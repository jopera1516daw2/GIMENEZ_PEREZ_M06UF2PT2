using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2{
    /// <summary>
    /// Clase que contiene el formulario de "login"
    /// </summary>
    public partial class Login : Form{
        /// <summary>
        /// Construcotor de la clase login
        /// </summary>
        public Login() {
            InitializeComponent();
            msgerror.Visible = false;
        }

        /// <summary>
        /// Método que da paso al formulario para recuperar la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            GIMENEZ_PEREZ_M06UF2PT2.Interface.RestorePass r = new GIMENEZ_PEREZ_M06UF2PT2.Interface.RestorePass();
            r.Show();

            this.Hide();
        }

        /// <summary>
        /// Método que se encarga de hacer la comprobación en base de datos para ver si el usuario existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e) {
            msgerror.Visible = false;
            bool entra = false;
            bool entraAdmin = false;
            DB db = new DB();
            GIMENEZ_PEREZ_M06UF2PT2.Interface.Config config = GIMENEZ_PEREZ_M06UF2PT2.Interface.Config.getInstance();
            var clientes = db.TableClients;
            foreach (var c in clientes)
            {
                if (c.usuario == userL.Text && c.password == pass.Text)
                {
                    if(c.type == 0)
                    {
                        config.currentUser = userL.Text;
                        config.currentDireccion = c.adreca;
                        entra = true;

                    }else
                    {
                        entraAdmin = true;
                    }
                }
            }

            if (entraAdmin)
            {
                msgerror.Visible = false;
                GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin a = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin();
                a.Show();

                this.Hide();

            }
            else if (entra) {
                msgerror.Visible = false;
                GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser();
                u.Show();

                this.Hide();
            }
            else {
                userL.Text = "";
                pass.Text = "";
                msgerror.Visible = true;
            }

        }
        /// <summary>
        /// Método que comunica el actual formulario con el siguiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            msgerror.Visible = false;
            Start s = new Start();
            s.Show();

            this.Hide();
        }
    }
}
