using Microsoft.EntityFrameworkCore;
using System;

namespace CoordenadasPalabras.Models
{
    public class CrucigramaContext : DbContext
    {
        public CrucigramaContext(DbContextOptions<CrucigramaContext> options)
            : base(options)
        { }

        public DbSet<Log> Logs { get; set; }
    }


    public class Log
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string SessionId { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
