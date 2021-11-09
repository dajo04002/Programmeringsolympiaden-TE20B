using System;

namespace Upg1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kuvert= 0.074196;
            double affish= 0.12474;
            double information= 0.06237;

            Console.WriteLine("Kuvert ?");
            int kuvertVikt =int.Parse(Console.ReadLine());
            Console.WriteLine("Affish ?");
            int affishVikt =int.Parse(Console.ReadLine());
            Console.WriteLine("Blad ?");
            int bladVikt =int.Parse(Console.ReadLine());

            double sum= (kuvertVikt*kuvert*2)+(affishVikt*affish*2)+(bladVikt*information);
            
            Console.WriteLine(sum);

        }
    }
}
