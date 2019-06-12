using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nissim.On.Repository.IFC
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all the TEntity instances
        /// </summary>
        Task<IEnumerable<TEntity>> GetAllAsync();

        //-----------------------------------------------------------------------*

        /// <summary>
        /// Add Entity to the DB
        /// </summary>
        /// <param name="entity">The entity to add</param>
        Task AddAsync(TEntity entity);

        //-----------------------------------------------------------------------*

        /// <summary>
        /// Add list of entities to DB
        /// </summary>
        /// <param name="entities">The entities list</param>
        Task AddRangeAsync(IEnumerable<TEntity> entities);

        //-----------------------------------------------------------------------*

        /// <summary>
        /// Get the uniqe object of the entity
        /// </summary>
        /// <param name="predicate">the uniqe entity to get</param>
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
