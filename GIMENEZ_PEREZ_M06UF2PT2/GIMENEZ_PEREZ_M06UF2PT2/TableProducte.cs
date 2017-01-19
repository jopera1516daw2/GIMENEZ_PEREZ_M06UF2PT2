using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace GIMENEZ_PEREZ_M06UF2PT2
{
    [Table("productes", Schema = "public")]
    public class TableProducte
    {
        [Key]
        [Column("id_producte")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_producte { get; set; }
        [Column("producte")]
        public string Producte { get; set; }
        [Column("preu")]
        public int Preu { get; set; }
    }

    public class DB : DbContext
    {
        public DB() : base(nameOrConnectionString: "EmpresaEntities") { }
        public DbSet<TableProducte> TableProductes { get; set; }
    }

}
