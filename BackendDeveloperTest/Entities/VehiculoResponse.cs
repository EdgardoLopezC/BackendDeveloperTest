namespace BackendDeveloperTest.Entities
{
    public class VehiculoResponse
    {
        public String marca { get; set; }
        public String modelo { get; set; }
        public String anho { get; set; }

        public VehiculoResponse(String marca, String modelo, String anho)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anho = anho;
        }
    }
}
