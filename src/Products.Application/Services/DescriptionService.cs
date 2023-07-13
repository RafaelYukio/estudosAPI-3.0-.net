using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Services
{
    public sealed class DescriptionService : BaseService<Description>, IDescriptionService
    {
        public DescriptionService(IDescriptionRepository descriptionRepository) : base(descriptionRepository) { }
    }
}
