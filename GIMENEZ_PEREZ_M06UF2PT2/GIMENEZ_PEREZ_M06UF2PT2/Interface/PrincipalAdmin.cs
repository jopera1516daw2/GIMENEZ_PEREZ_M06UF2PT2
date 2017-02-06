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
            XNamespace ns = "http://CSEFStoreXmlFiles";
            XElement clientsXml = new XElement(ns + "clients",
                from c in db.TableClients.AsEnumerable()
                select new XElement(ns + "clients",
                    c.id_client == null ? null : new XElement(ns + "id_client", c.id_client),
                    c.usuario == null ? null : new XElement(ns + "usuario", c.usuario),
                    c.password == null ? null : new XElement(ns + "password", c.password),
                    c.nom == null ? null : new XElement(ns + "nom", c.nom),
                    c.cognom1 == null ? null : new XElement(ns + "cognom1", c.cognom1),
                    c.cognom2 == null ? null : new XElement(ns + "cognom2", c.cognom2),
                    c.adreca == null ? null : new XElement(ns + "adreca", c.adreca),
                    c.codi_postal == null ? null : new XElement(ns + "codi_postal", c.codi_postal),
                    c.poblacio == null ? null : new XElement(ns + "poblacio", c.poblacio),
                    c.provincia == null ? null : new XElement(ns + "provincia", c.provincia),
                    c.telefon == null ? null : new XElement(ns + "telefon", c.telefon),
                    c.email == null ? null : new XElement(ns + "email", c.email),
                    c.fax == null ? null : new XElement(ns + "fax", c.fax),
                    c.type == null ? null : new XElement(ns + "type", c.type)));
            clientsXml.Save(@"..\XML\clients.xml");

            XElement comandaXml = new XElement(ns + "comanda",
                from c in db.TableComanda.AsEnumerable()
                select new XElement(ns + "comanda",
                    c.id_comanda == null ? null : new XElement(ns + "id_comanda", c.id_comanda),
                    c.n_factura == null ? null : new XElement(ns + "n_factura", c.n_factura),
                    c.id_client == null ? null : new XElement(ns + "id_client", c.id_client),
                    c.adreca_comanda == null ? null : new XElement(ns + "adreca_comanda", c.adreca_comanda)));
            comandaXml.Save(@"..\XML\comanda.xml");

            XElement facturaXml = new XElement(ns + "factura",
                from c in db.TableFactura.AsEnumerable()
                select new XElement(ns + "factura",
                    c.n_factura == null ? null : new XElement(ns + "n_factura", c.n_factura),
                    c.id_client == null ? null : new XElement(ns + "id_client", c.id_client),
                    c.data == null ? null : new XElement(ns + "data", c.data),
                    c.iva == null ? null : new XElement(ns + "iva", c.iva),
                    c.descompte == null ? null : new XElement(ns + "descompte", c.descompte)));
            facturaXml.Save(@"..\XML\factura.xml");

            XElement facturaDetallXml = new XElement(ns + "facturaDetall",
                from c in db.TableFactura_detall.AsEnumerable()
                select new XElement(ns + "facturaDetall",
                    c.n_factura == null ? null : new XElement(ns + "n_factura", c.n_factura),
                    c.id_producte == null ? null : new XElement(ns + "id_producte", c.id_producte),
                    c.quantitat == null ? null : new XElement(ns + "quantitat", c.quantitat)));
            facturaDetallXml.Save(@"..\XML\facturaDetall.xml");

            XElement producteXml = new XElement(ns + "producte",
                from c in db.TableProductes.AsEnumerable()
                select new XElement(ns + "producte",
                    c.Id_producte == null ? null : new XElement(ns + "id_producte", c.Id_producte),
                    c.Producte == null ? null : new XElement(ns + "producte", c.Producte),
                    c.Preu == null ? null : new XElement(ns + "preu", c.Preu)));
            producteXml.Save(@"..\XML\producte.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
