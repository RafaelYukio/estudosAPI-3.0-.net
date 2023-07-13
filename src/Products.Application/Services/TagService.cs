using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services.Base;
using Products.Domain.Entities;

namespace Products.Application.Services
{
    public sealed class TagService : BaseService<Tag>, ITagService
    {
        public TagService(ITagRepository tagRepository) : base(tagRepository) { }
    }
}
