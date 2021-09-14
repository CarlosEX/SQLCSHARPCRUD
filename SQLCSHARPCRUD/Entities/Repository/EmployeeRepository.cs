using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace SQLCSHARPCRUD {
    public class EmployeeRepository : IEmployeeRepository {

        private readonly DbProviderFactory _factory;
        private readonly string _provider;
        private readonly string _connectionString;

        public EmployeeRepository() {

            _provider = ConfigurationManager.AppSettings["providerSQL"];
            _connectionString = ConfigurationManager.AppSettings["connectionStringSQL"];
            _factory = DbProviderFactories.GetFactory(_provider);
        }

        public IList<IEmployee> GetAll() {

            var employees = new List<IEmployee>();

            using (var connection = _factory.CreateConnection()) {
                connection.ConnectionString = _connectionString;
                connection.Open();
                using (var command = _factory.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select * from Employees order by Id;";
                    using (DbDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {

                            IEmployee employee = EmployeeFactory.Create();
                            employee.Id = (int)reader["Id"];
                            employee.FirstName = (string)reader["FirstName"];
                            employee.LastName = (string)reader["LastName"];

                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }

        public DataTable GetGenderDataTable() {
            using (var connection = _factory.CreateConnection()) {
                connection.ConnectionString = _connectionString;
                connection.Open();
                using (var command = _factory.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select * from Employees;";
                    using (var adapter = _factory.CreateDataAdapter()) {
                        using (var dataTable = new DataTable()) {
                            adapter.SelectCommand = command;
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
        }

        public void Add(IEmployee employee) {
            using (var connection = _factory.CreateConnection()) {
                connection.ConnectionString = _connectionString;
                connection.Open();
                using (var command = _factory.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = 
                        $"insert into Employees " +
                        $"(FirstName, LastName) " +
                        $"values ('{employee.FirstName}', '{employee.LastName}')";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(IEmployee employee) {
            using (var connection = _factory.CreateConnection()) {
                connection.ConnectionString = _connectionString;
                connection.Open();
                using (var command = _factory.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = 
                        $"update Employees " +
                        $"set FirstName = '{employee.FirstName}', " +
                        $"LastName = '{employee.LastName}'" +
                        $" where Id = {employee.Id};";
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id) {
            using (var connection = _factory.CreateConnection()) {
                connection.ConnectionString = _connectionString;
                connection.Open();
                using (var command = _factory.CreateCommand()) {
                    command.Connection = connection;
                    command.CommandText = $"delete from Employees Where Id = {id};";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
