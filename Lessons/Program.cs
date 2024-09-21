
Lector lector = new Lector();

Student student = new Student();

Room room = new Room();

room.Enter(lector);
room.Enter(student);

lector.Say(room, "Добрый день!");


public interface IListener
{
    void Listen(string sound);
}

public class Room
{
    public void Echo(string sound)
    {

    }

    public void Enter(IListener listener) { }
}

public class Lector : IListener
{
    public IListener Listener
    {
        
    }

    public void Listen(string sound)
    {
        //Console.WriteLine(sound);
    }

    public void Say(Room room, string speech)
    {
        room.Echo(speech);
    }
}

public class Student : IListener
{
    public Lector Lector
    {
        
    }

    public void Listen(string sound)
    {
        // нужен объект студента
    }

    protected void Write(Notebook notebook)
    {
        notebook.Write();
    }
}

public class Notebook
{
    public void Write()
    {
        Console.WriteLine("Write in notebook");
    }
}