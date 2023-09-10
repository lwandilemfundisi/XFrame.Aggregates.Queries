using XFrame.VersionTypes;

namespace XFrame.Aggregates.Queries
{
    [AttributeUsage(AttributeTargets.Class)]
    public class QueryVersionAttribute : VersionedTypeAttribute
    {
        public QueryVersionAttribute(
            string name,
            int version)
            : base(name, version)
        {
        }
    }
}
