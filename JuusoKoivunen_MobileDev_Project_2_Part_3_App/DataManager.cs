using System.Text.Json;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public static class DataManager
{
    static string _fileName = Path.Combine(FileSystem.AppDataDirectory, "contacts.json");

    public static List<Person> Contacts { get; set; }

    public static async Task SaveContactsAsync()
    {
        string json = JsonSerializer.Serialize(Contacts);
        await File.WriteAllTextAsync(_fileName, json);
    }

    public static async Task LoadContactsAsync()
    {
        if (File.Exists(_fileName))
        {
            string json = await File.ReadAllTextAsync(_fileName);
            Contacts = JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
        }
    }
}

