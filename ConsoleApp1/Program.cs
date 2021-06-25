using System;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = "localhost",
                InitialCatalog = "Northwind",
                IntegratedSecurity = true,
                ConnectionIdleLifetime=3
            };
            using var con = new SqlConnection(builder.ConnectionString);
            Console.WriteLine(builder.ConnectionIdleLifetime);
            con.Open();
        }
    }
}
