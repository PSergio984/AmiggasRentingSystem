using System.Data.SQLite;
using System.Data;

public class DatabaseManager
{
    private string connectionString;

    public DatabaseManager()
    {
        SetUpDatabaseConnection();
    }

    private void SetUpDatabaseConnection()
    {
        try
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directory = new DirectoryInfo(baseDir);

            while (directory != null && !directory.Name.Equals("AmiggasRentingSystem", StringComparison.OrdinalIgnoreCase))
            {
                directory = directory.Parent;
            }

            if (directory == null)
            {
                throw new Exception("Project root 'AmiggasRentingSystem' could not be determined.");
            }

            string dbFilePath = Path.Combine(directory.FullName, "Database", "rentingDB.db");
            connectionString = $"Data Source={dbFilePath};Version=3;";
        }
        catch (Exception ex)
        {
            throw new Exception($"Error setting up database path: {ex.Message}");
        }
    }

    public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
    {
        DataTable dataTable = new DataTable();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
        }

        return dataTable;
    }

    public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                return command.ExecuteNonQuery();
            }
        }
    }
}

