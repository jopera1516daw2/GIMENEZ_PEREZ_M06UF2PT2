using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GIMENEZ_PEREZ_M06UF2PT2{
    /// <summary>
    /// Clase que da acceso a la tabla "productes" mediante código
    /// </summary>
    [Table("productes", Schema = "public")]
    public class TableProductes {
        [Key]
        [Column("id_producte")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_producte { get; set; }
        [Column("producte")]
        public string Producte { get; set; }
        [Column("preu")]
        public float Preu { get; set; }
    }
}
