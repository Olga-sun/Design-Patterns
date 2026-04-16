namespace StructuralPatternsLab.Task5.Nodes
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        // Для тексту Outer та Inner - це одне й те саме
        public override string OuterHTML() => _text;
        public override string InnerHTML() => _text;
    }
}