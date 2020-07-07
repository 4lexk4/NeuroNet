using NeuroNet.Generic;

namespace NeuroNet.Implementation.Common
{
    public sealed class CommonAxon : GenericAxon<double>
    {
        protected override double GetOutputValue()
        {
            return Capacity * InputNeuron.Output;
        }
    }
}