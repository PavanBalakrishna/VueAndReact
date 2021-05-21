using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Datastructures
{
    public interface IDoublyLinkedList<T>
    {
        IDoublyLinkedListNode<T> Head { get; set; }

        IDoublyLinkedListNode<T> Tail { get; set; }

        
    }

    public interface IDoublyLinkedListNode<T>
    {
        T Data { get; set; }
        IDoublyLinkedListNode<T> Previous { get; set; }

        IDoublyLinkedListNode<T> Next { get; set; }
    }


}
