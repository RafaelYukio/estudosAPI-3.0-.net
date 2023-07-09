using Products.Domain.Entities.Base;

namespace Products.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
