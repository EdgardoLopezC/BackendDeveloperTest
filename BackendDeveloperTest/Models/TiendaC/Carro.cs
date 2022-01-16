using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaC
{
    public partial class Carro
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public string Anho { get; set; } = null!;
    }
}
