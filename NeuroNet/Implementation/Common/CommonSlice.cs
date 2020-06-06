using NeuroNet.Generic;

namespace NeuroNet.Implementation.Common
{
    internal sealed class CommonSlice : GenericSlice<double>
    {
        public CommonSlice(int numberOfNeurons)
        {
            for (var i = 0; i < numberOfNeurons; i++)
            {
                Neurons.Add(new CommonNeuron());
            }
        }
    }
}