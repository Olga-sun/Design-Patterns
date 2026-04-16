using System.Collections.Generic;
using System.Text;
using StructuralPatternsLab.Task5.Nodes;
using StructuralPatternsLab.Task5.Enums;

namespace StructuralPatternsLab.Task6.Flyweight
{
    public class FlyweightElementNode : LightNode
    {
        // ОДНЕ посилання замість трьох окремих полів
        private ElementTagState _state;

        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public FlyweightElementNode(string tagName, DisplayType display, ClosingType closing, List<string> cssClasses = null)
        {
            // Беремо стан з фабрики
            _state = LightElementFactory.GetState(tagName, display, closing);
            CssClasses = cssClasses ?? new List<string>();
            Children = new List<LightNode>();
        }

        public void Add(LightNode node) => Children.Add(node);

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children) sb.Append(child.OuterHTML());
            return sb.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{_state.TagName}"); // Використовуємо дані зі стану

            if (CssClasses.Count > 0) sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");

            if (_state.Closing == ClosingType.Single)
            {
                sb.Append(" />");
                return sb.ToString();
            }

            sb.Append(">");
            sb.Append(InnerHTML());
            sb.Append($"</{_state.TagName}>");

            if (_state.Display == DisplayType.Block) sb.AppendLine();

            return sb.ToString();
        }
    }
}