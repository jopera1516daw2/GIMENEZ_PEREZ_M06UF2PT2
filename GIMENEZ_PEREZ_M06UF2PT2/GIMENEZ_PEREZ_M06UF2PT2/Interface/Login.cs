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
    public partial class Login : Form
    {
        public Login()
        {
            msgerror.Visible = false;
            InitializeComponent();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool entra = false;
            DB db = DB.getInstance();
            var clientes = db.TableClients;
            foreach (var c in clientes)
            {
                if (c.usuario == userL.Text && c.password == pass.Text)
                    entra = true;
            }

            if (entra)
            {
                msgerror.Visible = false;

            }
            else {
                userL.Text = "";
                pass.Text = "";
                msgerror.Visible = true;
            }

        }
    }
}
