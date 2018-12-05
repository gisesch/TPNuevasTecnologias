using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Figuritas.Models
{
    public class Usuario
    {
        #region Propiedades
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public String Nombre { get; set; }
        
        /// <summary>
        /// Cuenta de email del Usuario
        /// </summary>
        [DisplayName("Email:")]
        [Required(ErrorMessage = "Por favor ingrese un mail")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un mail valido")]
        [Key]
        public String Email { get; set; }
        
        /// <summary>
        /// Contrasena para el inicio de sesion del Usuario
        /// </summary>
        [DisplayName("Contrasena:")]
        [Required(ErrorMessage = "Por favor ingrese uma contrasena valida")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Por favor ingrese uma contrasena entre 8 y 15 caracteres")]
        public String Contrasena { get; set; }
        
        /// <summary>
        /// Amigo del Usuario
        /// </summary>
        public string CodAmigo { get; set; }
        
        /// <summary>
        /// Identificador del Album del Usuario
        /// </summary>
        public String IdAlbum { get; set; }
        #endregion

        public Usuario() { }

        public Usuario(String nombre)
        {
            this.Nombre = nombre;
        }
    }
}