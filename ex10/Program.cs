


using System.Collections;

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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2){
            string[] nums = new string[2];

            while(l1 != null){
                nums[0] = $"{l1.val}{nums[0]}";
                l1 = l1.next;
            }
            while(l2 != null){
                nums[1] = $"{l2.val}{nums[1]}";
                l2 = l2.next;
            }
            int sum = nums.Aggregate(0,(current, val) => current + int.Parse(val));
            string sumString = new string(sum.ToString().Reverse().ToArray());

            ListNode head = new ListNode(int.Parse(sumString[0].ToString()));
            ListNode aux = head;

            for(int i = 1; i<sumString.Length; i++){
                aux.next = new ListNode(int.Parse(sumString[i].ToString()));
                aux = aux.next;
            }
            return head;
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
        public class ListNode{
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null){
                this.val = val;
                this.next = next;
            }
        }
}

