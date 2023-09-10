namespace XFrame.Aggregates.Queries
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<in TQuery, TResult> : IQueryHandler
        where TQuery : IQuery<TResult>
    {
        Task<TResult> ExecuteQueryAsync(
            TQuery query, 
            CancellationToken cancellationToken);
    }
}
