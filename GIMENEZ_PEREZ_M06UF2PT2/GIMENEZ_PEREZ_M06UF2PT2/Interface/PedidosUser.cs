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
    /// Clase del formulario "PedidosUser"
    /// </summary>
    public partial class PedidosUser : Form{
        float precio = 0;
        /// <summary>
        /// COnstrucotr
        /// </summary>
        public PedidosUser(){
            InitializeComponent();
            bool contador = false;
            DB db = new DB();
            var productos = db.TableProductes;
            foreach (var p in productos){
                if (contador == false){
                    selectProductos.Text = p.Producte + "/" + p.Preu + "€";
                    this.precio = p.Preu;
                    textBox1.Text = this.precio.ToString();
                }                   
                selectProductos.Items.Add(p.Producte+"/"+p.Preu+"€");
                contador = true;
            }
        }
        /// <summary>
        /// Método para acceder al siguiente formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            PedidosNextUser p = new PedidosNextUser(selectProductos.Text.Split('/')[0], Convert.ToInt32(cantidad.Value), this.precio);
            p.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para volver atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser();
            u.Show();

            this.Hide();
        }
        /// <summary>
        /// Método para calcular el importe cada vez que aumentas la cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cantidad_ValueChanged_1(object sender, EventArgs e){
            string precioS = selectProductos.Text.Split('/')[1];
            float precio = float.Parse(precioS.Remove(precioS.Length - 1));
            int c = Convert.ToInt32(cantidad.Value);
            this.precio = precio * c;
            textBox1.Text = this.precio.ToString();
            Console.WriteLine(this.precio);

        }
    }
}
