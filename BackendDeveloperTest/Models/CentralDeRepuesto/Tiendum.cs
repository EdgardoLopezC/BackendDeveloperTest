using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.CentralDeRepuesto
{
    public partial class Tiendum
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public decimal Rating { get; set; }
    }
}
