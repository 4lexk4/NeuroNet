namespace NeuroNet.Generic
{
    public abstract class GenericNode<T> : INode<T>
    {
        private T _cachedValue;
        private bool _cached;

        protected GenericNode()
        {
            Parameters = new T[NumberOfParameters];
        }

        protected virtual int NumberOfParameters { get; } = 0;

        public T Output
        {
            get
            {
                if (_cached)
                {
                    return _cachedValue;
                }

                _cachedValue = GetOutputValue();
                _cached = true;
                return _cachedValue;
            }
            set
            {
                _cached = true;
                _cachedValue = value;
            }
        }

        public T[] Parameters { get; }

        public void ResetCache()
        {
            _cached = false;
        }

        protected abstract T GetOutputValue();
    }
}
