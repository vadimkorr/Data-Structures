using Binary_Search_Tree.Interfaces;

namespace Binary_Search_Tree.ExtraModels
{
    public class ComparableValue : IComparable<int>
    {
        private int _value;

        public int Get()
        {
            return this._value;
        }

        public ComparableValue(int value)
        {
            this._value = value;
        }

        public bool IsEq(int right)
        {
            return this._value == right;
        }

        public bool IsGraterOrEq(int right)
        {
            return this._value >= right;
        }

        public bool IsGraterThan(int right)
        {
            return this._value > right;
        }

        public bool IsLessOrEq(int right)
        {
            return this._value <= right;
        }

        public bool IsLessThan(int right)
        {
            return this._value < right;
        }
    }
}
