using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class Figurita
    {
        #region Propiedades
        
        /// <summary>
        /// Identificador del Album al que pertenece la Figurita
        /// </summary>
        [Key]
        [Column(Order=1)]
        public String IdAlbum { get; set; }

        /// <summary>
        /// Identificador de la Figurita dentro de un Album
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public int Numero { get; set; }

        /// <summary>
        /// Cantidad de veces repetidas de la Figurita
        /// </summary>
        public int Cantidad { get; set; }
        #endregion

        public Figurita(String idAlbum)
        {
            this.IdAlbum = idAlbum;
        }
    }
}