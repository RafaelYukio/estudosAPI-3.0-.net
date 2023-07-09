using Products.Domain.Entities.Base;

namespace Products.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
