using System.Collections;

namespace Binary_Search_Tree.Helpers
{
    class Comparer<T> : IComparer
    {
        public int Compare(object x, object y)
        {
            Node<T> xComp = x as Node<T>;
            Node<T> yComp = y as Node<T>;

            return
                xComp.Value.IsGraterThan(yComp.Value.Get())
                    ? 1
                    : xComp.Value.IsLessThan(yComp.Value.Get())
                        ? -1
                        : 0;
        }
    }
}
