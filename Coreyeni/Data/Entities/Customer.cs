using Microsoft.EntityFrameworkCore;

namespace Coreyeni.Data.Entities
{
    public class Customer:DbContext
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string SurName { get; set; }
    }
}
