using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class GeneralDBContext: DbContext
    {
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Figurita> Figuritas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PropuestaIntercambio> PropuestaIntercambios { get; set; }
    }
}