using System.Data;
using System.Runtime.ConstrainedExecution;

namespace Lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            DataTable MyTable = new DataTable(); // 1
            DataTable MyTableByName = new DataTable("MyTableName"); // 2

            Console.WriteLine("Please enter a number between 1 and 100");          
                double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number         Squared        Cubed");
            Console.WriteLine("========       =======       =======");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(FindSquare(i));
                Console.WriteLine(FindCube(i));           
            }
        }
        public static double FindSquare(double n)
        {
            return (n * n);
        }

        public static double FindCube(double n)
        {
            return (n * n * n);
        }
    }
}