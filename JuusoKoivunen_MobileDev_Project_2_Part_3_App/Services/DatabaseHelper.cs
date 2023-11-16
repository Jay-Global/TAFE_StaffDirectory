namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.Services;

public class DatabaseHelper
{
    SQLiteAsyncConnection _database;

    public DatabaseHelper()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Database.db");
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Employee>().Wait();
    }

    // Clear or truncate the SQLite database
    public void ClearDatabase()
    {
        try
        {
            _database.DropTableAsync<Employee>();
            _database.CreateTableAsync<Employee>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error clearing database: {ex.Message}");
        }
    }

    #region C R U D Operations
    //C
    public async Task AddStudentAsync(Employee details)
    {
        await _database.InsertAsync(details);
    }

    //R
    public async Task<List<Employee>> GetStudentsAsync()
    {
        return await _database.Table<Employee>().ToListAsync(); //SELECT * FROM STUDENT(TABLE)
    }

    //U
    public async Task UpdateStudentAsync(Contact details)
    {
        await _database.UpdateAsync(details);
    }

    //D
    public async Task DeleteStudentAsync(Employee details)
    {
        await _database.DeleteAsync(details);
    }
    #endregion
}





