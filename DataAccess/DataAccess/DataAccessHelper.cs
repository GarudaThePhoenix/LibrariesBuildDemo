using DataAccessInterface;

namespace DataAccess
{
    public class DataAccessHelper : IRepository
    {
        public string DoSomeWork()
        {
            return $"{nameof(DataAccess)}-{nameof(DataAccessHelper)}";
        }
    }
}
