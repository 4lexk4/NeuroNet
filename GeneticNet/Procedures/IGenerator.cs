namespace GeneticNet.Procedures
{
    public interface IGenerator<out TProcedureSettings> : IProcedure<TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
    {
    }
}
