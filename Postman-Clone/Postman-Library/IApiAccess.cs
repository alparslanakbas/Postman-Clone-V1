
namespace Postman_Library
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}