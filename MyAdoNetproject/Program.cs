using Npgsql;

namespace MyAdoNetproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = "Server=127.0.0.1; Port=5432; Database=Mydb; User Id=postgres; Password=root";

            Vazifalar vazifalar = new Vazifalar();
           


           string query = vazifalar.GetbyId("students", 2);

            NpgsqlConnection connection = new NpgsqlConnection(connectionstring);

            connection.Open();

            NpgsqlCommand command = new  NpgsqlCommand (query,connection);


           // Read qilish uchun
           /* NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(0)}. {reader.GetString(1)}  {reader.GetInt32(2)}");

            }*/




           

            connection.Close();



        }
       


    }

}
