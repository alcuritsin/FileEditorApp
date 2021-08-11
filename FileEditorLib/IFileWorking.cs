namespace FileEditorLib
{
    public interface IFileWorking
    {
        public Document Create(string path);
        public Document Open(string path);
        public void SaveAs(Document document, string path);
        public void Save(Document document);
        public void Print(Document document);
        public void Close(Document document);
    }
}