namespace BackendDeveloperTest.Entities
{
    public class Response
    {
        public TiendaResponse tienda { set; get; }
        public VehiculoResponse vehiculo { set; get; }
        public RepuestoResponse repuesto { set; get; }
       
        public Response(TiendaResponse tienda, VehiculoResponse vehiculo, RepuestoResponse repuesto)
        {
            this.tienda = tienda;
            this.vehiculo = vehiculo;
            this.repuesto = repuesto;
        } 
       
        
    }
}
