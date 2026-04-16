using System.Collections.Generic;
using System.Text;
using StructuralPatternsLab.Task5.Enums;

namespace StructuralPatternsLab.Task5.Nodes
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public ClosingType Closing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing, List<string> cssClasses = null)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = cssClasses ?? new List<string>(); // Якщо класи не передали, створюємо пустий список
            Children = new List<LightNode>();
        }

        // Метод для додавання дочірніх елементів
        public void Add(LightNode node)
        {
            Children.Add(node);
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            // InnerHTML просто збирає OuterHTML всіх своїх "дітей"
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML());
            }
            return sb.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"<{TagName}");

            if (CssClasses.Count > 0)
            {
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
            }

            // Якщо тег одинарний (наприклад, img)
            if (Closing == ClosingType.Single)
            {
                sb.Append(" />");
                return sb.ToString();
            }

            // Якщо тег парний
            sb.Append(">");
            sb.Append(InnerHTML());
            sb.Append($"</{TagName}>");

            // Додаємо перенесення рядка для блочних елементів, щоб виглядало красиво в консолі
            if (Display == DisplayType.Block)
            {
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}