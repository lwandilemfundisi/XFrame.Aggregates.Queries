using Microsoft.Extensions.Logging;
using System.Reflection;
using XFrame.Ioc.Configuration;
using XFrame.VersionTypes;

namespace XFrame.Aggregates.Queries
{
    public class QueryDefinitionService 
        : VersionedTypeDefinitionService<IQuery, QueryVersionAttribute, QueryDefinition>, IQueryDefinitionService
    {
        public QueryDefinitionService(
            ILogger<QueryDefinitionService> logger,
            ILoadedTypes loadedTypes)
            : base(logger)
        {
            var commandTypes = loadedTypes
                .TypesLoaded
                .Where(t => typeof(IQuery).GetTypeInfo().IsAssignableFrom(t));
            Load(commandTypes.ToArray());
        }

        protected override QueryDefinition CreateDefinition(int version, Type type, string name)
        {
            return new QueryDefinition(version, type, name);
        }
    }
}
