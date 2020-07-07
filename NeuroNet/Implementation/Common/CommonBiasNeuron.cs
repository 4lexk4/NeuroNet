using NeuroNet.Generic;
using System;
using System.Linq;

namespace NeuroNet.Implementation.Common
{
    public sealed class CommonBiasNeuron : GenericNeuron<double>
    {
        private readonly int _indexOrderBias;

        public CommonBiasNeuron()
        {
            _indexOrderBias = NumberOfParameters - 1;
        }

        protected override int NumberOfParameters => base.NumberOfParameters + 1;

        protected override double GetOutputValue()
        {
            if (InputAxons.Count == 0)
            {
                return Math.Tanh(0);
            }

            var value = Math.Tanh(InputAxons.Sum(x => x.Output));

            return value > Bias ? value : Math.Tanh(0);
        }

        public double Bias
        {
            get => Parameters[_indexOrderBias];
            set => Parameters[_indexOrderBias] = value;
        }
    }
}