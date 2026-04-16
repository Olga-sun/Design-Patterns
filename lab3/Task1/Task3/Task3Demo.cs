using System;
using StructuralPatternsLab.Task3.Interfaces;
using StructuralPatternsLab.Task3.Renderers;
using StructuralPatternsLab.Task3.Shapes;

namespace StructuralPatternsLab.Task3
{
    public class Task3Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Завдання 3: Міст (Графічний редактор) ---\n");

            // 1. Створюємо "пензлики" (рендерери)
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            // 2. Створюємо фігури і передаємо їм потрібний пензлик
            Shape vectorCircle = new Circle(vectorRenderer);
            Shape rasterCircle = new Circle(rasterRenderer);

            Shape vectorSquare = new Square(vectorRenderer);
            Shape rasterTriangle = new Triangle(rasterRenderer);

            // 3. Малюємо
            Console.WriteLine("Векторна графіка:");
            vectorCircle.Draw();
            vectorSquare.Draw();

            Console.WriteLine("\nРастрова графіка:");
            rasterCircle.Draw();
            rasterTriangle.Draw();

            Console.WriteLine("\nНатисніть Enter для продовження...");
            Console.ReadLine();
        }
    }
}