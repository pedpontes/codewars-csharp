


namespace ex5
{
    public class Program{
        public static void Main(string[] args){
            ListAlphabet(10);
        }
        public static void ListAlphabet(int num){
            int index = 0;
            char[] chars = new char[num];
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            foreach (char c in alpha){
                if(index < chars.Length) chars[index++] = c;
            }
            foreach (char c in chars){
                Console.Write(c + " ");
            }
        }
    }
}