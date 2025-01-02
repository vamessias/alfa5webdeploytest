namespace Alfa5.Maui.Storage;

public interface IStorage
{
    Task<string> GetAsync(string key);

    Task SetAsync(string key, string value);

    Task RemoveAsync(string key);
}