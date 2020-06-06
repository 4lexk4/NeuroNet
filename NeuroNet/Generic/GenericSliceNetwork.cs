using System.Collections.Generic;

namespace NeuroNet.Generic
{
    public abstract class GenericSliceNetwork<T> : ISliceNetwork<T>
    {
        protected ISlice<T> InputSlice => Slices[0];

        protected ISlice<T> OutputSlice => Slices[Slices.Count - 1];

        public IList<ISlice<T>> Slices { get; } = new List<ISlice<T>>();

        public abstract void Calculate(T[] inputValues, T[] outputValues);
    }
}