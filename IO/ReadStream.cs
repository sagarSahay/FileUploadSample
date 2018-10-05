namespace FileUploadSample.IO
{
    using System;
    using System.IO;

    public class ReadStream : IReadStream
    {
        private string fileName;
        private Lazy<StreamReader> readStreamLazy;

        public ReadStream(string fileName)
        {
            this.fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            readStreamLazy = new Lazy<StreamReader>(()=> new StreamReader(fileName));
        }

        public void Dispose()
        {
            readStreamLazy?.Value?.Dispose();
        }

        public string ReadLine()
        {
            return readStreamLazy.Value.ReadLine();
        }
    }
}