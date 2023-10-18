using Dapper;
using Microsoft.Data.Sqlite;
using OfficeOpenXml.Drawing.Chart;
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

        public decimal GetTotalEmissions()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                var result = cnn.Query<decimal?>(
            "SELECT SUM(E.Value * F.Value) " +
            "FROM EmissionsTbl AS E " +
            "LEFT JOIN FactorsTbl AS F ON (E.Source = F.Source AND E.Unit = F.Unit)"
        ).FirstOrDefault();

                // Jeśli result jest null, zwróć 0 jako domyślną wartość
                return result ?? 0;
            }
        }

        public List<CalculationModel> GetAllCalculations()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                return cnn.Query<CalculationModel>(
                    "SELECT E.Source,E.Unit, E.Value, E.Value * F.Value as Result, E.Location " +
                    "FROM EmissionsTbl AS E " +
                    "LEFT JOIN FactorsTbl AS F" +
                    " ON (E.Source = F.Source AND E.Unit = F.Unit)").ToList();
            }
        }

        public List<PieChartDataModel> GetPieChartData()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                var results = cnn.Query<PieChartDataModel>(
                    "SELECT E.Location, SUM(E.Value * F.Value) AS TotalResult " +
                    "FROM EmissionsTbl AS E " +
                    "LEFT JOIN FactorsTbl AS F " +
                    "ON (E.Source = F.Source AND E.Unit = F.Unit) " +
                    "GROUP BY E.Location"
                ).ToList();

                return results;
            }
        }

        public List<LineChartDataModel> GetLineChartData()
        {
            using (IDbConnection cnn = new SQLiteConnection(_connectionString))
            {
                var results = cnn.Query<LineChartDataModel>(
                    "SELECT E.Source, SUM(E.Value * F.Value) AS TotalResult " +
                    "FROM EmissionsTbl AS E " +
                    "LEFT JOIN FactorsTbl AS F " +
                    "ON (E.Source = F.Source AND E.Unit = F.Unit) " +
                    "GROUP BY E.Source"
                ).ToList();

                return results;
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
