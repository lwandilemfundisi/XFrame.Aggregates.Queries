using XFrame.VersionTypes;

namespace XFrame.Aggregates.Queries
{
    public interface IQueryDefinitionService
        : IVersionedTypeDefinitionService<QueryVersionAttribute, QueryDefinition>
    {
    }
}
