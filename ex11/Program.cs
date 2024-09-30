using System.Linq;

public class Kata
{
    public static void Main(string[] args){
        System.Console.WriteLine(Rgb(int.Parse(args[0]),int.Parse(args[1]),int.Parse(args[2])));
    }
    public static string Rgb(int r, int g, int b) 
    {
        return ConvertDecimalToHex(r) + ConvertDecimalToHex(g) + ConvertDecimalToHex(b);
    }
  
    private static string ConvertDecimalToHex(int dec){
        if(dec > 255 || dec < 0) return dec > 255 ? "FF" : "00";
        string hex = "";
        var hexDictionary = new Dictionary<char, int>
        {
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'A', 10 },
            { 'B', 11 },
            { 'C', 12 },
            { 'D', 13 },
            { 'E', 14 },
            { 'F', 15 }
        };

        while(dec > 15){
            hex = hexDictionary.First(item => item.Value == dec % 16).Key.ToString() + hex;
            dec /= 16;
        }
        hex = hexDictionary.First(item => item.Value == dec).Key.ToString() + hex;
        return hex;
    }
}