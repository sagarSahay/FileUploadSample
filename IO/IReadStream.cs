namespace FileUploadSample.IO
{
    using System;

    public interface IReadStream : IDisposable
    {
        string ReadLine();
    }
}