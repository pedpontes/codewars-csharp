


namespace ex5
{
    public class Program{
        public static void Main(string[] args){
            ListAlphabet(10);
        }
        public static void ListAlphabet(int num){
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char[] chars = new char[num];

            for(int i = 0; i< num; i++) chars[i] = alpha[i];
            
            foreach (char c in chars){
                Console.Write(c + " ");
            }
        }
    }
}