namespace NeuroNet.Generic
{
    public abstract class GenericAxon<T> : GenericNode<T>, IAxon<T>
    {
        private readonly int _indexOrderCapacity;

        protected GenericAxon()
        {
            _indexOrderCapacity = NumberOfParameters - 1;
        }

        protected override int NumberOfParameters => base.NumberOfParameters + 1;

        public INeuron<T> InputNeuron { get; set; }

        public T Capacity 
        {
            get => Parameters[_indexOrderCapacity];
            set => Parameters[_indexOrderCapacity] = value;
        }
    }
}