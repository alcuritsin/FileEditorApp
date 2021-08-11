using System;
using FileEditorLib;

namespace TerstConsoleEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;

            IFileWorking file = null;
            Document document = null;
            
            Console.WriteLine("Выберите тип файла для открытия:");
            Console.WriteLine("1. TXT");
            Console.WriteLine("2. MD");
            var select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    path = @"C:\Users\Stari\Desktop\Новый текстовый документ (3).txt";
                    file = new TxtFileWorking();
                    break;
                case "2":
                    path = @"C:\Users\Stari\Desktop\BestOil.md";
                    file = new MdFileWorking();
                    break;
            }

            document = file.Open(path);
            
            Show(document);
        }

        static void Show(Document document)
        {
            var type = document.GetType().FullName;
            switch (type)
            {
                case "FileEditorLib.MdDocument":
                    ShowMd(document);
                    break;
                case "FileEditorLib.TxtDocument":
                    ShowTxt(document);
                    break;
            }
        }

        static void ShowTxt(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
        
        static void ShowMd(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }
}