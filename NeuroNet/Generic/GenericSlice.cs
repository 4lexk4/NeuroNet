using System.Collections.Generic;

namespace NeuroNet.Generic
{
    public abstract class GenericSlice<T> : ISlice<T>
    {
        public IList<INeuron<T>> Neurons { get; } = new List<INeuron<T>>();

        public void ConnectWith<TAxon>(ISlice<T> nextSlice) where TAxon : IAxon<T>, new()
        {
            foreach (var fromNeuron in Neurons)
            {
                foreach (var toNeuron in nextSlice.Neurons)
                {
                    var axon = new TAxon
                    {
                        InputNeuron = fromNeuron
                    };
                    toNeuron.InputAxons.Add(axon);
                }
            }
        }
    }
}
