using Microsoft.EntityFrameworkCore;

namespace Devantler.Commons.EntityFramework.Extensions;

/// <summary>
/// Extension methods for <see cref="DbSet{TEntity}"/>.
/// </summary>
public static class DbSetExtensions
{


    /// <summary>
    /// Begins tracking the given entities, and any other reachable entities that are
    /// not already being tracked, in the Microsoft.EntityFrameworkCore.EntityState.Added
    /// state such that they will be inserted into the database when Microsoft.EntityFrameworkCore.DbContext.SaveChanges
    /// is called.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <param name="dbSet"></param>
    /// <param name="entities"></param>
    /// <param name="insertIfNotExists"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task AddRangeAsync<TEntity, TKey>(this DbSet<TEntity> dbSet, IEnumerable<TEntity> entities, bool insertIfNotExists = false, CancellationToken cancellationToken = default)
        where TEntity : class, IEntity<TKey>
    {
        var entitiesToInsert = new List<TEntity>();
        if (insertIfNotExists)
        {
            foreach (var entity in entities)
            {
                if (await dbSet.FindAsync(entity.Id, cancellationToken) == null)
                {
                    entitiesToInsert.Add(entity);
                }
            }
        }
        else
        {
            entitiesToInsert.AddRange(entities);
        }

        await dbSet.AddRangeAsync(entitiesToInsert, cancellationToken);
    }
}
