using System.IO;
using System.Threading.Tasks;

namespace UserCreator.Interfaces
{
    public interface IFieldTypeOperations
    {
        Task FieldTypeOperation(string fieldName, string fieldData, StreamWriter outputFileWriter);
    }
}
