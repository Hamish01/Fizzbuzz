using System;

namespace Fizzbop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            while (Number != 100)
            {
                Number++;
                if (Number % 15 == 0){
                    Console.WriteLine("fizzbuzz");
                }
                else{
                    if(Number % 5 == 0){
                        Console.WriteLine("Buzz");
                    }
                    else{
                        if (Number % 3 == 0){
                            Console.WriteLine("Fizz");
                        }
                        else{
                            Console.WriteLine(Number);
                        }
                    }
        
                }
            }
        }
    }
}
