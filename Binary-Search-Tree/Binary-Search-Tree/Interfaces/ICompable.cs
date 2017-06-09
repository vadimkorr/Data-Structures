
namespace Binary_Search_Tree.Interfaces
{
    public interface IComparable<T>
    {
        T Get();
        bool IsLessThan(T right);
        bool IsGraterThan(T right);
        bool IsLessOrEq(T right);
        bool IsGraterOrEq(T right);
        bool IsEq(T right);
    }
}
