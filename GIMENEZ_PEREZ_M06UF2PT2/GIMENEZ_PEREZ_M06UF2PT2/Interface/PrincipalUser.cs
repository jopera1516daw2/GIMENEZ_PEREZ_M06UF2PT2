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
    public partial class PrincipalUser : Form
    {
        public PrincipalUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Start s = new Start();
            s.Show();

            this.Hide();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            PedidosUser p = new PedidosUser();
            p.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PerfilUser p = new PerfilUser();
            p.Show();

            this.Hide();
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            FacturasUser f = new FacturasUser();
            f.Show();

            this.Hide();
        }
    }
}
