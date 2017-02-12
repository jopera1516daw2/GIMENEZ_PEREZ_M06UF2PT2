using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    /// <summary>
    /// Clase que da acceso a la base de datos y a sus tablas mediante código
    /// </summary>
    public class DB : DbContext{
        public DB() : base(nameOrConnectionString: "EmpresaEntities") { }
        public DbSet<TableProductes> TableProductes { get; set; }
        public DbSet<TableClients> TableClients { get; set; }
        public DbSet<TableFactura> TableFactura { get; set; }
        public DbSet<TableFactura_detall> TableFactura_detall { get; set; }
        public DbSet<TableComanda> TableComanda { get; set; }

    }

}
