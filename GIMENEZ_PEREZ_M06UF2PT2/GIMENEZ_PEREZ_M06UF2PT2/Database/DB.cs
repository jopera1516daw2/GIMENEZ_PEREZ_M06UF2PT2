using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    public class DB : DbContext
    {
        public string currentUser;
        public string currentDireccion;
        private static DB instance;
        public DB() : base(nameOrConnectionString: "EmpresaEntities") { }
        public DbSet<TableProductes> TableProductes { get; set; }
        public DbSet<TableClients> TableClients { get; set; }
        public DbSet<TableFactura> TableFactura { get; set; }
        public DbSet<TableFactura_detall> TableFactura_detall { get; set; }
        public DbSet<TableComanda> TableComanda { get; set; }

        public static DB getInstance()
        {
            if (instance == null)
            {
                instance = new DB();
            }
            return instance;
        }
    }

}
