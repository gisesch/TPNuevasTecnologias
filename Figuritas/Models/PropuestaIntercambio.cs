using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class PropuestaIntercambio
    {
        #region Propiedades
        private String id;
        /// <summary>
        /// Identificador de la PropuestaIntercambio
        /// </summary>
        public String Id
        {
            get
            {
                return id;
            }
        }

        private Usuario ofertante;
        /// <summary>
        /// Usuario que envia la PropuestaIntercambio
        /// </summary>
        public Usuario Ofertante
        {
            get
            {
                return ofertante;
            }
            //set
            //{
            //    if (value == ofertante)
            //        return;
            //    ofertante = value;
            //}
        }

        private Usuario receptorOferta;
        /// <summary>
        /// Usuario que recibe la PropuestaIntercambio
        /// </summary>
        public Usuario ReceptorOferta
        {
            get
            {
                return receptorOferta;
            }
            //set
            //{
            //    if (value == receptorOferta)
            //        return;
            //    receptorOferta = value;
            //}
        }

        private ICollection<Figurita> figuritas;
        /// <summary>
        /// Lista de Figurita contenidos en la PropuestaIntercambio
        /// </summary>
        public ICollection<Figurita> Figuritas
        {
            get
            {
                return figuritas;
            }
            //set
            //{
            //    if (value == figuritas)
            //        return;
            //    figuritas = value;
            //}
        }
        #endregion

        public PropuestaIntercambio(String id, Usuario ofertante, Usuario receptorOferta)
        {
            this.id = id;
            this.ofertante = ofertante;
            this.receptorOferta = receptorOferta;
        }
    }
}