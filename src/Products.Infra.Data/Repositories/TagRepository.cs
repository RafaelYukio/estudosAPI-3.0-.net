using Products.Application.Interfaces.Repositories;
using Products.Domain.Entities;
using Products.Infra.Data.Context;
using Products.Infra.Data.Repositories.Base;

namespace Products.Infra.Data.Repositories
{
    public sealed class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(DataContext context) : base(context) { }
    }
}
