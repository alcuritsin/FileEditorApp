using FileEditorLib;

using static System.Console;
using static ConsoleLib.ConsoleEx;

namespace TerstConsoleEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;

            IFileWorking file = null;
            Document document = null;
            
            WriteLine("Выберите тип файла для открытия:");
            WriteLine("1. TXT");
            WriteLine("2. MD");
            var select = ReadLine();
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
    }
}