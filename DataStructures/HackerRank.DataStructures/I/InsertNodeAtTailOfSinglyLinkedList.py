def InsertNodeAtTail(head, data):
    if head is None:
        return SinglyLinkedListNode(data, None)
    else:
        if head.next is None:
            head.next = SinglyLinkedListNode(data, None)
        else:
            InsertNodeAtTail(head.next, data)
        return head


class SinglyLinkedListNode:
    def __init__(self, data, node):
        self.data = data
        self.node = node
