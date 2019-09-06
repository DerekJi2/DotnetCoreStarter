namespace Dcs.Core.Models
{
    public interface ISimpleException
    {
        string Message { get; set; }
        string StackTrace { get; set; }
    }
}