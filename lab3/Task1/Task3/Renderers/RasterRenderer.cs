using System;
using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Renderers
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Drawing {shapeName} as pixels (raster)");
            Console.ResetColor();
        }
    }
}