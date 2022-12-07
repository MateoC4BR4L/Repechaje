namespace Library;

public abstract class BaseHandler : IHandler
{
    public int state;
    public string KeyWord;
    protected IHandler? Next;
    public void setNext(IHandler next)
    {
        this.Next = next;
    }
    public abstract string Handle(string text);
    protected abstract bool CanHandle(string text);

}