using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List_With_Child_Elements
{
    /// <summary>
    /// In addition to the next and previous pointers, each element has a child pointer, 
    /// which may or may not point to a separate doubly linked list.
    /// These child lists may have one or more children of their own, and so on, 
    /// to produce a multilevel data structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DoublyLinkedListWithChildElements<T>
    {
        ListElement<T> _head;
        ListElement<T> _tail;

        /// <summary>
        /// Flatten the list so that all the nodes appear in a single-level, doubly linked list. 
        /// You are given the head and tail of the first level of the list.
        /// </summary>
        public void FlattenList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unflatten the list created by the previous problem and restore 
        /// the data structure to its original condition.
        /// </summary>
        public void UnflattenList()
        {
            throw new NotImplementedException();
        }
    }
}
