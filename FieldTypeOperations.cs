using System;
using System.IO;
using System.Threading.Tasks;
using UserCreator.Interfaces;

namespace UserCreator
{
    public class FieldTypeOperations : IFieldTypeOperations
    {
        private readonly IWriteUserDataToFile _writeUserDataToFile;

        public FieldTypeOperations(IWriteUserDataToFile writeUserDataToFile)
        {
            _writeUserDataToFile = writeUserDataToFile;
        }

        public async Task FieldTypeOperation(string fieldName, string fieldData, StreamWriter outputFileWriter)
        {
            if (string.Equals("DateOfBirth", fieldName, StringComparison.CurrentCultureIgnoreCase))
            {
                await _writeUserDataToFile.WriteToFile<DateTime>(fieldName, fieldData, outputFileWriter);
            }
            else if (string.Equals("Salary", fieldName, StringComparison.CurrentCultureIgnoreCase))
            {
                await _writeUserDataToFile.WriteToFile<decimal>(fieldName, fieldData, outputFileWriter);
            }
            else
            {
                await _writeUserDataToFile.WriteToFile<string>(fieldName, fieldData, outputFileWriter);
            }
        }
    }
}
