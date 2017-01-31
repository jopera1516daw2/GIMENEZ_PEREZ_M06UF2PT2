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
    public partial class RestorePass : Form
    {
        public RestorePass()
        {
            InitializeComponent();
            msgconfirm.Visible = false;
            msgerror.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgconfirm.Visible = false;
            msgerror.Visible = false;
            bool correcto = false;

            try
            {
                using (var db = DB.getInstance())
                {
                    var result = db.TableClients.Where(c2 => c2.usuario == rpUser.Text && c2.nom == rpNombre.Text).SingleOrDefault();
                    result.password = rpNewPassword.Text;
                    db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    correcto = true;
                }
            }
            catch (Exception ex)
            {
                correcto = false;
                Console.WriteLine(ex);
            }

            if (correcto)
            {
                msgconfirm.Visible = true;
            }
            else
            {
                msgerror.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            this.Hide();
        }
    }
}
