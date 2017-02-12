using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GIMENEZ_PEREZ_M06UF2PT2{
    /// <summary>
    /// Clase del formulario con el que inicia la app
    /// </summary>
    public partial class Start : Form{
        /// <summary>
        /// Construcor de la clase start
        /// </summary>
        public Start(){
            InitializeComponent();
            DB db = new DB();
        }
        /// <summary>
        /// Botón para acceder al formulario de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            this.Hide();

        }
        /// <summary>
        /// Bontón para acceder al formulario de crear usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            NewUser nw1 = new NewUser();
            nw1.Show();

            this.Hide();
        }
    }
}
