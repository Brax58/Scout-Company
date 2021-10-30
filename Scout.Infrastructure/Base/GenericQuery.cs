using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scout.Infrastructure.Base
{
    public class GenericQuery
    {
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                return conn.Query<T>(sql, parameters).ToList();
            }
        }
    }
}
