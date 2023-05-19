namespace UploadFilesLibrary
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T>(string storeProc, string connectionName, object? parameters);
        Task SaveData(string storeProc, string connectionName, object parameters);
    }
}