using System;
using System.IO;
using System.Threading.Tasks;

namespace UserCreator
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            string fieldType;
            if(args.Length != 1)
            {
                await Console.Out.WriteLineAsync($"Usage: UserCreator [outputfile]");
                return 1;
            }

            await using var outputFile = File.OpenWrite(args[0]);
            await using var outputFileWriter = new StreamWriter(outputFile);

            var factory = new FieldTypeOperationFactory();

            while (!string.IsNullOrEmpty(fieldType = await GetFieldType()))
            {
                var fieldData = await GetData(fieldType);

                await factory.OperationFactory(fieldType, fieldData, outputFileWriter);

                Console.WriteLine($"============");
            }
            return 0;
        }

        static async Task<string> GetFieldType()
        {
            await Console.Out.WriteLineAsync($"Please enter field, or enter to exit");
            return await Console.In.ReadLineAsync();
        }

        static async Task<string> GetData(string fieldName)
        {
            await Console.Out.WriteLineAsync($"Please enter user's {fieldName}:");
            return await Console.In.ReadLineAsync();
        }
    }
}
