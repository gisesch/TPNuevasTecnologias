using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class PropuestaIntercambio
    {
        #region Propiedades
        /// <summary>
        /// Identificador de la PropuestaIntercambio
        /// </summary>
        [Key]
        public String Id { get; set; }
        
        /// <summary>
        /// Usuario que envia la PropuestaIntercambio
        /// </summary>
        public Usuario Ofertante { get; set; }
        
        /// <summary>
        /// Usuario que recibe la PropuestaIntercambio
        /// </summary>
        public Usuario ReceptorOferta { get; set; }
        
        /// <summary>
        /// Lista de Figurita contenidos en la PropuestaIntercambio
        /// </summary>
        public ICollection<Figurita> Figuritas { get; set; }
        #endregion

        public PropuestaIntercambio(String id, Usuario ofertante, Usuario receptorOferta)
        {
            this.Id = id;
            this.Ofertante = ofertante;
            this.ReceptorOferta = receptorOferta;
        }
    }
}