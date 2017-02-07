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
            int idProd = -1;
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
                try
                {
                    var count = db.TableFactura.Count();
                    foreach (var f in db.TableFactura)
                    {
                        if (--count == 0)
                        {
                            nfactura = f.n_factura+1;
                        }
                    }
                    Console.WriteLine(nfactura);
                    if (nfactura == -1 || nfactura == 0)
                    {
                        nfactura = 1;
                    }

                    var factura = new TableFactura
                    {
                        n_factura = nfactura,
                        id_client = id,
                        data = fecha.Value,
                        descompte = 0,
                        iva = 21
                    };
                    db.TableFactura.Add(factura);
                    db.SaveChanges();
                    
                    if(nfactura != -1) { 
                        foreach (var p in db.TableProductes)
                        {
                            if (p.Producte == producte)
                            {
                                idProd = p.Id_producte;
                                
                            }
                        }

                        if(idProd != -1)
                        {
                            var facturaDetall = new TableFactura_detall
                            {
                                n_factura = nfactura,
                                id_producte = idProd,
                                quantitat = quantitatP,
                                preu = preuP
                            };
                            db.TableFactura_detall.Add(facturaDetall);
                            db.SaveChanges();

                            int nCom = -1;
                            var count2 = db.TableComanda.Count();
                            foreach (var cm in db.TableComanda)
                            {
                                if (--count2 == 0)
                                {
                                    nCom = cm.id_comanda + 1;
                                }
                            }
                            if (nCom == -1 || nCom == 0)
                            {
                                nCom = 1;
                            }

                            var comanda = new TableComanda
                            {
                                id_comanda = nCom,
                                n_factura = nfactura,
                                id_client = id,
                                adreca_comanda = direccion.Text
                            };
                            db.TableComanda.Add(comanda);
                            db.SaveChanges();
                            msgCorrect.Visible = true;
                        }else
                        {
                            msgerror.Text = "Error al realizar el pedido";
                            msgerror.Visible = true;
                        }
                    }else
                    {
                        msgerror.Text = "Error al realizar el pedido";
                        msgerror.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    msgerror.Text = "Error al realizar el pedido";
                    msgerror.Visible = true;
                }
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
