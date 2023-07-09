using Products.Domain.Entities.Base;

namespace Products.Domain.Entities
{
    public class Description : BaseEntity
    {
        public string Details { get; set; }
        public Product Product { get; set; }
    }
}
