using System.Threading.Tasks;

namespace ObsBot.Services.Interfaces;

public interface ILocalStorageAccessService
{
    Task<string> FilePathAsync(string filename);
    string FilePath(string filename);
}
