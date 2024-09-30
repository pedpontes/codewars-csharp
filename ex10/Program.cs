


using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ex10 
{
    public class Program{
        public static void Main(string[] args){
            ListNode l1 = BuildList([1,2,5,6]);
            ListNode l2 = BuildList([6,8,2,4]);
            ListNode result = AddTwoNumbers(l1, l2);
            while(result != null){
                Console.Write(result.val);
                result = result.next;
            }
        }

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2){
            string[] nums = [
                ConvertListToString(l1),
                ConvertListToString(l2)
            ];

            char[] sum = (BigInteger.Parse(nums[0]) + BigInteger.Parse(nums[1])).ToString().ToCharArray();

            ListNode head = new ListNode(int.Parse(sum[0].ToString()));
            ListNode aux = head;

            for(int i = 1; i<sum.Length; i++){
                aux.next = new ListNode(int.Parse(sum[i].ToString()));
                aux = aux.next;
            }
            return head;
        }

        private static string ConvertListToString(ListNode list){
            string numString = "";
            while(list != null){
                numString = $"{list.val}{numString}";
                list = list.next;
            }
            return numString;
        }

        public static ListNode BuildList(int[] values) {
            if (values.Length == 0) return null;
            
            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            
            for (int i = 1; i < values.Length; i++) {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
    
            return head;
        }
    }
}

