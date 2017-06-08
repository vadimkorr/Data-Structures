using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
            this.Next = null;
        }
        public T Value { get; set; }
        public ListItem<T> Next { get; set; }
    }
}
