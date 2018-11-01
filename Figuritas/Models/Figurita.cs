using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class Figurita
    {
        #region Propiedades
        private String idAlbum;
        /// <summary>
        /// Identificador del Album al que pertenece la Figurita
        /// </summary>
        public String IdAlbum
        {
            get
            {
                return idAlbum;
            }
        }

        private int numero;
        /// <summary>
        /// Identificador de la Figurita dentro de un Album
        /// </summary>
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if (value == numero)
                    return;
                numero = value;
            }
        }

        private int cantidad;
        /// <summary>
        /// Cantidad de veces repetidas de la Figurita
        /// </summary>
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value == cantidad)
                    return;
                cantidad = value;
            }
        }
        #endregion

        public Figurita(String idAlbum)
        {
            this.idAlbum = idAlbum;
        }
    }

    public class FiguritaDBContext : DbContext
    {
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
    }
}