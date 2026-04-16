using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Shapes
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw() => _renderer.Render("Circle");
    }
}