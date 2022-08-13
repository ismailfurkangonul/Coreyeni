using Microsoft.EntityFrameworkCore;

namespace Coreyeni.Data.Entities
{
    public class Product:DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
