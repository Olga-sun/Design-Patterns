using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }

        public override void Draw() => _renderer.Render("Triangle");
    }
}