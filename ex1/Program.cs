// See https://aka.ms/new-console-template for more information

namespace ex1
{
    public class Program{
        public static void Main(string[] args){
            string result1 = Kata.SpinWords("Faça a pessoa que você gosta se sentir especial ao invés de só mais uma.");
            string result2 = Kata.SpinWords("A vida e uma caixa preta nunca saberemos o seu real significado.⁠");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    public class Kata{
        public static string SpinWords(string sentence){
            string[] words = sentence.Split(" ");
            for(int i = 0; i < words.Length; i++){
                words[i] = words[i].Length >= 5 ? new string(words[i].Reverse().ToArray()) : words[i];
            }
            return string.Join(" ", words);
        }
    }
}
