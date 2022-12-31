namespace eCommerceApp.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionStringName = "Default");
        Task SaveData<T>(string sql, T paramters, string connectionStringName = "Default");
    }
}