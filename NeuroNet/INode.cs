namespace NeuroNet
{
    public interface INode<T>
    {
        T Output { get; set; }

        void ResetCache();
    }
}