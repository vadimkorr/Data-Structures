using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class Program
    {
        public static void Show(SinglyLinkedList<string> sll)
        {
            foreach (ListItem<string> li in sll)
            {
                Console.Write(li.Value + " ");
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {


            SinglyLinkedList<string> sll = new SinglyLinkedList<string>();

            try
            {

                //Adding item
                for (int i = 0; i < 10; i++)
                {
                    sll.Add(i.ToString());
                }

                //show items
                Show(sll);
                Console.WriteLine("\nCount = " + sll.GetCount());

                //get m-th to last item
                Console.WriteLine("M-th to last: " + sll.GetMToLastItem(6).Value);

                //get i-th to first item
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(sll[i].Value);
                }
                //Console.WriteLine(sll[10].Value);//Exception

                Console.WriteLine("===== DELETING =====");
                //Delete last element
                ListItem<string> toDelete = sll[9];
                sll.Delete(toDelete);
                Show(sll);

                //Delete middle element
                toDelete = sll[2];
                sll.Delete(toDelete);
                Show(sll);

                //Delete head element
                toDelete = sll[0];
                sll.Delete(toDelete);
                Show(sll);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
