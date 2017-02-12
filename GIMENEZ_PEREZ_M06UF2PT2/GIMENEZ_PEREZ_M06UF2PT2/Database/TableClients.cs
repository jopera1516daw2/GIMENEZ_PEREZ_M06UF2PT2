using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIMENEZ_PEREZ_M06UF2PT2{

    /// <summary>
    /// Clase que da acceso a la tabla "clients" mediante código
    /// </summary>
    [Table("clients", Schema = "public")]
    public class TableClients { 
        [Key]
        [Column("id_client")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_client { get; set; }
        [Column("nom")]
        public string nom { get; set; }
        [Column("cognom1")]
        public string cognom1 { get; set; }
        [Column("cognom2")]
        public string cognom2 { get; set; }
        [Column("adreca")]
        public string adreca { get; set; }
        [Column("codi_postal")]
        public int codi_postal { get; set; }
        [Column("poblacio")]
        public string poblacio { get; set; }
        [Column("provincia")]
        public string provincia { get; set; }
        [Column("telefon")]
        public int telefon { get; set; }
        [Column("fax")]
        public int fax { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("password")]
        public string password { get; set; }
        [Column("usuario")]
        public string usuario { get; set; }
        [Column("type")]
        public int type { get; set; }
    }
    
}
