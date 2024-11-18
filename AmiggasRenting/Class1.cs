using System;
using System.Data;
using System.Data.SQLite; // Import SQLite namespace for database operations
using System.IO;

namespace AmiggasRenting
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            SetUpDatabaseConnection();
        }

        // Method to set up the database connection string
        private void SetUpDatabaseConnection()
        {
            try
            {
                // Navigate up to the correct project root
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo directory = new DirectoryInfo(baseDir);

                // Explicitly navigate up to "AmiggasRentingSystem"
                while (directory != null && !directory.Name.Equals("AmiggasRentingSystem", StringComparison.OrdinalIgnoreCase))
                {
                    directory = directory.Parent;
                }

                if (directory == null)
                {
                    throw new Exception("Project root 'AmiggasRentingSystem' could not be determined. Please check the directory structure.");
                }

                // Construct the database file path
                string projectRoot = directory.FullName;
                string dbFilePath = Path.Combine(projectRoot, "Database", "rentingDB.db");

                // Set the connection string
                connectionString = $@"Data Source={dbFilePath};Version=3;";
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while setting up the database path: {ex.Message}", ex);
            }
        }

        // Method to execute a query and return a DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // You can add more methods to insert, update, delete data as needed
        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}