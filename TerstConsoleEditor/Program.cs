using System;
using FileEditorLib;

namespace TerstConsoleEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Stari\Desktop\Новый текстовый документ (3).txt";

            var file = new TxtFileWorking();
            var document = file.Open(path);
            
            ShowTxt(document);
        }

        static void ShowTxt(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }
}