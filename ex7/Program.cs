namespace ex7
{
    public class Kata{
        public static void Main(string[] args){
            Console.WriteLine(GetGrade(95,90,93));
            Console.WriteLine(GetGrade(70,70,100));
            Console.WriteLine(GetGrade(70,71,72));
            Console.WriteLine(GetGrade(32,15,21));
            Console.WriteLine(GetGrade(65,66,60));
        }
        public static char GetGrade(int s1, int s2, int s3){
            int mean = (s1+s2+s3)/3;
            if(mean < 60) return 'F';
            else if(mean < 70) return 'D';
            else if(mean < 80) return 'C';
            else if(mean < 90) return 'B';
            else return 'A';
        }
    }
}