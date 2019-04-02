using System;

namespace fundamentalsi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; ++i){
                Console.Write("Number " + i.ToString() + "\n");
            }
            for (int i = 1; i <= 100; ++i){
                if (i%3==0 ^ i%5==0){
                    Console.Write("Number " + i.ToString() + "\n");
                }
            }
            for (int i = 1; i <= 100; ++i){
                if (i%3==0 && i%5!=0){
                    Console.Write(i.ToString() + " Fizz\n");
                }
                if (i%3!=0 && i%5==0){
                    Console.Write(i.ToString() + " Buzz\n");
                }
                if (i%3==0 && i%5==0){
                    Console.Write(i.ToString() + " FizzBuzz\n");
                }
            }
            Random rand = new Random();
            for (int i = 0; i < 10; ++i){
                Console.Write(rand.Next() + " " + rand.Next() + "\n");
            }
        }
    }
}
