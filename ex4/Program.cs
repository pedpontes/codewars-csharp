namespace ex4
{
    public class Kata{
        public static void Main(string[] args){
            int[] x = Maps([1, 2, 3]);
            foreach (int number in x)
            {
                Console.WriteLine(number);
            }
        }

        public static int[] Maps(int[] x){
            x = x.Select(x => x*2).ToArray();
            return x;
        }
    }
}