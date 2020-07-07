using System;
using GeneticNet.Internal.Procedures.Generators;
using GeneticNet.Procedures.Generators;

namespace GeneticNet.Procedures
{
    public static class Procedure
    {
        public static class Generator
        {
            public static IGenerator<IProcedureSettings> Random<TIndividual, T>(GeneratorSettings settings, TIndividual individual)
                where TIndividual : IIndividual<T>
                where T : IComparable<T>
            {
                if (settings == null) throw new ArgumentNullException(nameof(settings));
                if (individual == null) throw new ArgumentNullException(nameof(individual));

                return new RandomGenerator<TIndividual, T>(settings, new GeneratorParameters<TIndividual, T>(individual));
            }
        }
    }
}