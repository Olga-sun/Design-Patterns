using System;
using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Renderers
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Drawing {shapeName} as lines (vector)");
            Console.ResetColor();
        }
    }
}