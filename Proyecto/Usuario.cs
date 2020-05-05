using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto
{
    public class Usuario
    {
        [Key]

        public int IdUsuario { get; set; }

        public String NombreUsuario { get; set; }

        public String Password { get; set; }

        public bool EsAdmin { get; set; }


        public Usuario(string pNombre, string pPassword)
        {
            this.NombreUsuario = pNombre;
            this.Password = pPassword;
        }

        public Usuario() { }
    }
}