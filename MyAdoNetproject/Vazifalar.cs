using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdoNetproject
{
    public class Vazifalar
    {
       
        public string Create_table(string table_name)
        {

            string query = $"create table {table_name} (id serial, name varchar(40), age int)";
            return query;
        }

        public string Insert_one(string table)
        {
            string query = $"insert into {table} (name, age) values ('Jack', 50)";
            Console.WriteLine(query);
            return query;
        }
       
       
        
        public string InsertMany(string table_name)
        {
            IList<Users> users = new List<Users>()
            {
                new Users() { name = "Akmalxoja", age = 20 },
                new Users() { name = "Aziz", age = 30 },
                new Users() { name = "Otabek", age = 18 },
            };

            string query = $"insert into {table_name}(name, age) values ";

            for (int i = 0; i < users.Count; i++)
            {
                query += $@"('{users[i].name}', {users[i].age}), ";
            }

            return query.Substring(0, query.Length - 2) + ';';
        }

        public string GetAll(string table_name)
        {
            
            string query = $"select *from {table_name}";
            return query;
        }

        public string GetbyId(string table_name, int id){
            
            string query = $"select *from {table_name} where id = {id}";
            return query;

        }






    }
}
