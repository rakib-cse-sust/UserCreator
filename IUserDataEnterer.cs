using System.Threading.Tasks;

namespace UserCreator
{
    public interface IUserDataEnterer<U> where U : class
    {
        Task WriteDataToCsv(U writer, string fieldName, object data);
    }    
}