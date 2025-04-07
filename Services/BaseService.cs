using SQLite;
using SQLiteDemo.Models;

namespace SQLite_demo.Services
{
    class BaseService
    {
        protected static SQLiteAsyncConnection dbConnection;
        private static string dbPath = Path.Combine(Environment.CurrentDirectory, "Person.db");

        protected async Task SetUpDatabase()
        {
            if (dbConnection == null)
            {
                dbConnection = new SQLiteAsyncConnection(dbPath);
                await dbConnection.CreateTableAsync<PersonModel>();
            }
        }
    }
}
