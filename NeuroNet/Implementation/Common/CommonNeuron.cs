using NeuroNet.Generic;
using System;
using System.Linq;

namespace NeuroNet.Implementation.Common
{
    public sealed class CommonNeuron : GenericNeuron<double>
    {
        protected override double GetOutputValue()
        {
            if (InputAxons.Count == 0)
            {
                return Math.Tanh(0);
            }

            return Math.Tanh(InputAxons.Sum(x => x.Output));
        }
    }
}