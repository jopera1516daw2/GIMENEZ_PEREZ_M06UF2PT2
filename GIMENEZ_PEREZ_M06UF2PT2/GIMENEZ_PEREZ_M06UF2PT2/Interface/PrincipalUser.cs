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
    /// Clase del formulario "PrincipalUser"
    /// </summary>
    public partial class PrincipalUser : Form{
        /// <summary>
        /// Constructor
        /// </summary>
        public PrincipalUser(){
            InitializeComponent();
        }
        /// <summary>
        /// Método para cerrar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            Start s = new Start();
            s.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para iniciar el formulario de "PedidoUser"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPedido_Click(object sender, EventArgs e){
            PedidosUser p = new PedidosUser();
            p.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para iniciar el formulario "PerfilUser"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e){
            PerfilUser p = new PerfilUser();
            p.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para iniciar el formulario "FacturaUser"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFactura_Click(object sender, EventArgs e){
            FacturasUser f = new FacturasUser();
            f.Show();

            this.Hide();
        }
    }
}
