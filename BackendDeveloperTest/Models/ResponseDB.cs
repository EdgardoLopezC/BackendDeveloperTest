using BackendDeveloperTest.Entities;

namespace BackendDeveloperTest.Models
{
    public abstract class ResponseDB
    {
        public abstract List<Response> obtenerResponse(string repuesto);
    }
}
