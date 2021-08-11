namespace FileEditorLib
{
    public class TxtDocument : Document
    {
        public TxtDocument(string path) : base(path) { }

        public TxtDocument() : base() { }

        public TxtDocument(string path, string content) : base(path, content) { }
    }
}