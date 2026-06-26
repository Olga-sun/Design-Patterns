using System;
using System.Collections.Generic;

namespace Task5
{
    public class TextEditor
    {
       
        private TextDocument _document;
        private Stack<DocumentMemento> _history;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _history = new Stack<DocumentMemento>();
        }
        public void Type(string text)
        {
            _document.Content += text;
            Console.WriteLine($"Редактор: додано текст. Поточний текст: \"{_document.Content}\"");
        }

        public void HitSave()
        {
            Console.WriteLine("\nРедактор: зберігаємо поточний стан...");
          
            _history.Push(_document.Save());
        }

        public void HitUndo()
        {
            Console.WriteLine("\nРедактор: спроба скасувати останню дію (Ctrl+Z)...");

            if (_history.Count > 0)
            {
                DocumentMemento memento = _history.Pop();
                _document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Редактор: Історія порожня, немає чого скасовувати!");
            }
        }
    }
}