using DataAccess;

namespace Bookish.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Database database = new Database();
            
            database.GetAllBooks();
        }
    }
}