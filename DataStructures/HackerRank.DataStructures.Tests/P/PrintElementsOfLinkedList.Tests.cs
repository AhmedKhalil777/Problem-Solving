using FluentAssertions;
using HackerRank.Utilities.Types;

namespace HackerRank.DataStructures.Tests;

public class PrintElementsOfLinkedList
{

    [Fact]
    public void printLinkedList_GivenASinglyLinkedList_ShouldPrintAllItems()
    {
        // Arrange 
        var linkedList = new SinglyLinkedListNode
        {
            data = "A",
            next = new SinglyLinkedListNode
            {
                data = "B",
                next = new SinglyLinkedListNode
                {
                    data = "C",
                }
            }
        };
        
        // Act
        DataStructures.PrintElementsOfLinkedList.printLinkedList(linkedList);
        
        // Assert
        DataStructures.PrintElementsOfLinkedList.results.Should().Equal(new List<string> { "A", "B", "C" });
    }
}