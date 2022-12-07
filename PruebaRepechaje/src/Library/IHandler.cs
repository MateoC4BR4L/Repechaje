namespace Library;
public interface IHandler
{
    public void setNext(IHandler next);
    public string Handle(string text);
}
