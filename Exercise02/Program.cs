using System;
using Exercise01;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Numbers numbers = new Numbers();
                var words = numbers.Towards(); // call the extention method
                Console.WriteLine(words);
                Console.Read();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
