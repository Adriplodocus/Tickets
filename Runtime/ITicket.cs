using System;

public interface ITicket : IDisposable
{
    public bool isDisposed { get; set; }
}