using GeneticNet.Internal;

namespace GeneticNet.Procedures
{
    public interface IProcedure<out TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
    {
        TProcedureSettings Settings { get; }

        internal void Perform<TProcedureParameters>(IProcedureParameters parameters) where TProcedureParameters : IProcedureParameters;
    }
}