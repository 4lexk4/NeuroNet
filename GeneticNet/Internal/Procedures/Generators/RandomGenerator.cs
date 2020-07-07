using System;
using GeneticNet.Procedures.Generators;

namespace GeneticNet.Internal.Procedures.Generators
{
    internal sealed class RandomGenerator<TIndividual, T> : IInternalGenerator<GeneratorSettings, GeneratorParameters<TIndividual, T>>
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        public RandomGenerator(GeneratorSettings settings, GeneratorParameters<TIndividual, T> parameters)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public GeneratorSettings Settings { get; }

        public GeneratorParameters<TIndividual, T> Parameters { get; }

        public void Perform()
        {
            for (var i = 0; i < Settings.PopulationSize; i++)
            {
                Parameters.Population.Add(new GeneticIndividual<T>(Parameters.Individual.GetClone()));
            }
        }
    }
}