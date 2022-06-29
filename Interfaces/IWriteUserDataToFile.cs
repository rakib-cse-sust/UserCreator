using System.IO;
using System.Threading.Tasks;

namespace UserCreator.Interfaces
{
    public interface IWriteUserDataToFile
    {
        Task WriteToFile<TDataType>(string fieldName, string fieldData, StreamWriter streamWriter);
    }
}