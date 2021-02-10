namespace Core.Utilities.results
{
    //Temel voidler için başlangıç

    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}