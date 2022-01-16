using System;
using System.Collections.Generic;

namespace BackendDeveloperTest.Models.TiendaC
{
    public partial class Modelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdMarca { get; set; }
    }
}
