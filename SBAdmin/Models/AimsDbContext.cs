using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SBAdmin.Models
{
    public class AimsDbContext : DbContext
    {
        #region Constructors

        static AimsDbContext()
        {
            Database.SetInitializer<AimsDbContext>(new DropCreateDatabaseIfModelChanges<AimsDbContext>());
        }

        public AimsDbContext() : base("name=AWDF_PROD")
        {
            Database.SetInitializer<AimsDbContext>(null);
        }

        public AimsDbContext(string connectionString) : base(connectionString)
        {
        }

        public AimsDbContext(string connectionString, DbCompiledModel model) : base(connectionString, model)
        {
        }

        public AimsDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AimsDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        #endregion

        #region Methods

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        #endregion

        #region DbSets

        public virtual DbSet<GrantInfoSummary> GrantInfoSummaries { get; set; }
        
        #endregion
    }

    public class AimsDbInitializer : DropCreateDatabaseIfModelChanges<AimsDbContext>
    {
        protected override void Seed(AimsDbContext context)
        {
            base.Seed(context);
        }
    }
}