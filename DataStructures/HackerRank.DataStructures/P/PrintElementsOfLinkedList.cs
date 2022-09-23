using HackerRank.Utilities.Types;

namespace HackerRank.DataStructures;

public class PrintElementsOfLinkedList
{

    public static List<object> results;
    /*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode next;
 * }
 *
 */
    public static void printLinkedList(SinglyLinkedListNode head)
    {
        // For Testing
        results = new List<object>();
        while (head is not null)
        {
            Console.WriteLine(head.data);
            // For Testing
            results.Add(head.data);
            if (head.next is  null)
            {
                return;
            }
            head = head.next;
            
        }
    }


}
