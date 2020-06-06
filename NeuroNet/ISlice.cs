using System.Collections.Generic;

namespace NeuroNet
{
    public interface ISlice<T>
    {
        IList<INeuron<T>> Neurons { get; }

        void ConnectWith<TAxon>(ISlice<T> nextSlice) where TAxon : IAxon<T>, new();
    }
}