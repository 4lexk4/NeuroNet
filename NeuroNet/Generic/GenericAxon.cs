namespace NeuroNet.Generic
{
    public abstract class GenericAxon<T> : GenericNode<T>, IAxon<T>
    {
        public INeuron<T> InputNeuron { get; set; }

        public T Capacity { get; set; }
    }
}
