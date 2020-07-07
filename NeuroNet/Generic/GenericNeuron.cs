using System.Collections.Generic;

namespace NeuroNet.Generic
{
    public abstract class GenericNeuron<T> : GenericNode<T>, INeuron<T>
    {
        public IList<IAxon<T>> InputAxons { get; } = new List<IAxon<T>>();
    }
}