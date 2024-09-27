Lector lector = new Lector();

Student student_one = new Student();
Student student_two = new Student();

Notebook notebook_one = new Notebook();
Notebook notebook_two = new Notebook();

student_one.AddNotebook(notebook_one);
student_two.AddNotebook(notebook_two);

Room room = new Room();

room.Enter(lector);
room.Enter(student_one);
room.Enter(student_two);

lector.Say(room, "Добрый день!");



public interface IListener
{
    void Listen(string sound);
}

public class Room
{
    List<IListener> listeners = new List<IListener>();
    public void Echo(string sound)
    {
        foreach (IListener listener in listeners)
        {
            listener.Listen(sound);
        }
    }

    public void Enter(IListener listener)
    {
        listeners.Add(listener);
    }
}

public class Lector : IListener
{
    public void Listen(string sound)
    {
        Console.WriteLine($"Lictor heard: {sound}");
    }

    public void Say(Room room, string speech)
    {
        Console.WriteLine($"Lector say: {speech}");
        room.Echo(speech);
    }
}

public class Student : IListener
{
    string sound = "";
    Notebook? notebook;
    public void Listen(string sound)
    {
        this.sound = sound;
        if (notebook is not null)
        {
            this.Write(notebook);
        }
    }

    public void AddNotebook(Notebook notebook)
    {
        this.notebook = notebook;
    }

    protected void Write(Notebook notebook)
    {
        notebook.Write(sound);
    }
}

public class Notebook
{
    List<string> records = new List<string>();
    public void Write(string sound)
    {
        Console.WriteLine($"Student write {sound} in notebook");
        records.Add(sound);
    }
}