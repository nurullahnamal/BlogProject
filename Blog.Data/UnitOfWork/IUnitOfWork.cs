﻿using Blog.Core.Entities;
using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T>GetRepository<T>() where T : class,IEntityBase,new();
        Task<int> SaveAsync();
        int Save();

    }
}
