using HackerRank.Utilities.PythonIntrop;
using HackerRank.Utilities.Types;

namespace HackerRank.DataStructures;

public class InsertNodeAtTailOfSinglyLinkedList
{
    
    public static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
        var pyScript = File.ReadAllText("./I/InsertNodeAtTailOfSinglyLinkedList.py");
        var res  = pyScript.ExecutePy("InsertNodeAtTail", head, data);

        return new SinglyLinkedListNode();
    }
    public static SinglyLinkedListNode insertNodeAtTail1(SinglyLinkedListNode head, int data)
    {
            if (head == null){
                head = new SinglyLinkedListNode();
                head.data = data;
            }
            else {
                SinglyLinkedListNode node = head;
                while (node.next != null){
                    node = node.next;
                }
                node.next = new SinglyLinkedListNode();
                node.next.data = data;
            }
            return head;
    }

}