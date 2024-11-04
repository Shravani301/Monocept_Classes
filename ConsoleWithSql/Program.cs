using System.Data.SqlClient;

namespace ConsoleWithSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            //sqlConnection.Open();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                //Console.WriteLine(sqlConnection.State);
                //Console.WriteLine(sqlConnection.DataSource);
                //Console.WriteLine(sqlConnection.Database);
                //Console.WriteLine(sqlConnection.ConnectionTimeout);
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                var query = "select * from Emp where Id=@id";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlParameter parameter = new SqlParameter(@id,id);
                command.Parameters.Add(parameter);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("EmpId:" + reader["Id"] + "\nEName: " + reader["EName"]);

                    }
                }
                else
                    Console.WriteLine("No Such Employee found");
            }
            //sqlConnection.Close();
        }
    }
}
