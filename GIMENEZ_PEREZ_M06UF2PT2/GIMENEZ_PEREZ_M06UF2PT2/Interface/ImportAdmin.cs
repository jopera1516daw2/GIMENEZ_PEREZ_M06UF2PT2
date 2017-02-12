using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GIMENEZ_PEREZ_M06UF2PT2.Interface{
    /// <summary>
    /// CLase del formulario "ImportAdmin"
    /// </summary>
    public partial class ImportAdmin : Form{
        /// <summary>
        /// Constructor
        /// </summary>
        public ImportAdmin(){
            InitializeComponent();
        }
        /// <summary>
        /// Método para regresar al anterior formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin u = new GIMENEZ_PEREZ_M06UF2PT2.Interface.PrincipalAdmin();
            u.Show();

            this.Hide();
        }
        /// <summary>
        /// Método que se ocupa de eliminar la base de datos y crea una nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropandcreate_Click(object sender, EventArgs e){
            msg.Visible = false;
            try{
                DB db = new DB();
                db.TableClients.RemoveRange(db.TableClients.Where(x => x.id_client >= 0));
                db.SaveChanges();
                var doc = XDocument.Load(@"..\XML\clients.xml");
                foreach (XElement elem in doc.Descendants("clients")){
                    var cliente = new TableClients{
                        usuario = elem.Element("usuario").Value,
                        password = elem.Element("password").Value,
                        type = Convert.ToInt32(elem.Element("type").Value),
                        codi_postal = Convert.ToInt32(elem.Element("codi_postal").Value),
                        telefon = Convert.ToInt32(elem.Element("telefon").Value),
                        fax = Convert.ToInt32(elem.Element("fax").Value),
                        email = elem.Element("email").Value,
                        poblacio = elem.Element("poblacio").Value,
                        provincia = elem.Element("provincia").Value,
                        adreca = elem.Element("adreca").Value,
                        cognom1 = elem.Element("cognom1").Value,
                        nom = elem.Element("nom").Value,
                        cognom2 = elem.Element("cognom2").Value,
                        id_client = Convert.ToInt32(elem.Element("id_client").Value)
                    };
                    db.TableClients.Add(cliente);
                }
                db.SaveChanges();

                db.TableFactura.RemoveRange(db.TableFactura.Where(x => x.n_factura >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\factura.xml");
                foreach (XElement elem in doc.Descendants("factura"))
                {
                    var factura = new TableFactura
                    {
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_client = Convert.ToInt32(elem.Element("id_client").Value),
                        data = Convert.ToDateTime(elem.Element("data").Value),
                        iva = Convert.ToInt32(elem.Element("iva").Value),
                        descompte = Convert.ToInt32(elem.Element("descompte").Value),
                    };
                    db.TableFactura.Add(factura);
                }
                db.SaveChanges();

                db.TableProductes.RemoveRange(db.TableProductes.Where(x => x.Id_producte >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\productes.xml");
                foreach (XElement elem in doc.Descendants("productes"))
                {
                    var producteX = new TableProductes
                    {
                        Id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                        Producte = elem.Element("producte").Value,
                        Preu = Convert.ToInt32(elem.Element("preu").Value)
                    };
                    db.TableProductes.Add(producteX);
                }
                db.SaveChanges();

                db.TableFactura_detall.RemoveRange(db.TableFactura_detall.Where(x => x.n_factura >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\facturaDetall.xml");
                foreach (XElement elem in doc.Descendants("facturaDetall"))
                {
                    var factura_detall = new TableFactura_detall
                    {
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                        quantitat = Convert.ToInt32(elem.Element("quantitat").Value)
                    };
                    db.TableFactura_detall.Add(factura_detall);
                }
                db.SaveChanges();

                db.TableComanda.RemoveRange(db.TableComanda.Where(x => x.id_comanda >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\comanda.xml");
                foreach (XElement elem in doc.Descendants("comanda")){
                    var comanda = new TableComanda{
                        id_comanda = Convert.ToInt32(elem.Element("id_comanda").Value),
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_client = Convert.ToInt32(elem.Element("id_client").Value),
                        adreca_comanda =elem.Element("adreca_comanda").Value
                    };
                    db.TableComanda.Add(comanda);
                }
                db.SaveChanges();


                 msg.Visible = true;
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Método que se ocupa de eliminar la base de datos y crea una nueva del backup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undo_Click(object sender, EventArgs e)
        {
            msg.Visible = false;
            try
            {
                DB db = new DB();
                db.TableClients.RemoveRange(db.TableClients.Where(x => x.id_client >= 0));
                db.SaveChanges();
                var doc = XDocument.Load(@"..\XML\BACKUP\clients.xml");
                foreach (XElement elem in doc.Descendants("clients"))
                {
                    var cliente = new TableClients
                    {
                        usuario = elem.Element("usuario").Value,
                        password = elem.Element("password").Value,
                        type = Convert.ToInt32(elem.Element("type").Value),
                        codi_postal = Convert.ToInt32(elem.Element("codi_postal").Value),
                        telefon = Convert.ToInt32(elem.Element("telefon").Value),
                        fax = Convert.ToInt32(elem.Element("fax").Value),
                        email = elem.Element("email").Value,
                        poblacio = elem.Element("poblacio").Value,
                        provincia = elem.Element("provincia").Value,
                        adreca = elem.Element("adreca").Value,
                        cognom1 = elem.Element("cognom1").Value,
                        nom = elem.Element("nom").Value,
                        cognom2 = elem.Element("cognom2").Value,
                        id_client = Convert.ToInt32(elem.Element("id_client").Value)
                    };
                    db.TableClients.Add(cliente);
                }
                db.SaveChanges();

                db.TableFactura.RemoveRange(db.TableFactura.Where(x => x.n_factura >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\BACKUP\factura.xml");
                foreach (XElement elem in doc.Descendants("factura"))
                {
                    var factura = new TableFactura
                    {
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_client = Convert.ToInt32(elem.Element("id_client").Value),
                        data = Convert.ToDateTime(elem.Element("data").Value),
                        iva = Convert.ToInt32(elem.Element("iva").Value),
                        descompte = Convert.ToInt32(elem.Element("descompte").Value),
                    };
                    db.TableFactura.Add(factura);
                }
                db.SaveChanges();

                db.TableProductes.RemoveRange(db.TableProductes.Where(x => x.Id_producte >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\BACKUP\productes.xml");
                foreach (XElement elem in doc.Descendants("productes"))
                {
                    var producteX = new TableProductes
                    {
                        Id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                        Producte = elem.Element("producte").Value,
                        Preu = Convert.ToInt32(elem.Element("preu").Value)
                    };
                    db.TableProductes.Add(producteX);
                }
                db.SaveChanges();

                db.TableFactura_detall.RemoveRange(db.TableFactura_detall.Where(x => x.n_factura >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\BACKUP\facturaDetall.xml");
                foreach (XElement elem in doc.Descendants("facturaDetall"))
                {
                    var factura_detall = new TableFactura_detall
                    {
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                        quantitat = Convert.ToInt32(elem.Element("quantitat").Value)
                    };
                    db.TableFactura_detall.Add(factura_detall);
                }
                db.SaveChanges();

                db.TableComanda.RemoveRange(db.TableComanda.Where(x => x.id_comanda >= 0));
                db.SaveChanges();
                doc = XDocument.Load(@"..\XML\BACKUP\comanda.xml");
                foreach (XElement elem in doc.Descendants("comanda"))
                {
                    var comanda = new TableComanda
                    {
                        id_comanda = Convert.ToInt32(elem.Element("id_comanda").Value),
                        n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                        id_client = Convert.ToInt32(elem.Element("id_client").Value),
                        adreca_comanda = elem.Element("adreca_comanda").Value
                    };
                    db.TableComanda.Add(comanda);
                }
                db.SaveChanges();


                msg.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Método que inserta los elementos que falten de los xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void merge_Click(object sender, EventArgs e)
        {
            msg.Visible = false;
            try
            {
                DB db = new DB();
                var doc = XDocument.Load(@"..\XML\clients.xml");
                foreach (XElement elem in doc.Descendants("clients"))
                {
                    var insert = true;
                    foreach (var c in db.TableClients)
                    {
                        if (c.id_client == Convert.ToInt32(elem.Element("id_client").Value))
                        {
                            insert = false;
                        }
                    }
                    if (insert == true)
                    {
                        var cliente = new TableClients
                        {
                            usuario = elem.Element("usuario").Value,
                            password = elem.Element("password").Value,
                            type = Convert.ToInt32(elem.Element("type").Value),
                            codi_postal = Convert.ToInt32(elem.Element("codi_postal").Value),
                            telefon = Convert.ToInt32(elem.Element("telefon").Value),
                            fax = Convert.ToInt32(elem.Element("fax").Value),
                            email = elem.Element("email").Value,
                            poblacio = elem.Element("poblacio").Value,
                            provincia = elem.Element("provincia").Value,
                            adreca = elem.Element("adreca").Value,
                            cognom1 = elem.Element("cognom1").Value,
                            nom = elem.Element("nom").Value,
                            cognom2 = elem.Element("cognom2").Value,
                            id_client = Convert.ToInt32(elem.Element("id_client").Value)
                        };
                        db.TableClients.Add(cliente);
                    }
                }
                db.SaveChanges();
                
                doc = XDocument.Load(@"..\XML\factura.xml");
                foreach (XElement elem in doc.Descendants("factura"))
                {
                    var insert = true;
                    foreach (var f in db.TableFactura)
                    {
                        if (f.n_factura == Convert.ToInt32(elem.Element("n_factura").Value))
                        {
                            insert = false;
                        }
                    }
                    if (insert == true)
                    {
                        var factura = new TableFactura
                        {
                            n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                            id_client = Convert.ToInt32(elem.Element("id_client").Value),
                            data = Convert.ToDateTime(elem.Element("data").Value),
                            iva = Convert.ToInt32(elem.Element("iva").Value),
                            descompte = Convert.ToInt32(elem.Element("descompte").Value),
                        };
                        db.TableFactura.Add(factura);
                    }
                }
                db.SaveChanges();
                
                doc = XDocument.Load(@"..\XML\productes.xml");
                foreach (XElement elem in doc.Descendants("productes"))
                {
                    var insert = true;
                    foreach (var p in db.TableProductes)
                    {
                        if (p.Id_producte == Convert.ToInt32(elem.Element("id_producte").Value))
                        {
                            insert = false;
                        }
                    }
                    if (insert == true)
                    {
                        var producteX = new TableProductes
                        {
                            Id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                            Producte = elem.Element("producte").Value,
                            Preu = Convert.ToInt32(elem.Element("preu").Value)
                        };
                        db.TableProductes.Add(producteX);
                    }
                }
                db.SaveChanges();
                
                doc = XDocument.Load(@"..\XML\facturaDetall.xml");
                foreach (XElement elem in doc.Descendants("facturaDetall"))
                {
                    var insert = true;
                    foreach (var f in db.TableFactura_detall)
                    {
                        if (f.n_factura == Convert.ToInt32(elem.Element("n_factura").Value) && f.id_producte == Convert.ToInt32(elem.Element("id_producte").Value))
                        {
                            insert = false;
                        }
                    }
                    if (insert == true)
                    {
                        var factura_detall = new TableFactura_detall
                        {
                            n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                            id_producte = Convert.ToInt32(elem.Element("id_producte").Value),
                            quantitat = Convert.ToInt32(elem.Element("quantitat").Value)
                        };
                        db.TableFactura_detall.Add(factura_detall);
                    }
                }
                db.SaveChanges();

                doc = XDocument.Load(@"..\XML\comanda.xml");
                foreach (XElement elem in doc.Descendants("comanda"))
                {
                    var insert = true;
                    foreach (var c in db.TableComanda)
                    {
                        if (c.id_comanda == Convert.ToInt32(elem.Element("id_comanda").Value))
                        {
                            insert = false;
                        }
                    }
                    if (insert == true)
                    {
                        var comanda = new TableComanda
                        {
                            id_comanda = Convert.ToInt32(elem.Element("id_comanda").Value),
                            n_factura = Convert.ToInt32(elem.Element("n_factura").Value),
                            id_client = Convert.ToInt32(elem.Element("id_client").Value),
                            adreca_comanda = elem.Element("adreca_comanda").Value
                        };
                        db.TableComanda.Add(comanda);
                    }
                }
                db.SaveChanges();


                msg.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
