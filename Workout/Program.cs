Text txt = new Text(
    new Word("Тестируем"), new Sign(' '),
    new Word("мою"), new Sign(' '),
    new Word("архитектуру"), new Sign('!'), new Sign('\n'));

txt.Print(new PrinterDefault());

txt.Print(new PrinterSpecial());

PrinterDelegate delegatePrinter = new PrinterDelegate();
delegatePrinter.Assign(txt);
delegatePrinter.Print("Непосредственная печать делегатом:");

interface IPrinter
{
    void Print(Object message);
}

class PrinterDefault : IPrinter
{
    public virtual void Print(Object message)
    {
        Console.Write(message);
    }
}

interface IPrintable
{
    void Print(IPrinter printer);
}

class Word : IPrintable
{
    private string message;
    public Word(string message)
    {
        this.message = message;
    }

    public void Print(IPrinter printer)
    {
        printer.Print(this.message);
    }
}

class Sign : IPrintable
{
    private char symbol;
    public Sign(char symbol)
    {
        this.symbol = symbol;
    }
    public void Print(IPrinter printer)
    {
        printer.Print(this.symbol);
    }
}

class Text : IPrintable
{
    private IPrintable[] printable;

    public Text(params IPrintable[] printable)
    {
        this.printable = printable;
    }
    public void Print(IPrinter printer)
    {
        foreach (var printable in this.printable)
        {
            printable.Print(printer);
        }
    }
}

class PrinterSpecial : PrinterDefault
{
    public override void Print(Object message)
    {
        if (message.GetType() == typeof(string))
        {
            base.Print($"({message})");
        }
        else
        {
            base.Print(message);
        }
    }
}

interface IPrinterDelegate : IPrinter
{
    void Assign(IPrintable printable);
}

class PrinterDelegate : IPrinterDelegate
{
    private IPrintable delegatee;

    // Назначение поручителя
    public void Assign(IPrintable printable)
    {
        delegatee = printable;
    }

    // Реализация метода печати
    public void Print(Object message)
    {
        Console.Write("PrinterDelegate: ");
        delegatee?.Print(new PrinterDefault());
    }
}

