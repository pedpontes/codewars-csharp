
namespace ex9
{
    public class Kata{
        public static void Main(string[] args){

            foreach (var item in Count("hoje em dia voce sabe"))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        public static Dictionary<char, int> Count(string str){
            Dictionary<char,int> strCount = new Dictionary<char, int>();
            foreach(char c in str){
                if(strCount.ContainsKey(c)) strCount[c]++;
                else    strCount.Add(c,1);
            }
            return strCount;
        }
    }
}