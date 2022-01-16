using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaB
{
    public partial class Repuesto
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdCarro { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
