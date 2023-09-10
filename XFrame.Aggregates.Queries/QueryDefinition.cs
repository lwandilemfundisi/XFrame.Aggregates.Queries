using XFrame.VersionTypes;

namespace XFrame.Aggregates.Queries
{
    public class QueryDefinition : VersionedTypeDefinition
    {
        public QueryDefinition(
            int version,
            Type type,
            string name)
            : base(version, type, name)
        {
        }
    }
}
