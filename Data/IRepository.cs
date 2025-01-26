using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Data
{
    /// <summary>
    /// Generic interface for basic CRUD operations on a repository.
    /// </summary>
    /// <typeparam name="T">The type of entity managed by the repository.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Retrieves all entities from the repository.
        /// </summary>
        /// <returns>A collection of all entities.</returns>
        /// <example>
        /// <code>
        /// var allEntities = await repository.GetAllAsync();
        /// foreach (var entity in allEntities)
        /// {
        ///     Console.WriteLine(entity.ToString());
        /// }
        /// </code>
        /// </example>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Retrieves an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity.</param>
        /// <returns>The entity, or <c>null</c> if not found.</returns>
        /// <example>
        /// <code>
        /// var entity = await repository.GetByIdAsync(1);
        /// if (entity != null)
        /// {
        ///     Console.WriteLine($"Found: {entity.ToString()}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("Entity not found.");
        /// }
        /// </code>
        /// </example>
        Task<T?> GetByIdAsync(int id);

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <example>
        /// <code>
        /// var newEntity = new MyEntity { Name = "New Name" };
        /// await repository.AddAsync(newEntity);
        /// Console.WriteLine("Entity added successfully.");
        /// </code>
        /// </example>
        Task AddAsync(T entity);

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity with updated values.</param>
        /// <example>
        /// <code>
        /// var existingEntity = await repository.GetByIdAsync(1);
        /// if (existingEntity != null)
        /// {
        ///     existingEntity.Name = "Updated Name";
        ///     await repository.UpdateAsync(existingEntity);
        ///     Console.WriteLine("Entity updated successfully.");
        /// }
        /// </code>
        /// </example>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Deletes an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to delete.</param>
        /// <example>
        /// <code>
        /// await repository.DeleteAsync(1);
        /// Console.WriteLine("Entity deleted successfully.");
        /// </code>
        /// </example>
        Task DeleteAsync(int id);
    }
}
