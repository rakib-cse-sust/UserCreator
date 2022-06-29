using System.IO;
using System.Threading.Tasks;
using UserCreator.Interfaces;

namespace UserCreator
{
    public class WriteUserDataToFile : IWriteUserDataToFile
    {
        private IUserDataEnterer<TextWriter> _userDataEnterer;

        public WriteUserDataToFile()
        {
            _userDataEnterer = new UserDataEnterer();
        }

        public async Task WriteToFile<TDataType>(string fieldName, string fieldData, StreamWriter streamWriter)
        {
            var userDataParser = new UserDataParser<TDataType>();            

            if (userDataParser.TryConvertData(fieldData, out var data))
            {
                await _userDataEnterer.WriteDataToCsv(streamWriter, fieldName, data);
            }
        }
    }
}
