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
        int quantitatP;
        float preuP;

        public PedidosNextUser(string producte, int quantitat, float preu)
        {
            InitializeComponent();
            producto.Text = producte;
            cantidad.Text = Convert.ToString(quantitat);
            precio.Text = Convert.ToString(preu);
            this.producte = producte;
            this.quantitatP = quantitat;
            this.preuP = preu;
            DB db = new DB();
            Config config = Config.getInstance();
            usuario.Text = config.currentUser;
            direccion.Text = config.currentDireccion;
            msgCorrect.Visible = false;
            msgerror.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgCorrect.Visible = false;
            msgerror.Visible = false;
            int id = -1;
            int nfactura = -1;
            DB db = new DB();
            foreach (var c in db.TableClients)
            {
                if (c.usuario == usuario.Text && c.password == password.Text)
                {
                    id = c.id_client;
                }
            }

            if (id != -1)
            {
                /*try
                {*/
                    Console.WriteLine("Entra1");
                    var factura = new TableFactura
                    {
                        id_client = id,
                        data = fecha.Value,
                        descompte = 0,
                        iva = 21
                    };
                    db.TableFactura.Add(factura);
                    db.SaveChanges();

                    Console.WriteLine("Entra2");

                    var count = db.TableFactura.Count();
                    foreach (var f in db.TableFactura)
                    {
                        if (--count == 0)
                        {
                            nfactura = f.n_factura;
                        }
                    }
                    
                    if(nfactura != -1) { 
                        foreach (var p in db.TableProductes)
                        {
                            if (p.Producte == producte)
                            {
                                Console.WriteLine(nfactura);
                                Console.WriteLine(p.Id_producte);
                                Console.WriteLine(quantitatP);
                                var facturaDetall = new TableFactura_detall
                                {
                                    n_factura = nfactura,
                                    id_producte = p.Id_producte,
                                    quantitat = quantitatP,
                                    preu = preuP
                                };
                                db.TableFactura_detall.Add(facturaDetall);
                                db.SaveChanges();
                                var comanda = new TableComanda
                                {
                                    n_factura = nfactura,
                                    id_client = id,
                                    adreca_comanda = direccion.Text
                                };
                                db.TableComanda.Add(comanda);
                                db.SaveChanges();
                                msgCorrect.Visible = true;
                            }
                        }
                    }else
                    {
                        msgerror.Text = "Error al realizar el pedido";
                        msgerror.Visible = true;
                    }
                /*}
                catch (Exception ex)
                {
                    msgerror.Text = "Error al realizar el pedido";
                    msgerror.Visible = true;
                }*/
            }else
            {
                msgerror.Text = "Contraseña incorrecta";
                msgerror.Visible = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalUser();
            u.Show();

            this.Hide();
        }
    }
}
