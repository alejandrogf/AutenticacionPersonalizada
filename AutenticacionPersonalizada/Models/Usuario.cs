//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutenticacionPersonalizada.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int idUsuario { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Imagen { get; set; }
        public Nullable<int> idRol { get; set; }
        public string Email { get; set; }
    
        public virtual Rol Rol { get; set; }
    }
}
