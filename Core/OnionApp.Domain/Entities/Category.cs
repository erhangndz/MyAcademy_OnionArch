using System.ComponentModel.DataAnnotations;

namespace OnionApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
