using System;

namespace GeneticNet
{
    public readonly struct Template<T> where T : IComparable<T>
    {
        public Template(T[] inputValues, T[] outputValues)
        {
            InputValues = inputValues ?? throw new ArgumentNullException(nameof(inputValues));
            OutputValues = outputValues ?? throw new ArgumentNullException(nameof(outputValues));
        }

        public T[] InputValues { get; }

        public T[] OutputValues { get; }
    }
}