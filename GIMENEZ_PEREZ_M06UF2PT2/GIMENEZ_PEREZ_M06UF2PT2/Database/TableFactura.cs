using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    [Table("factura", Schema = "public")]
    public class TableFactura
    {
        [Key]
        [Column("n_factura")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int n_factura { get; set; }
        [Column("id_client")]
        public int id_client { get; set; }
        [Column("data")]
        public string data { get; set; }
        [Column("descompte")]
        public int descompte { get; set; }
        [Column("iva")]
        public int iva { get; set; }
    }
}
