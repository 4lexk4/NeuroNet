using System;

namespace GeneticNet.Internal
{
    internal sealed class GeneticIndividual<T> 
        where T : IComparable<T>
    {
        public GeneticIndividual(IIndividual<T> individual)
        {
            Individual = individual ?? throw new ArgumentNullException(nameof(individual));
            Chromosomes = new Chromosome<T>[individual.NumberOfChromosomes];
        }

        public IIndividual<T> Individual { get; }

        public Chromosome<T>[] Chromosomes { get; }

        public double Fitness { get; }
    }
}