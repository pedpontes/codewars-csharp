using System;
using System.Linq;

// See https://aka.ms/new-console-template for more information
namespace ex2
{
    public class Program{
        public static void Main(string[] args){
            int total = Kata.CountBits(2000);
            Console.WriteLine($"{total}");
        }
    }

    public class Kata{
        public static int CountBits(int n){
            int numBits = 0;
            int quoc;
            int divisor = 2;
            int dividendo = n;
            List<int> bin = new List<int>();

            do{
                quoc = dividendo/divisor;
                bin.Add(dividendo%divisor);
                dividendo = quoc;
            } while(quoc > 1);
            bin.Add(quoc);
            bin.Reverse();
            bin.ForEach(value => {
                    if(value == 1) numBits++;
                });
            return numBits;

        }
    }
}
