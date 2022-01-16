namespace BackendDeveloperTest.Entities
{
    public class TiendaResponse
    {
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public decimal rating { get; set; }

        public TiendaResponse(string nombre, string direcion, string telefono, decimal rating)
        {
            this.nombre = nombre;
            this.direccion = direcion;
            this.telefono = telefono;
            this.rating = rating;
        }

    }
}
