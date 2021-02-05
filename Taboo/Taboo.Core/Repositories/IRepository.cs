﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taboo.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {

        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        //Aşağıdaki 2sin neden async değil araştır
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);


    }
}
