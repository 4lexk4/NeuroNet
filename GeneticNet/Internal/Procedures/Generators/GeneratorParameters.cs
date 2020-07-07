using System;

namespace GeneticNet.Internal.Procedures.Generators
{
    internal class GeneratorParameters<TIndividual, T> : IProcedureParameters
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        public GeneratorParameters(TIndividual individual)
        {
            Individual = individual;
            Population = new Population<TIndividual, T>();
        }

        public TIndividual Individual { get; }

        public Population<TIndividual, T> Population { get; }
    }
}