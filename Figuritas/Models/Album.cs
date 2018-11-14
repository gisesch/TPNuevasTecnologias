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
        /// <summary>
        /// Identificador del album
        /// </summary>
        [Key]
        public String Id { get; set; }
        
        /// <summary>
        /// Nombre del Album
        /// </summary>
        public String Nombre { get; set; }
        
        /// <summary>
        /// Coleccion de figuritas del Album
        /// </summary>
        public ICollection<Figurita> Figuritas { get; set; }
        #endregion

        public Album(String id)
        {
            this.Id = id;
        }
    }
}