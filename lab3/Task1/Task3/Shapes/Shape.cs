using StructuralPatternsLab.Task3.Interfaces;

namespace StructuralPatternsLab.Task3.Shapes
{
    public abstract class Shape
    {
        // Це і є наш "Міст"
        protected IRenderer _renderer;

        // Через конструктор ми передаємо, ЯК САМЕ буде малюватися ця фігура
        protected Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}