﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace API_REST.Models
{
    public partial class Peliculas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int? Anio { get; set; }
        public string Director { get; set; }
        public string FotoUrl { get; set; }
        public int? IdGenero { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Generos IdGeneroNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}