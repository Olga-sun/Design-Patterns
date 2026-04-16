using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Shapes
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw() => _renderer.Render("Square");
    }
}