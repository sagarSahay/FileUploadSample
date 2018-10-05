namespace FileUploadSample.IO
{
    using System;
    using System.IO;

    public class WriteStream : IWriteStream
    {
        private string fileName;
        private Lazy<StreamWriter> writeStreamLazy;

        public WriteStream(string fileName)
        {
            this.fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            this.writeStreamLazy = new Lazy<StreamWriter>(() =>
            {
                var fileInfo = new FileInfo(this.fileName);
                return fileInfo.CreateText();
            });
        }
        public void WriteLine(byte[] line)
        {
            writeStreamLazy.Value.WriteLine(line);
        }

        public void Dispose()
        {
            writeStreamLazy?.Value?.Dispose();
        }
    }
}