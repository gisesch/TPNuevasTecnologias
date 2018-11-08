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
        private String nombre;
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public String Nombre
        {
            get
            {
                return nombre;
            }
        }

        private String email;
        /// <summary>
        /// Cuenta de email del Usuario
        /// </summary>
        [DisplayName("Email:")]
        [Required(ErrorMessage = "Por favor ingrese un mail, mamerto")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un mail valido, mamerto")]
        [Key]
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value == email)
                    return;
                email = value;
            }
        }

        private String contrasena;
        /// <summary>
        /// Contrasena para el inicio de sesion del Usuario
        /// </summary>
        [DisplayName("Contrasena:")]
        [Required(ErrorMessage = "Por favor ingrese uma contrasena valida, mamerto")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Por favor ingrese uma contrasena entre 8 y 15 caracteres, mamerto")]
        public String Contrasena
        {
            get
            {
                return contrasena;
            }
            set
            {
                if (value == contrasena)
                    return;
                contrasena = value;
            }
        }

        private ICollection<Usuario> amigos;
        /// <summary>
        /// Lista de amigos del Usuario
        /// </summary>
        public ICollection<Usuario> Amigos
        {
            get
            {
                return amigos;
            }
            set
            {
                if (value == amigos)
                    return;
                amigos = value;
            }
        }

        private String idAlbum;
        /// <summary>
        /// Identificador del Album del Usuario
        /// </summary>
        public String IdAlbum
        {
            get
            {
                return idAlbum;
            }
        }
        #endregion

        public Usuario(String nombre)
        {
            this.nombre = nombre;
        }
    }
}