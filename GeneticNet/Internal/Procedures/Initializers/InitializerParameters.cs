using System;

namespace GeneticNet.Internal.Procedures.Initializers
{
    internal class InitializerParameters<TIndividual, T> : IProcedureParameters
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        public InitializerParameters(TIndividual individual)
        {
            Individual = individual;
            Population = new Population<TIndividual, T>();
        }

        public TIndividual Individual { get; }

        public Population<TIndividual, T> Population { get; }
    }
}