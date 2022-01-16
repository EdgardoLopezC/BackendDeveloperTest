using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Helpers;
using BackendDeveloperTest.Models.CentralDeRepuesto;

namespace BackendDeveloperTest.Models.TiendaA
{
    public class TiendaAResponseRepuesto:ResponseDB
    {
        public override List<Response> obtenerResponse(string repuestoo)
        {
            List<Response> responseLista = new List<Response>();
            List<Repuesto> repuestoLista = new List<Repuesto>();
            TiendaResponse tiendaResponse = new ObtenerResponse().getTienda("Tienda A");

            using (tiendaAContext context = new tiendaAContext())
            {
                repuestoLista = context.Repuestos.Where(repuesto => repuesto.NombreRepuesto.Contains(repuestoo)).OrderBy(repuesto => repuesto.PrecioRepuesto).ToList<Repuesto>();
            }
            foreach (Repuesto repuesto in repuestoLista)
            {
                RepuestoResponse repuestoResponse = new RepuestoResponse(repuesto.NombreRepuesto, repuesto.MarcaRepuesto, repuesto.PrecioRepuesto);
                VehiculoResponse vehiculoResponse = new VehiculoResponse(repuesto.MarcaCarro, repuesto.ModeloCarro, repuesto.AnhoCarro);
                Response response = new Response(tiendaResponse, vehiculoResponse, repuestoResponse);
              
                responseLista.Add(response);
            }
            
            return responseLista;
        }
    }
}
