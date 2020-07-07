using System;

namespace GeneticNet.Internal
{
    internal abstract class Chromosome<T> where T : IComparable<T>
    {
        internal abstract void SetRandomValue();

        protected abstract int Compare(T value1, T value2);

        protected Chromosome(int length, T minValue, T maxValue)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"{nameof(length)} must be 0 or greater");
            }

            if (minValue.CompareTo(maxValue) > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue), $"{nameof(minValue)} must be less or equal to {nameof(maxValue)}");
            }

            Values = new T[length];
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public T MinValue { get; }

        public T MaxValue { get; }

        public T[] Values { get; }
    }
}
