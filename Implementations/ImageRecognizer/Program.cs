using System.Collections.Generic;
using GeneticNet;
using GeneticNet.Procedures;
using GeneticNet.Procedures.Generators;
using NeuroNet.Implementation.Common;

namespace ImageRecognizer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var perceptron = new Perceptron(16 * 16, 16 * 16, 10);

            var populationSize = 50;
            var generatorSettings = new GeneratorSettings(populationSize);
            var generator =  Procedure.Generator.Random<Perceptron, double>(generatorSettings, perceptron);

            var teacher = Teacher<Perceptron, double>.SingleThreaded(perceptron);
        }
    }
}
