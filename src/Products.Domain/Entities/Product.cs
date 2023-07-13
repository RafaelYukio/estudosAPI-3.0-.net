using Products.Domain.Entities.Base;

namespace Products.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Category? Category { get; set; }
        public Description? Description { get; set; }
        public IEnumerable<Tag>? Tags { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
