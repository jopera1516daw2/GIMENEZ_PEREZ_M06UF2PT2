using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIMENEZ_PEREZ_M06UF2PT2{
    /// <summary>
    /// Clase que da acceso a la tabla "comanda" mediante código
    /// </summary>   
    [Table("comanda", Schema = "public")]
    public class TableComanda{
        [Key]
        [Column("id_comanda")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_comanda { get; set; }
        [Column("n_factura")]
        public int n_factura { get; set; }
        [Column("id_client")]
        public int id_client { get; set; }
        [Column("adreca_comanda")]
        public string adreca_comanda { get; set; }
    }
}
