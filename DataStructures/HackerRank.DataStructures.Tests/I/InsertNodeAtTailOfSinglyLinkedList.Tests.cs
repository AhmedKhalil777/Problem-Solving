using FluentAssertions;
using HackerRank.Utilities.Types;

namespace HackerRank.DataStructures.Tests;

public class InsertNodeAtTailOfSinglyLinkedList
{
    [Fact]
    public void insertNodeAtTail_GivenALinkedListAndData_ShouldReturnTheModifiedLinkedList()
    {
        
        // Arrange 
        var linkedList = new SinglyLinkedListNode
        {
            data = 1,
            next = new SinglyLinkedListNode
            {
                data = 2,
                next = new SinglyLinkedListNode
                {
                    data = 3,
                }
            }
        };

        // Act
        var modiList = DataStructures.InsertNodeAtTailOfSinglyLinkedList.insertNodeAtTail(linkedList, 4);
        DataStructures.PrintElementsOfLinkedList.printLinkedList(modiList);

        // Assert
        DataStructures.PrintElementsOfLinkedList.results.Should().Equal(new List<object> { 1, 2, 3, 4 });
    }
}