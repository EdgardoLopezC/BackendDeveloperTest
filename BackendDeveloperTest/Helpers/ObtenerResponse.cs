using BackendDeveloperTest.Entities;
using BackendDeveloperTest.Models.CentralDeRepuesto;

namespace BackendDeveloperTest.Helpers
{
    public class ObtenerResponse
    {
        public TiendaResponse getTienda(string nombre = " ")
        {
            Tiendum tiendaDB = new Tiendum();
            using (CentralDeRepuestoContext context = new CentralDeRepuestoContext())
            {
                tiendaDB = context.Tienda.First(tienda => tienda.Nombre == nombre);
            }
            TiendaResponse tienda = new TiendaResponse(tiendaDB.Nombre, tiendaDB.Direccion, tiendaDB.Telefono, tiendaDB.Rating);
            return tienda;
        }
    }
}
