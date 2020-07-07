using System;
using System.Collections.Generic;
using GeneticNet.Procedures.Generators;


namespace GeneticNet.Internal.Teachers
{
    internal sealed class SingleThreadTeacher<TIndividual, T> : Teacher<TIndividual, T>
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        private readonly TIndividual _individual;

        public SingleThreadTeacher(TIndividual individual) : base(individual)
        {
            _individual = individual;
        }

        public override TIndividual Teach(IEnumerable<Template<T>> templates, IGenerator<IGeneratorSettings> generator)
        {
            generator.Perform();

            return _individual;
        }
    }
}