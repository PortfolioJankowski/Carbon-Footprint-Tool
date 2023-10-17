using Dapper;
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Test.Models;

namespace Test.Database
{
    public class EmissionsRepository
    {
        private string _connectionString;
        private string _tableName;

        public EmissionsRepository()
        {
            _connectionString = LoadConnectionString();
            _tableName = "EmissionsTbl";          
        }

        public string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Dodawanie emisji do grida na pierwszej formie
        public void AddRecord(EmissionModel emission)
        {          
                using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (IDbCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = $"INSERT INTO {_tableName} (Source, Unit, Value, Location) VALUES (@Source, @Unit, @Value, @Location)";
                        cmd.Parameters.Add(new SqliteParameter("@Source", emission.Source));
                        cmd.Parameters.Add(new SqliteParameter("@Unit", emission.Unit));
                        cmd.Parameters.Add(new SqliteParameter("@Value", emission.Value));
                        cmd.Parameters.Add(new SqliteParameter("@Location", emission.Location));
                        cmd.ExecuteNonQuery();
                    }
                }
            }           
        

        // Pobieranie danych o emisjach żeby dodać je do grida na pierwszej formie
        public List<EmissionModel> GetAllEmissions()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                return cnn.Query<EmissionModel>($"Select Id AS ID, Source, Unit, Value, Location from {_tableName}").ToList();
            }
        }

        public List<FactorModel> GetAllFactors()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                return cnn.Query<FactorModel>("SELECT * FROM FactorsTbl").ToList();
            }
        }

        public void UpdateRecord(int id, string source, string unit, double value, string location)
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                // Ustawiam zapytanie, potem je wykonuje i przekazuje wartości z parametrów metody do parametrów zapytania
                string query = $"UPDATE {_tableName} SET Source = @Source, Unit = @Unit, Value = @Value, Location = @Location WHERE Id = @Id";
                cnn.Execute(query, new { Id = id, Source = source, Unit = unit, Value = value, Location = location });
            }
        }

        public void DeleteRecord(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                string query = $"Delete From {_tableName} where Id = @Id";
                cnn.Execute(query, new { Id = id });
            }
        }
    }
}
