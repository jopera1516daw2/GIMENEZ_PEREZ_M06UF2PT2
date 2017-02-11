using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            XElement clientsXml = new XElement("tabla",
                from c in db.TableClients.AsEnumerable()
                select new XElement("clients",
                    c.id_client == null ? null : new XElement("id_client", c.id_client),
                    c.usuario == null ? null : new XElement("usuario", c.usuario),
                    c.password == null ? null : new XElement("password", c.password),
                    c.nom == null ? null : new XElement("nom", c.nom),
                    c.cognom1 == null ? null : new XElement("cognom1", c.cognom1),
                    c.cognom2 == null ? null : new XElement("cognom2", c.cognom2),
                    c.adreca == null ? null : new XElement("adreca", c.adreca),
                    c.codi_postal == null ? null : new XElement("codi_postal", c.codi_postal),
                    c.poblacio == null ? null : new XElement("poblacio", c.poblacio),
                    c.provincia == null ? null : new XElement("provincia", c.provincia),
                    c.telefon == null ? null : new XElement("telefon", c.telefon),
                    c.email == null ? null : new XElement("email", c.email),
                    c.fax == null ? null : new XElement("fax", c.fax),
                    c.type == null ? null : new XElement("type", c.type)));
            clientsXml.Save(@"..\XML\clients.xml");
            clientsXml.Save(@"..\XML\BACKUP\clients.xml");

            XElement comandaXml = new XElement("tabla",
                from c in db.TableComanda.AsEnumerable()
                select new XElement("comanda",
                    c.id_comanda == null ? null : new XElement("id_comanda", c.id_comanda),
                    c.n_factura == null ? null : new XElement("n_factura", c.n_factura),
                    c.id_client == null ? null : new XElement("id_client", c.id_client),
                    c.adreca_comanda == null ? null : new XElement("adreca_comanda", c.adreca_comanda)));
            comandaXml.Save(@"..\XML\comanda.xml");
            comandaXml.Save(@"..\XML\BACKUP\comanda.xml");

            XElement facturaXml = new XElement("tabla",
                from c in db.TableFactura.AsEnumerable()
                select new XElement("factura",
                    c.n_factura == null ? null : new XElement("n_factura", c.n_factura),
                    c.id_client == null ? null : new XElement("id_client", c.id_client),
                    c.data == null ? null : new XElement("data", c.data),
                    c.iva == null ? null : new XElement("iva", c.iva),
                    c.descompte == null ? null : new XElement("descompte", c.descompte)));
            facturaXml.Save(@"..\XML\factura.xml");
            facturaXml.Save(@"..\XML\BACKUP\factura.xml");

            XElement facturaDetallXml = new XElement("tabla",
                from c in db.TableFactura_detall.AsEnumerable()
                select new XElement("facturaDetall",
                    c.n_factura == null ? null : new XElement("n_factura", c.n_factura),
                    c.id_producte == null ? null : new XElement("id_producte", c.id_producte),
                    c.quantitat == null ? null : new XElement("quantitat", c.quantitat)));
            facturaDetallXml.Save(@"..\XML\facturaDetall.xml");
            facturaDetallXml.Save(@"..\XML\BACKUP\facturaDetall.xml");

            XElement producteXml = new XElement("tabla",
                from c in db.TableProductes.AsEnumerable()
                select new XElement("producte",
                    c.Id_producte == null ? null : new XElement("id_producte", c.Id_producte),
                    c.Producte == null ? null : new XElement("producte", c.Producte),
                    c.Preu == null ? null : new XElement("preu", c.Preu)));
            producteXml.Save(@"..\XML\producte.xml");
            producteXml.Save(@"..\XML\BACKUP\producte.xml");
            msg.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportAdmin i = new ImportAdmin();
            i.Show();

            this.Hide();
            
        }

        private void btAdminUser_Click(object sender, EventArgs e)
        {
            UsersAdmin u = new UsersAdmin();
            u.Show();

            this.Hide();
        }

        private void btAdminProductos_Click(object sender, EventArgs e)
        {
            ProductosAdmin u = new ProductosAdmin();
            u.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start s = new Start();
            s.Show();

            this.Hide();
        }
    }
}
