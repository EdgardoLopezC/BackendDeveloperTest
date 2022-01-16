using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Helpers;
using BackendDeveloperTest.Models;
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
        public ActionResult<List<Response>> Get(ModelRepuesto modelRepuesto)
        {
            List<Response> responseList = new List<Response>();
            List<ResponseDB> responseDBList = new List<ResponseDB>()
                {
                    new TiendaAResponseRepuesto(),
                    new TiendaBResponseRepuesto(),
                    new TiendaCResponseRepuesto()
                };


            foreach ( ResponseDB responseDB in responseDBList)
            {
                string repuesto = "Amortiguador trasero"; // "Limpiaparabrisas";
                responseList.AddRange(responseDB.obtenerResponse(modelRepuesto.nombre));
            }

            return responseList;
        }
    }
}
