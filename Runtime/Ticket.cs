using System;

public class Ticket : ITicket
{
    protected Action<Ticket> onDispose;
    public bool isDisposed { get; set; }

    protected Ticket(Action<Ticket> onDispose)
    {
        this.onDispose = onDispose;
    }

    public void ManualDispose()
    {
        Dispose();
    }

    public void Dispose()
    {
        isDisposed = true;

        onDispose?.Invoke(this);
        onDispose = null;
    }
}