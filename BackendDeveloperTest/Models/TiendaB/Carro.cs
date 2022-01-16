using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaB
{
    public partial class Carro
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public string Anyo { get; set; } = null!;
    }
}
