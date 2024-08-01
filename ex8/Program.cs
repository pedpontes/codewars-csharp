using System.Linq;

namespace ex8
{
    public class Kata{
        public static void Main(string[] args){
            Console.WriteLine(BetterThanAverage([100, 40, 34, 57, 29, 72, 57, 88], 50));
        }
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints){
            return YourPoints > ClassPoints.Average();
        }
    }
}