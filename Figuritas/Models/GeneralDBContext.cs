using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class GeneralDBContext: DbContext
    {
        private DbSet<Album> albumes;
        public DbSet<Album> Albumes
        {
            get
            {
                return albumes;
            }
            set
            {
                if (value == albumes)
                    return;
                albumes = value;
            }
        }
        private DbSet<Figurita> figuritas;
        public DbSet<Figurita> Figuritas
        {
            get
            {
                return figuritas;
            }
            set
            {
                if (value == figuritas)
                    return;
                figuritas = value;
            }
        }
        private DbSet<Usuario> usuarios;
        public DbSet<Usuario> Usuarios
        {
            get
            {
                return usuarios;
            }
            set
            {
                if (value == usuarios)
                    return;
                usuarios = value;
            }
        }
        private DbSet<PropuestaIntercambio> propuestaIntercambios;
        public DbSet<PropuestaIntercambio> PropuestaIntercambios
        {
            get
            {
                return propuestaIntercambios;
            }
            set
            {
                if (value == propuestaIntercambios)
                    return;
                propuestaIntercambios = value;
            }
        }
    }
}