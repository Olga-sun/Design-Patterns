namespace StructuralPatternsLab.Task5.Enums
{
    public enum DisplayType
    {
        Block,  // Блочний (div, p, h1)
        Inline  // Рядковий (span, a, img)
    }

    public enum ClosingType
    {
        Paired, // Парний тег (<div></div>)
        Single  // Одинарний тег (<img />)
    }
}