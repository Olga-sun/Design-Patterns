using System;

namespace Task5
{
    public class TextDocument
    {
        public string Content { get; set; } = "";

        // Метод створення збереження
        public DocumentMemento Save()
        {
            Console.WriteLine($"Документ: збережено стан: \"{Content}\"");
            return new DocumentMemento(Content);
        }

        // Метод відновлення зі збереження
        public void Restore(DocumentMemento memento)
        {
            Content = memento.SavedContent;
            Console.WriteLine($"Документ: відновлено стан: \"{Content}\"");
        }
    }
}