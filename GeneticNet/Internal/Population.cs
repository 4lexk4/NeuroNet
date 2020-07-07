using System;
using System.Collections.Generic;

namespace GeneticNet.Internal
{
    internal sealed class Population<TIndividual, T>
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        private readonly List<GeneticIndividual<T>> _individuals = new List<GeneticIndividual<T>>();

        public GeneticIndividual<T> this[int i]
        {
            get => _individuals[i];
            set => _individuals[i] = value;
        }

        public int Length => _individuals.Count;

        public void Add(GeneticIndividual<T> individual)
        {
            _individuals.Add(individual);
        }

        public void AddRange(IEnumerable<GeneticIndividual<T>> individuals)
        {
            _individuals.AddRange(individuals);
        }
    }
}