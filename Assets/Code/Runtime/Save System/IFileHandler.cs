using System.Threading.Tasks;

namespace Assets.Code.Scripts.Runtime.Save_System
{
    public interface IFileHandler
    {
        Task<string> ReadFileAsync(string filePath);
        Task WriteFileAsync(string filePath, string text);
    }
}