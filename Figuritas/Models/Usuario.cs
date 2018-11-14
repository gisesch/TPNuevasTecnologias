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
        [Required(ErrorMessage = "Por favor ingrese un mail, mamerto")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un mail valido, mamerto")]
        [Key]
        public String Email { get; set; }
        
        /// <summary>
        /// Contrasena para el inicio de sesion del Usuario
        /// </summary>
        [DisplayName("Contrasena:")]
        [Required(ErrorMessage = "Por favor ingrese uma contrasena valida, mamerto")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Por favor ingrese uma contrasena entre 8 y 15 caracteres, mamerto")]
        public String Contrasena { get; set; }
        
        /// <summary>
        /// Lista de amigos del Usuario
        /// </summary>
        public ICollection<Usuario> Amigos { get; set; }
        
        /// <summary>
        /// Identificador del Album del Usuario
        /// </summary>
        public String IdAlbum { get; set; }
        #endregion

        public Usuario(String nombre)
        {
            this.Nombre = nombre;
        }
    }
}