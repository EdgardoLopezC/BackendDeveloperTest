using BackendDeveloperTest.Entities;
using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaA
{
    public partial class Repuesto
    {
        public int Id { get; set; }
        public string MarcaCarro { get; set; } = null!;
        public string ModeloCarro { get; set; } = null!;
        public string AnhoCarro { get; set; } = null!;
        public string NombreRepuesto { get; set; } = null!;
        public string MarcaRepuesto { get; set; } = null!;
        public decimal PrecioRepuesto { get; set; }
    }



}
