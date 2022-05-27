using System;
namespace generictest
{
    public class MaxAmongMoreThanThree<T> where T : IComparable
    {
        public T[] values;

        public MaxAmongMoreThanThree(T[] values)
        {
            this.values = values;
        }

        public T[] SortValues(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T FindMax(T[] values)
        {
            //Storing max value in maxValue variable
            //this keyword used for accessing instance/class level variable
            var sortedValues = SortValues(this.values);
            return sortedValues[sortedValues.Length - 1];
        }

        public T FindMaxMethod()
        {
            var maxValue = FindMax(this.values);
            return maxValue;
        }
    }
}
