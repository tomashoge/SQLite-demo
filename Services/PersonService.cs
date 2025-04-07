using SQLiteDemo.Models;

namespace SQLite_demo.Services
{
    class PersonService : BaseService
    {
        public async Task<int> AddAsync(PersonModel PersonModel)
        {
            await SetUpDatabase();
            return await dbConnection.InsertAsync(PersonModel);
        }

        public async Task<int> DeleteAsync(PersonModel PersonModel)
        {
            await SetUpDatabase();
            return await dbConnection.DeleteAsync(PersonModel);
        }

        public async Task<List<PersonModel>> GetAsync()
        {
            await SetUpDatabase();
            return await dbConnection.Table<PersonModel>().ToListAsync();
        }

        public async Task<int> UpdateAsync(PersonModel PersonModel)
        {
            await SetUpDatabase();
            return await dbConnection.UpdateAsync(PersonModel);
        }
    }
}
