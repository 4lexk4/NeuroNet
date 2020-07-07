namespace GeneticNet.Procedures.Generators
{
    public interface IGenerator<out TProcedureSettings> : IProcedure<TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
    {
    }
}
