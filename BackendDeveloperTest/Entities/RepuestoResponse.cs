namespace BackendDeveloperTest.Entities
{
    public class RepuestoResponse
    {
        public String nombre { get; set; }
        public String marca { get; set; }
        public decimal precio { get; set; }

        public RepuestoResponse(String nombre, String marca, decimal precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }
    }

}
