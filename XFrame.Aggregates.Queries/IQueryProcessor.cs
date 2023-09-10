namespace XFrame.Aggregates.Queries
{
    public interface IQueryProcessor
    {
        Task<TResult> ProcessAsync<TResult>(
            IQuery<TResult> query,
            CancellationToken cancellationToken);

        TResult Process<TResult>(
            IQuery<TResult> query,
            CancellationToken cancellationToken);
    }
}
