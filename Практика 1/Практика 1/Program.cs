using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-Q7UCNUH\SQLEXPRESS01;Database=Работа индивид;Integrated Security=True;";
            string query = "SELECT * FROM dbo.ИС";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        for (int i = 0; i< reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}\t");
                        }
                        Console.WriteLine();
                        while (reader.Read())
                        {
                            for(int i = 0;i< reader.FieldCount; i++)
                            {
                                Console.WriteLine($"{reader[i]}\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine("НАЖМИТЕ ЛЮБУЮ КЛАВИШУ ДЛЯ ВЫХОДА...");
            Console.ReadKey();
        }
    }
}
