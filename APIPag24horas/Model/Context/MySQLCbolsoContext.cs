using APIPag24horas.Model.cbolso;
using Microsoft.EntityFrameworkCore;

namespace APIPag24horas.Model.Context
{
    public class MySQLCbolsoContext: DbContext
    {
        public MySQLCbolsoContext(){}
        public MySQLCbolsoContext(DbContextOptions<MySQLCbolsoContext>options) :base(options){}

        public DbSet<Apiteste> Apiteste { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
    }
}
