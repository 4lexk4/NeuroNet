using NeuroNet.Generic;
using System;
using System.Linq;

namespace NeuroNet.Implementation.Common
{
    internal sealed class CommonNeuron : GenericNeuron<double>
    {
        protected override double GetOutputValue()
        {
            if (InputAxons.Count == 0)
            {
                return 0;
            }

            var value = Math.Tanh(InputAxons.Sum(x => x.Output));

            return value > Bias ? value : 0;
        }
    }
}