using System;
using Microsoft.EntityFrameworkCore;

namespace APiRepository.UnitofWork
{
    public interface IUnitOfwork : IDisposable
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}

