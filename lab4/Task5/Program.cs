using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TextDocument myDocument = new TextDocument();

            TextEditor editor = new TextEditor(myDocument);

            editor.Type("Привіт, світ! ");

            editor.HitSave();

            editor.Type("Це патерн Мементо. ");

            editor.HitSave();

            editor.Type("Ой, випадково натиснув клавіатуру: фівфівфів");

            editor.HitUndo();

            editor.HitUndo();

            Console.ReadLine();
        }
    }
}