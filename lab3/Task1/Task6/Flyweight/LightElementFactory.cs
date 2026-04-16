using System.Collections.Generic;
using StructuralPatternsLab.Task5.Enums;

namespace StructuralPatternsLab.Task6.Flyweight
{
    // Спільний стан (Intrinsic State), який буде ділитися між тисячами вузлів
    public class ElementTagState
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }

        public ElementTagState(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }
    }

    // Фабрика, яка гарантує, що стан для тегу "p" створиться лише ОДИН раз
    public class LightElementFactory
    {
        private static Dictionary<string, ElementTagState> _states = new Dictionary<string, ElementTagState>();

        public static ElementTagState GetState(string tagName, DisplayType display, ClosingType closing)
        {
            if (!_states.ContainsKey(tagName))
            {
                _states[tagName] = new ElementTagState(tagName, display, closing);
            }
            return _states[tagName];
        }
    }
}