namespace FileUploadSample.IO
{
    using System;

    public interface IWriteStream : IDisposable
    {
        void WriteLine(byte[] input);
    }
}