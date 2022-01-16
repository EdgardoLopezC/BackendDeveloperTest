using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Helpers;
using BackendDeveloperTest.Models.CentralDeRepuesto;
using BackendDeveloperTest.Models.TiendaA;
using BackendDeveloperTest.Models.TiendaB;
using BackendDeveloperTest.Models.TiendaC;
using Microsoft.AspNetCore.Mvc;

namespace BackendDeveloperTest.Controllers
{
    [ApiController]
    [Route("api/repuesto")]
    public class repuestoController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Response>> Get()
        {

            TiendaAResponseRepuesto tiendaAResponseRepuesto = new TiendaAResponseRepuesto();
            TiendaBResponseRepuesto tiendaBResponseRepuesto = new TiendaBResponseRepuesto();
            TiendaCResponseRepuesto tiendaCResponseRepuesto = new TiendaCResponseRepuesto();

            //tiendaCResponseRepuesto.obtenerResponse();
            // return tiendaAResponseRepuesto.obtenerResponse();
            //return tiendaBResponseRepuesto.obtenerResponse();
            return tiendaCResponseRepuesto.obtenerResponse();

            /*
            return new List<Tiendasss>()
            {
                new Tiendasss(){
                    nombre = "Tienda 1",
                    direccion = "direccion 1",
                    telefono = "11111111",
                    rating = 1.5
                },
                new Tiendasss(){
                    nombre = "Tienda 2",
                    direccion = "direccion 2",
                    telefono = "22222222",
                    rating = 2.5
                },
                new Tiendasss(){
                    nombre = "Tienda 3",
                    direccion = "direccion 3",
                    telefono = "33333333",
                    rating = 3.5
                }
            }; */
        }
    }
}
