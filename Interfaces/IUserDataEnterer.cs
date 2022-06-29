using System.Threading.Tasks;

namespace UserCreator.Interfaces
{
    public interface IUserDataEnterer<U> where U : class
    {
        Task WriteDataToCsv(U writer, string fieldName, object data);
    }    
}