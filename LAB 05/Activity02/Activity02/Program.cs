using System;
using System.IO;

namespace program
{
    public class Class1
    {
        static void Main(string[] args)
        {
            TestCatch2();
        }

        static void TestCatch2()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\233597\source\repos\ConsoleApp10\test.txt")) // Replace "YourUsername" with your actual username
                {
                    sw.WriteLine("hello");
                    Console.WriteLine("Wrote to file: C:\\Users\\233597\\source\\repos\\ConsoleApp10\\test.txt");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
