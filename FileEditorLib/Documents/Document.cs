namespace FileEditorLib
{
    public abstract class Document
    {
        public string Path { get; set; }
        public string Content { get; set; }

        public Document()
        {
            Path = string.Empty;
            Content = string.Empty;
        }

        public Document(string path)
        {
            Path = path;
            Content = string.Empty;
        }

        public Document(string path, string content)
        {
            Path = path;
            Content = content;
        }
    }
}