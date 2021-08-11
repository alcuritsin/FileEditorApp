using System.IO;

namespace FileEditorLib
{
    public class MdFileWorking : IFileWorking
    {
        public Document Create(string path)
        {
            return new MdDocument();
        }

        public Document Open(string path)
        {
            using var file = new StreamReader(path);
            var content = file.ReadToEnd();
            return new MdDocument(path, content);
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