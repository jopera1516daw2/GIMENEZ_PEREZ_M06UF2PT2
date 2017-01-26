using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser nw1 = new NewUser();
            nw1.Show();

            this.Hide();
        }
    }
}
