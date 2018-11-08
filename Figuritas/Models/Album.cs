using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class Album
    {
        #region Propiedades
        private String id;
        /// <summary>
        /// Identificador del album
        /// </summary>
        [Key]
        public String Id
        {
            get
            {
                return id;
            }
        }
        private String nombre;
        /// <summary>
        /// Nombre del Album
        /// </summary>
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == nombre)
                    return;
                nombre = value;
            }
        }
        private ICollection<Figurita> figuritas;
        /// <summary>
        /// Coleccion de figuritas del Album
        /// </summary>
        public ICollection<Figurita> Figuritas
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
        #endregion

        public Album(String id)
        {
            this.id = id;
        }
    }
}