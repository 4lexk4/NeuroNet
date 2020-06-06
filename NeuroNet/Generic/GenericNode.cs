namespace NeuroNet.Generic
{
    public abstract class GenericNode<T> : INode<T>
    {
        private T _cachedValue;
        private bool _cached;

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

        public void ResetCache()
        {
            _cached = false;
        }

        protected abstract T GetOutputValue();
    }
}
