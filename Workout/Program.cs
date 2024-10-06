Text txt = new Text(
    new Word("Тестируем"), new Sign(' '),
    new Word("мою"), new Sign(' '),
    new Word("архитектуру"), new Sign('!'), new Sign('\n'));

txt.Print(new PrinterDefault());
txt.Print(new PrinterSpecial());

PrinterDelegate printer = new PrinterDelegate();
printer.Print(txt);
txt.Print(printer);



interface IPrinter
{
    void Print(string str);
    void Print(char chr);
}

interface IPrintable
{
    void Print(IPrinter printer);
}

interface IPrinterDelegate : IPrinter
{
    void Print(IPrintable printer);
}

class PrinterDelegate : PrinterDefault, IPrinterDelegate
{
    public void Print(IPrintable printer)
    {
        printer.Print(this);
    }
}

class PrinterDefault : IPrinter
{
    public virtual void Print(string str)
    {
        Console.Write(str);
    }

    public void Print(char chr)
    {
        Console.Write(chr);
    }
}

class PrinterSpecial : PrinterDefault
{
    public override void Print(string str)
    {
        base.Print($"({str})");
    }
}

class Word : IPrintable
{
    private string word;

    public Word(string word)
    {
        this.word = word;
    }
    public void Print(IPrinter printer)
    {
        printer.Print(word);
    }
}

class Sign : IPrintable
{
    private char sign;

    public Sign(char sign)
    {
        this.sign = sign;
    }
    public void Print(IPrinter printer)
    {
        printer.Print(sign);
    }
}

class Text : IPrintable
{
    private IPrintable[] printables;

    public Text(params IPrintable[] printables)
    {
        this.printables = printables;
    }

    public void Print(IPrinter printer)
    {
        foreach (IPrintable printable in printables)
        {
            printable.Print(printer);
        }
    }
}