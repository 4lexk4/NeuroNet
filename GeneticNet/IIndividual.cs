using System;

namespace GeneticNet
{
    public interface IIndividual<T> where T : IComparable<T>
    {
        int NumberOfChromosomes { get; }

        IIndividual<T> GetClone();
    }
}