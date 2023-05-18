namespace UploadFilesLibrary
{
    public interface ISqlDataAccess
    {
        Task SaveData(string storeProc, string connectionName, object parameters);
    }
}