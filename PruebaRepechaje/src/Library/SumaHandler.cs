namespace Library;

public class SumaHandler : BaseHandler
{
    int suma = 0;
    string numeros = "";
    public SumaHandler()
    {
        this.KeyWord = "SUMA";
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
                suma = 0;
                numeros = "";
                return "Ha elegido Sumar, ingrese un número: ";
            }
            else
            {
                return "No se ha podido procesar su solicitud";
            }
        }
        else
        {
            if(text.ToUpper() == "NADA")
            {
                this.state = 1;
                numeros = numeros + " = " + suma;
                return numeros;
            }
            try
            {
            this.suma += Int32.Parse(text);
            numeros += " + " + text;
            return "Ingrese un número (digite 'Nada' para finalizar)";
            }
            catch(System.Exception a)
            {
                throw a;
            }
        }
    }
}