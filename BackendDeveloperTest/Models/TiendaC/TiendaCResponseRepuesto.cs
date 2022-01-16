using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Helpers;

namespace BackendDeveloperTest.Models.TiendaC
{
    public class TiendaCResponseRepuesto: ResponseDB
    {
        public override List<Response> obtenerResponse(string repuesto)
        {
            List<Response> responseLista = new List<Response>();
            TiendaResponse tiendaResponse = new ObtenerResponse().getTienda("Tienda C");

            using (tiendaCContext context = new tiendaCContext())
            {
                //inner join Repuesto, Tipo de Repuesto y Marca para generar el modelo de Repuesto
                var queryRepuestoLista = context.Repuestos.Join(
                    context.TipoRepuestos,
                    repuesto => repuesto.IdTipoRepuesto,
                    tipoRepuesto => tipoRepuesto.Id,
                    (repuesto, tipoRepuesto) => new {
                        repuesto,
                        tipoRepuesto
                    }).Where(r => r.tipoRepuesto.Nombre.Contains(repuesto)).OrderBy(r => r.repuesto.Precio)
                    .Join(
                     context.Marcas,
                     j1 => j1.repuesto.IdMarca,
                     marca=> marca.Id,
                     (j1, marca) => new {
                         j1, marca
                     }).ToList();

                //inner join Marca, Modelo y Carro para generar el modelo de Repuesto
                var queryVehiculoLista = context.Modelos.Join(
                    context.Carros,
                    modelo => modelo.Id,
                    carro => carro.IdModelo,
                    (modelo, carro) => new {
                        modelo,
                        carro
                    })
                    .Join(context.Marcas,
                    j1 => j1.modelo.IdMarca,
                    marca => marca.Id,
                    (j1, marca) => new {
                        j1,
                        marca
                    }).Where(qv => queryRepuestoLista.Select(qr => qr.j1.repuesto.IdCarro).Contains(qv.j1.carro.Id)).ToList();

                for (int i = 0; i < queryRepuestoLista.Count(); i++)
                {
                    var queryRepuesto = queryRepuestoLista[i];
                    var queryVehiculo = queryVehiculoLista[i];

                    RepuestoResponse repuestoResponse = new RepuestoResponse(
                        queryRepuesto.j1.tipoRepuesto.Nombre,
                        queryRepuesto.marca.Nombre,
                        queryRepuesto.j1.repuesto.Precio);

                    VehiculoResponse vehiculoResponse = new VehiculoResponse(
                        queryVehiculo.marca.Nombre,
                        queryVehiculo.j1.modelo.Nombre,
                        queryVehiculo.j1.carro.Anho);

                    Response response = new Response(tiendaResponse, vehiculoResponse, repuestoResponse);

                    responseLista.Add(response);
                }
            }
            return responseLista;
        }
    }
}
