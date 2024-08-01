


namespace ex6
{
    public class Kata{
        public static void Main(string[] args){
            Console.WriteLine(ZeroFuel(50,25,2));
            Console.WriteLine(ZeroFuel(100,50,1));
        }
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft){
            return distanceToPump <= mpg * fuelLeft;
        }
    }
}