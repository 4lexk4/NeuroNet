using System.Collections.Generic;

namespace NeuroNet
{
    public interface ISliceNetwork<T> : INetwork
    {
        IList<ISlice<T>> Slices { get; }

        void Calculate(T[] inputValues, T[] outputValues);
    }
}