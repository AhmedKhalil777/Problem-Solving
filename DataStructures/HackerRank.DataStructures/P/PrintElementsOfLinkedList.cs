namespace HackerRank.DataStructures;

public class PrintElementsOfLinkedList
{

    public static List<string> results;
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
        results = new List<string>();
        while (head is not null)
        {
            Console.WriteLine(head.data);
            results.Add(head.data);
            if (head.next is  null)
            {
                return;
            }
            head = head.next;
            
            // For Testing
        }
    }


}

public class SinglyLinkedListNode
{
    public SinglyLinkedListNode? next { get; set; }
    public string data { get; set; }
}