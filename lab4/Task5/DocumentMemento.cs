namespace Task5
{
    public class DocumentMemento
    {
        // Текст можна лише отримати (get), змінити його ззовні неможливо (private set)
        public string SavedContent { get; private set; }

        public DocumentMemento(string content)
        {
            SavedContent = content;
        }
    }
}
