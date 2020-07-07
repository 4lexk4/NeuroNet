using GeneticNet.Procedures;

namespace GeneticNet.Internal
{
    internal interface IInternalProcedure<out TProcedureSettings, out TProcedureParameters> : IProcedure<TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
        where TProcedureParameters : IProcedureParameters
    {
        TProcedureParameters Parameters { get; }
    }
}