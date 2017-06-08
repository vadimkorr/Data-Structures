using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List_With_Child_Elements
{
    class ListElement<T>
    {
        ListElement<T> Next { get; set; }
        ListElement<T> Prev { get; set; }
        ListElement<T> Child { get; set; }
        T Value { get; set; }
    }
}
