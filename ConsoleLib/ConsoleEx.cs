using System;
using FileEditorLib;

namespace ConsoleLib
{
    public static class ConsoleEx
    {
        public static void Show(Document document)
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

        private static void ShowTxt(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }

        private static void ShowMd(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }
}