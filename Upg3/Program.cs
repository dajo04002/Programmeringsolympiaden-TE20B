using System;

namespace Upg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antal med grönt kort?");
            int M = int.Parse(Console.ReadLine());
            int s = 0;

            if(M % 2 == 0){
                s = (M/2)+(2);
            }
            else{
                s = ((M+1)/2)+(2);
            }
            Console.WriteLine(s*10);


            //2 1 30
            //2 2 30
            //2 3 40
            //2 4 40
            //2 5 50
            //2 6 50
            //2 7 60
            //2 8 60

        }
    }
}
