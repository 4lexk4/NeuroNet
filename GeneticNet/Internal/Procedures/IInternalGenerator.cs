using GeneticNet.Procedures;

namespace GeneticNet.Internal.Procedures
{
    internal interface IInternalGenerator<out TProcedureSettings, out TProcedureParameters> : IGenerator<TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
        where TProcedureParameters : IProcedureParameters
    {
        TProcedureParameters Parameters { get; }
    }
}