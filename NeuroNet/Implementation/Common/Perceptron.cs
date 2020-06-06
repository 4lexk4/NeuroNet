using NeuroNet.Generic;

namespace NeuroNet.Implementation.Common
{
    internal sealed class Perceptron : GenericSliceNetwork<double>
    {
        public Perceptron(params int[] slicesLength)
        {
            for (var i = 0; i < slicesLength.Length; i++)
            {
                Slices[i] = new CommonSlice(slicesLength[i]);
            }
            for (var i = 0; i < Slices.Count - 1; i++)
            {
                Slices[i].ConnectWith<CommonAxon>(Slices[i + 1]);
            }
        }

        public override void Calculate(double[] inputValues, double[] outputValues)
        {
            for (var i = 0; i < InputSlice.Neurons.Count; i++)
            {
                InputSlice.Neurons[i].Output = inputValues[i];
            }

            for (var i = 0; i < OutputSlice.Neurons.Count; i++)
            {
                outputValues[i] = OutputSlice.Neurons[i].Output;
            }
        }
    }
}