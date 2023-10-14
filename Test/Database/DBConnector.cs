using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Database
{
    public class DBConnector
    {
        private string _connectionString;

        public DBConnector()
        {
            _connectionString = LoadConnectionString();
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
                    cmd.CommandText = "INSERT INTO EmissionsTbl (Source, Unit, Value, Location) VALUES (@Source, @Unit, @Value, @Location)";
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
            List<EmissionModel> emissions = new List<EmissionModel>();
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                var EmissionsFromDb = cnn.Query<EmissionModel>("Select Id AS ID, Source, Unit, Value, Location from EmissionsTbl").ToList();

                foreach (var emission in EmissionsFromDb)
                {
                    emission.Value = Convert.ToDouble(emission.Value);
                }

                return EmissionsFromDb;
            }
        }

        public void UpdateRecord(int id, string source, string unit, double value, string location)
        {
            
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                // Ustawiam zapytanie, potem je wykonuje i przekazuje wartości z parametrów metody do parametrów zapytania
                string query = "UPDATE EmissionsTbl SET Source = @Source, Value = @Value, Location = @Location WHERE Id = @Id";
                cnn.Execute(query, new { Id = id, Source = source, Value = value, Location = location });
                MessageBox.Show("Pomyślnie zaktualizowano wiersz");

            }


        }
    }
}
