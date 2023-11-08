public class DatabaseHelper
{
    private readonly SQLiteAsyncConnection database;

    public DatabaseHelper(string dbPath)
    {
        database = new SQLiteAsyncConnection(dbPath);
    }

    public async Task InitializeDatabaseAsync()
    {
        await database.CreateTableAsync<Contact>();
        // Create other tables as needed here
    }

    public Task<List<Contact>> GetContactsAsync()
    {
        return database.Table<Contact>().ToListAsync();
    }

    public Task<int> SaveContactAsync(Contact contact)
    {
        if (contact.Id != 0)
        {
            return database.UpdateAsync(contact);
        }
        else
        {
            return database.InsertAsync(contact);
        }
    }

    public Task<int> DeleteContactAsync(Contact contact)
    {
        return database.DeleteAsync(contact);
    }
}





