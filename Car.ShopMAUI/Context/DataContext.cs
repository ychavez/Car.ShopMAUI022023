using SQLite;

namespace Car.ShopMAUI.Context
{
    public class DataContext
    {
        SQLiteAsyncConnection db;

        async Task Init()
        {
            if (db is not null)
                return;

            db = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "CarShop.db3"),
                SQLiteOpenFlags.ReadWrite
                | SQLiteOpenFlags.Create
                | SQLiteOpenFlags.SharedCache
              );

            _ = await db.CreateTableAsync<Models.Car>();
         
        }

        public async Task<List<Models.Car>> GetFavorites()
        {
            await Init();
            return await db.Table<Models.Car>().ToListAsync();

        }

        public async Task<Models.Car> GetCarById(int id)
        {
            await Init();
            return await db.Table<Models.Car>().Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<bool> SetFavorite(Models.Car car)
        {
            await Init();
            var _car = await GetCarById(car.Id);

            if (_car is not null)
                return false;

            return await db.InsertAsync(car) == 1;
        }

        public async Task<bool> RemoveFromFavorites(int id)
        {
            await Init();
            var _car = await GetCarById(id);

            if (_car is null)
                return false;


            return await db.DeleteAsync(_car) == 1;

        }

    }
}
