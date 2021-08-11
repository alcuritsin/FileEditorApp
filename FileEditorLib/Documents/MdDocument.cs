namespace FileEditorLib
{
    public class MdDocument : Document
    {
        public MdDocument() { }

        public MdDocument(string path) : base(path) { }

        public MdDocument(string path, string content) : base(path, content) { }
    }
}