using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Bookish.ConsoleApp;
using Dapper;

namespace DataAccess
{
    public class Database
    {
        private static IDbConnection db;
        
        public Database()
        {
            db = new SqlConnection("Server=localhost;Database=bookish;User Id=bookistService; Password=!qazxsw@12;");
        }

        public async void GetAllBooks()
        {
            var books = await db.QueryAsync<Book>("select * from books");

            foreach (var book in books)
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}