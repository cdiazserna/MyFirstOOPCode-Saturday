using System;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObject = new Date(2025, 2, 29);
                Console.WriteLine(dateObject.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
