using System;
using System.Collections.Generic;
using GeneticNet.Internal.Teachers;
using GeneticNet.Procedures.Generators;

namespace GeneticNet
{
    public abstract class Teacher<TIndividual, T>
        where TIndividual : IIndividual<T>
        where T : IComparable<T>
    {
        protected TIndividual Individual { get; }

        protected Teacher(TIndividual individual)
        {
            Individual = individual ?? throw new ArgumentNullException(nameof(individual));
        }

        public static Teacher<TIndividual, T> SingleThreaded(TIndividual individual) 
        {
            return new SingleThreadTeacher<TIndividual, T>(individual);
        }

        public abstract TIndividual Teach(
            IEnumerable<Template<T>> templates,
            IGenerator<IGeneratorSettings> generator);
    }
}