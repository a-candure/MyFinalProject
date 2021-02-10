namespace Core.Utilities.results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}