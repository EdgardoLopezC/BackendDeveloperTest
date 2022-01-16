using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Helpers;

namespace BackendDeveloperTest.Models.TiendaB
{
    public class TiendaBResponseRepuesto
    {
        public List<Response> obtenerResponse()
        {
            List<Response> responseLista = new List<Response>();
            TiendaResponse tiendaResponse = new ObtenerResponse().getTienda("Tienda A");

            using (tiendaBContext context = new tiendaBContext())
            {
                //inner join Repuesto y Marca para generar el modelo de Repuesto
                var queryRepuestoLista = context.Repuestos.Join(
                    context.Marcas,
                    repuesto => repuesto.IdMarca,
                    marca => marca.Id,
                    (repuesto, marca) => new {
                        repuesto, marca
                    }).Where( x => x.repuesto.Nombre == "Amortiguador trasero" ).ToList();

                //inner join Marca, Modelo y Carro para generar el modelo de Repuesto
                var queryVehiculoLista = context.Modelos.Join(
                    context.Carros,
                    modelo => modelo.Id,
                    carro => carro.IdModelo,
                    (modelo, carro) => new {
                        modelo,
                        carro
                    })
                    .Join( context.Marcas,
                    j1 => j1.modelo.IdMarca,
                    marca => marca.Id,
                    (j1, marca) => new {
                        j1, marca
                    }).Where( qv => queryRepuestoLista.Select( qr => qr.repuesto.IdCarro ).Contains(qv.j1.carro.Id)).ToList();

                for (int i = 0; i < queryRepuestoLista.Count; i++)
                {
                    var queryRepuesto = queryRepuestoLista[i];
                    var queryVehiculo = queryVehiculoLista[i];

                    RepuestoResponse repuestoResponse = new RepuestoResponse(
                        queryRepuesto.repuesto.Nombre,
                        queryRepuesto.marca.Nombre,
                        queryRepuesto.repuesto.Precio);

                    VehiculoResponse vehiculoResponse= new VehiculoResponse(
                        queryVehiculo.marca.Nombre,
                        queryVehiculo.j1.modelo.Nombre,
                        queryVehiculo.j1.carro.Anyo);

                    Response response = new Response(tiendaResponse, vehiculoResponse, repuestoResponse);

                    responseLista.Add(response);
                }
            }
            return responseLista;
        }
    }
}
