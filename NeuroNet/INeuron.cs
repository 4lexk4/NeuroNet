using System.Collections.Generic;

namespace NeuroNet
{
    public interface INeuron<T> : INode<T>
    {
        IList<IAxon<T>> InputAxons { get; }

        T Bias { get; set; }
    }
}