using Dot.Net.Framework.Prototype.Data.Repository.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServer;

namespace Dot.Net.Framework.Prototype.Data
{
    /// <summary>
    /// MdwUnitOfWork class is a unit of work for manipulating about utility data in database via repository.
    /// </summary>
    public class DSUnitOfWork : UnitOfWork<DbContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DSUnitOfWork" /> class.
        /// </summary>
        /// <param name="dbContext">The database context what inherits from DbContext of EF.</param>
        /// <param name="dbCommandInterceptor">The database command interceptor for logging.</param>
        public DSUnitOfWork(DbContext dbContext, IDbCommandInterceptor dbCommandInterceptor = null)
            : base(dbContext, SqlProviderServices.Instance, dbCommandInterceptor)
        { }
    }
}
