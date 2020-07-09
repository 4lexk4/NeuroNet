using GeneticNet;
using NeuroNet.Generic;

namespace NeuroNet.Implementation.Common
{
    public sealed class Perceptron : GenericSliceNetwork<double>, IIndividual<double>
    {
        public Perceptron(params int[] slicesLength)
        {
            foreach (var sliceLength in slicesLength)
            {
                Slices.Add(new CommonSlice(sliceLength));
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

        public int NumberOfChromosomes => Slices.Count;

        public IIndividual<double> GetClone()
        {
            throw new System.NotImplementedException();
        }

        public double CalculateFitness(Template<double> input)
        {
            throw new System.NotImplementedException();
        }
    }
}