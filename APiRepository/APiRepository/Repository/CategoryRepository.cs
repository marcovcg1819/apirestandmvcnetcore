using System;
using APiRepository.Models;
using APiRepository.UnitofWork;

namespace APiRepository.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }

}

