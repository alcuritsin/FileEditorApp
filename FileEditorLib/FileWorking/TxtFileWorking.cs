using System.IO;

namespace FileEditorLib
{
    public class TxtFileWorking : IFileWorking
    {
        public Document Create(string path)
        {
            return new TxtDocument(path);
        }

        public Document Open(string path)
        {
            using var file = new StreamReader(path);
            var content = file.ReadToEnd();
            return new TxtDocument(path, content);
        }

        public void SaveAs(Document document, string path)
        {
            using var file = new StreamWriter(path, append:false);
            file.Write(document.Content);
        }

        public void Save(Document document)
        {
            SaveAs(document, document.Path);
        }

        public void Print(Document document)
        {
            //TODO
        }

        public void Close(Document document)
        {
            //TODO
        }
    }
}