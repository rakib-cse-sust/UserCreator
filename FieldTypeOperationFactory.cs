using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCreator
{
    public class FieldTypeOperationFactory
    {
        public async Task OperationFactory(string fieldName, string fieldData, StreamWriter outputFileWriter)
        {
            IWriteUserDataToFile writeUserDataToFile = new WriteUserDataToFile();

            if (string.Equals("DateOfBirth", fieldName, StringComparison.CurrentCultureIgnoreCase))
            {
                await writeUserDataToFile.WriteToFile<DateTime>(fieldName, fieldData, outputFileWriter);
            }
            else if (string.Equals("Salary", fieldName, StringComparison.CurrentCultureIgnoreCase))
            {
                await writeUserDataToFile.WriteToFile<decimal>(fieldName, fieldData, outputFileWriter);
            }
            else
            {
                await writeUserDataToFile.WriteToFile<string>(fieldName, fieldData, outputFileWriter);
            }
        }
    }
}
