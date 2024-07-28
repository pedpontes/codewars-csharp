// See https://aka.ms/new-console-template for more information

namespace ex1
{
    public class Program{
        public static void Main(string[] args){
            string result = Kata.SpinWords("Erro no dicionario");
            Console.WriteLine(result);
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
