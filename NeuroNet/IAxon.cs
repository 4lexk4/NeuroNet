namespace NeuroNet
{
    public interface IAxon<T> : INode<T>
    {
        INeuron<T> InputNeuron { get; set; }

        T Capacity { get; set; }
    }
}
