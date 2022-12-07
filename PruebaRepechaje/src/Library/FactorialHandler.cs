namespace Library;

public class FactorialHandler : BaseHandler
{
    int result = 1;
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
                if(Next != null)
                return this.Next.Handle(text);

                return "No se ha podido manejar el dato ingresado.";
            }
        }
        else
        {
            try
            {
                this.state = 1;
                result = Int32.Parse(text);
                int num = Int32.Parse(text);
                for(int i = num; i == 1; i -= 1)
                {
                    result = result * i;
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