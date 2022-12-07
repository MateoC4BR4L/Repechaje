namespace Library;

public class FactorialHandler : BaseHandler
{

    public FactorialHandler()
    {
        this.KeyWord = "FACTORIAL";
        this.state = 1;
    }
    protected override bool CanHandle(string text)
    {
        if(text.ToUpper() == this.KeyWord)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string Handle(string text)
    {
        if(this.state == 1)
        {        
            if(this.CanHandle(text))
            {
                this.state = 2;
                return "Ha elegido factorial, Ingrese un número: ";
            }
            else
            {
                this.Next.Handle(text);
                return "";
            }
        }
        else
        {
            try
            {
                this.state = 1;
                int result = Int32.Parse(text);
                for(int i = Int32.Parse(text) - 1; i == 1; i--)
                {
                    result *= i;
                }
            

                return $"{text}! = {result}";
            }
            catch(System.Exception a)
            {
                throw a;
            }
        }
    }
}