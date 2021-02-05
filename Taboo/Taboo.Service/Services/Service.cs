using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taboo.Core.Repositories;
using Taboo.Core.Services;
using Taboo.Core.UnitOfWorks;

namespace Taboo.Service
{
    public class Service<TEntity>:IService<TEntity> where TEntity:class
    {
        public readonly IRepository<TEntity> _repository;
        public readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public TEntity Update(TEntity entity)
        {
            TEntity updateEntity = _repository.Update(entity);
            _unitOfWork.Commit();

            return updateEntity;
        }
    }
}
