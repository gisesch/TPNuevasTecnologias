using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Id { get; set; }

        /// <summary>
        /// Usuario que envia la PropuestaIntercambio
        /// </summary>
        [DisplayName("Ofertante:")]
        public String Ofertante { get; set; }
        
        /// <summary>
        /// Usuario que recibe la PropuestaIntercambio
        /// </summary>
        public String ReceptorOferta { get; set; }

        /// <summary>
        /// Identificador del album
        /// </summary>
        [DisplayName("Album:")]
        public String IdAlbum { get; set; }

        /// <summary>
        /// Identificador de la Figurita dentro de un Album
        /// </summary>
        [DisplayName("Figurita numero:")]
        public int NumeroFigurita { get; set; }

        #endregion

        public PropuestaIntercambio() { }

        public PropuestaIntercambio(int id, String ofertante, String receptorOferta,String idAlbum, int numeroFigurita)
        {
            this.Id = id;
            this.Ofertante = ofertante;
            this.ReceptorOferta = receptorOferta;
            this.IdAlbum = idAlbum;
            this.NumeroFigurita = numeroFigurita;
        }
    }
}