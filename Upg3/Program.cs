using System;

namespace Upg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antal utan grönt kort?");
            int M = int.Parse(Console.ReadLine());
            int s = 0;

            if(M % 2 == 0){
                s = (M/2)+(2);
            }
            else{
                s = ((M+1)/2)+(2);
            }
            Console.WriteLine(s*10);
        }
    }
}
