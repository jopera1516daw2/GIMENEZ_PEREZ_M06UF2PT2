using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GIMENEZ_PEREZ_M06UF2PT2
{
    [Table("factura_detall", Schema = "public")]
    public class TableFactura_detall
    {
        [Key]
        [Column("n_factura")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int n_factura { get; set; }
        [Column("id_producte")]
        public int id_producte { get; set; }
        [Column("quantitat")]
        public int quantitat { get; set; }
    }
}
