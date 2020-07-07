namespace GeneticNet.Procedures
{
    public interface IProcedure<out TProcedureSettings>
        where TProcedureSettings : IProcedureSettings
    {
        TProcedureSettings Settings { get; }

        void Perform();
    }
}