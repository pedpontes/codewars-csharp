


namespace ex3
{
    public class Kata{
        public static void Main(string[] args){

            Console.WriteLine(Smash(["hello", "world", "this", "is", "great"]));
        }

        public static string Smash(string[] words){
            return string.Join(" ", words).Trim();
        }
    }

}