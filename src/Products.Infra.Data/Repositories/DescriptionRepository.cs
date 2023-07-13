using Products.Application.Interfaces.Repositories;
using Products.Domain.Entities;
using Products.Infra.Data.Context;
using Products.Infra.Data.Repositories.Base;

namespace Products.Infra.Data.Repositories
{
    public sealed class DescriptionRepository : BaseRepository<Description>, IDescriptionRepository
    {
        public DescriptionRepository(DataContext context) : base(context) { }
    }
}
