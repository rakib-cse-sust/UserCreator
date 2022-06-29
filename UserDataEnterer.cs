using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UserCreator.Interfaces;

namespace UserCreator
{
    public class UserDataEnterer : IUserDataEnterer<TextWriter>
    {
        public static int nextId;

        public async Task WriteDataToCsv(TextWriter textWriter, string fieldName, object data)
        {
            await textWriter.WriteLineAsync($"{GetNextId()},{fieldName},{data}");

            await textWriter.FlushAsync();
        }

        private int GetNextId()
        {
            Interlocked.Increment(ref nextId);

            return nextId;
        }
    }
}