using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class SinglyLinkedList<T>: IEnumerable
    {
        private ListItem<T> _head;

        //GET i-th ITEM (STARTING FROM THE FIRST ITEM)
        public ListItem<T> this[int index]
        {
            get
            {
                if (_head == null)
                {
                    throw new Exception("There are no items in the list ");
                }
                ListItem<T> current = _head;
                int currentIndex = 0;
                while (current != null && currentIndex != index)
                {
                    current = current.Next;
                    currentIndex++;
                }
                if (current != null)
                {
                    return current;
                }
                else
                {
                    throw new Exception(string.Format("There is no item with index {0} in the list", index));
                }
            }
        }

        //ADD ITEM (TO THE END OF THE LIST)
        public void Add(T value) {
            if (this._head == null)
            {
                _head = new ListItem<T>(value);
            }
            else {
                ListItem<T> li = new ListItem<T>(value);
                ListItem<T> last = GetLast();
                last.Next = li;
            }
        }

        //GET LAST ELEMENT
        public ListItem<T> GetLast()
        {
            ListItem<T> current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        //GET SIZE OF THE LIST
        public int GetCount()
        {
            int count = 0;
            ListItem<T> current = _head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //GET M-th ITEM STARTING FROM THE LAST ITEM
        public ListItem<T> GetMToLastItem(int m)
        {
            ListItem<T> current;
            int i;
            if (_head == null)
            {
                throw new Exception("There are no items in the list");
            }
            /* Advance current m elements from beginning,
            * checking for the end of the list
            */
            current = _head;
            for (i = 0; i < m; i++)
            {
                if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    throw new Exception(string.Format("List contains less than {0} items", m));
                }
            }
            /* Start mBehind at beginning and advance pointers
             * together until current hits last element
             */
            ListItem<T> mBehind = _head;
            while (current.Next != null)
            {
                current = current.Next;
                mBehind = mBehind.Next;
            }
            /* mBehind now points to the element we were
             * searching for, so return it 
             */
            return mBehind;
        }
        //ITERATE OVER LIST
        public IEnumerator GetEnumerator()
        {
            ListItem<T> current = _head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
