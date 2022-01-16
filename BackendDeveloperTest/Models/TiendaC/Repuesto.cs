using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaC
{
    public partial class Repuesto
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdCarro { get; set; }
        public int IdTipoRepuesto { get; set; }
        public decimal Precio { get; set; }
    }
}
