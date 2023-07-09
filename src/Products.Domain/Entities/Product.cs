using Products.Domain.Entities.Base;

namespace Products.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Description Description { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
