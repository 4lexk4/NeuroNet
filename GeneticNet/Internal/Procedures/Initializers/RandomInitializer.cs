using System;
using GeneticNet.Procedures;
using GeneticNet.Procedures.Generators;

namespace GeneticNet.Internal.Procedures.Initializers
{
    internal sealed class RandomInitializer<TIndividual, T> : IInternalGenerator<GeneratorSettings, InitializerParameters<TIndividual, T>>
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        public RandomInitializer(GeneratorSettings settings, InitializerParameters<TIndividual, T> parameters)
        {
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public GeneratorSettings Settings { get; }

        void IProcedure<GeneratorSettings>.Perform<TProcedureParameters>(IProcedureParameters parameters)
        {
            for (var i = 0; i < Settings.PopulationSize; i++)
            {
                Parameters.Population.Add(new GeneticIndividual<T>(Parameters.Individual.GetClone()));
            }
        }

        public InitializerParameters<TIndividual, T> Parameters { get; }
    }
}