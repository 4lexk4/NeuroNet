namespace GeneticNet.Procedures.Generators
{
    public interface IGeneratorSettings : IProcedureSettings
    {
        int PopulationSize { get; }
    }
}