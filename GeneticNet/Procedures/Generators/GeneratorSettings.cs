namespace GeneticNet.Procedures.Generators
{
    public sealed class GeneratorSettings : IGeneratorSettings
    {
        public GeneratorSettings(int populationSize)
        {
            PopulationSize = populationSize;
        }

        public int PopulationSize { get; }
    }
}