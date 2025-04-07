using SQLiteDemo.Models;

namespace SQLite_demo.Services
{
    class PersonService : BaseService
    {
        public async Task<int> AddAsync(PersonModel personModel)
        {
            await SetUpDatabase();
            return await dbConnection.InsertAsync(personModel);
        }

        public async Task<int> DeleteAsync(PersonModel personModel)
        {
            await SetUpDatabase();
            return await dbConnection.DeleteAsync(personModel);
        }

        public async Task<List<PersonModel>> GetAsync()
        {
            await SetUpDatabase();
            return await dbConnection.Table<PersonModel>().ToListAsync();
        }

        public async Task<int> UpdateAsync(PersonModel personModel)
        {
            await SetUpDatabase();
            return await dbConnection.UpdateAsync(personModel);
        }
    }
}
