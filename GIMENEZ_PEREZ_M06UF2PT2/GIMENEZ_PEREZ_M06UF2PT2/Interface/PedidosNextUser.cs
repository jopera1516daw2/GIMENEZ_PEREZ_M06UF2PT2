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
    public partial class PedidosNextUser : Form
    {
        string producte;
        int quantitat;
        int preu;

        public PedidosNextUser(string producte, int quantitat, int preu)
        {
            this.producte = producte;
            this.quantitat = quantitat;
            this.preu = preu;
            InitializeComponent();
            Console.WriteLine(this.producte + " / " + this.quantitat + " / " +this.preu);
        }
    }
}
