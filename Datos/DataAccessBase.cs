using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;

namespace Datos
{
    public abstract class DataAccessBase
    {
        protected readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["AccessConnectionString"].ConnectionString;

        private readonly string _tableName;

        protected DataAccessBase(string tableName)
        {
            _tableName = tableName;
        }

        protected OleDbConnection CreateConnection()
        {
            return new OleDbConnection(_connectionString);
        }

        protected static OleDbCommand CreateCommand(string query, OleDbConnection connection,
            params OleDbParameter[] parameters)
        {
            var command = new OleDbCommand(query, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            Debug.WriteLine("Command Text: " + command.CommandText);

            foreach (OleDbParameter parameter in command.Parameters)
            {
                Debug.WriteLine($"{parameter.ParameterName}: " + parameter.Value);
            }

            return command;
        }

        protected DataTable ExecuteQuery(string query, params OleDbParameter[] parameters)
        {
            var dataTable = new DataTable();

            using (var connection = CreateConnection())
            {
                using (var command = CreateCommand(query, connection, parameters))
                {
                    connection.Open();

                    using (var adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        protected int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            var affectedRows = 0;

            using (var connection = CreateConnection())
            {
                using (var command = CreateCommand(query, connection, parameters))
                {
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        protected object ExecuteScalar(string query, params OleDbParameter[] parameters)
        {
            object result;

            using (var connection = CreateConnection())
            {
                using (var command = CreateCommand(query, connection, parameters))
                {
                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }

            return result;
        }

        protected bool Exists(params OleDbParameter[] parameters)
        {
            var query =
                $"SELECT COUNT(*) FROM {_tableName} WHERE {string.Join(" AND ", parameters.Select(p => $"{p.ParameterName} = ?"))}";

            var result = (int)ExecuteScalar(query, parameters);

            return result > 0;
        }

        protected DataTable GetAll(string whereClause = "", params OleDbParameter[] parameters)
        {
            var query = $"SELECT * FROM {_tableName}";

            if (!string.IsNullOrEmpty(whereClause)) query += $" WHERE {whereClause}";

            return ExecuteQuery(query, parameters);
        }

        protected DataTable GetBy(string whereClause, params OleDbParameter[] parameters)
        {
            var query = $"SELECT * FROM {_tableName} WHERE {whereClause}";

            return ExecuteQuery(query, parameters);
        }

        public DataTable GetById(int id)
        {
            return GetBy("ID = ?", new OleDbParameter("ID", id));
        }

        protected bool Insert(params OleDbParameter[] parameters)
        {
            var query =
                $"INSERT INTO {_tableName} ({string.Join(", ", parameters.Select(p => p.ParameterName))}) VALUES ({string.Join(", ", parameters.Select(p => "?"))})";

            return ExecuteNonQuery(query, parameters) > 0;
        }

        protected bool Update(OleDbParameter[] setParameters, string whereClause,
            params OleDbParameter[] whereParameters)
        {
            var setClause = string.Join(", ", setParameters.Select(p => $"{p.ParameterName} = ?"));
            var query = $"UPDATE {_tableName} SET {setClause} WHERE {whereClause}";

            var allParameters = setParameters.Concat(whereParameters).ToArray();

            return ExecuteNonQuery(query, allParameters) > 0;
        }

        protected bool Delete(string whereClause, params OleDbParameter[] parameters)
        {
            var query = $"UPDATE {_tableName} SET Activo = FALSE WHERE {whereClause}";

            return ExecuteNonQuery(query, parameters) > 0;
        }
    }
}