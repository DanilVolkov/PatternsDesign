// Задание: студенты не ходят в комнаты, но слышат, что происходит в комнате

Lector lector_1 = new Lector(1);
Lector lector_2 = new Lector(2);
Lector lector_3 = new Lector(3);

Student student_1 = new Student(1);
Student student_2 = new Student(2);
Student student_3 = new Student(3);
Student student_4 = new Student(4);
Student student_5 = new Student(5);
Student student_6 = new Student(6);

Notebook notebook_1 = new Notebook();
Notebook notebook_2 = new Notebook();
Notebook notebook_3 = new Notebook();
Notebook notebook_4 = new Notebook();

student_1.AddNotebook(notebook_1);
student_2.AddNotebook(notebook_2);
student_3.AddNotebook(notebook_3);
student_4.AddNotebook(notebook_4);
student_5.AddNotebook(notebook_4);

Room baseRoom = new Room();
Room lectureHall_1 = new Room();
Room lectureHall_2 = new Room();
Room gamingRoom = new Room();

baseRoom.Enter(lectureHall_1);
baseRoom.Enter(lectureHall_2);
baseRoom.Enter(gamingRoom);
baseRoom.Enter(lector_1);

lectureHall_1.Enter(lector_2);
lectureHall_1.Enter(student_1);
lectureHall_1.Enter(student_2);

lectureHall_2.Enter(student_3);

gamingRoom.Enter(student_6);

// Студент может быть в комнате base и слышать лектора 1.
// Также лектора 1 могут слышать и другие комнаты.
// Студент слышит, что лектор 1 говорит в его комнату и в другие комнаты.
// Таким образом студент слышит, что говорят в других комнатах.

lector_1.Say(baseRoom, "Добрый день!");
Console.WriteLine();
lector_2.Say(lectureHall_1, "Начнем лекцию");
Console.WriteLine();

OpenRoom loungeRoom = new OpenRoom();
baseRoom.Enter(loungeRoom);
loungeRoom.Enter(student_5);
loungeRoom.Enter(lector_3);
lector_3.Say(loungeRoom, "Отдых");
student_4.Eavesdropping(loungeRoom);
lector_3.Say(loungeRoom, "Расслабон");
student_4.Eavesdropping(loungeRoom);



// реализовать еще наследника room как openroom, и метод у студента как подслушивать, на вход комнату
// подумать, как студент будет слушать информацию комнате (нужно как-то передавать информацию студентам из комнаты)


public interface IListener
{
    void Listen(string sound);
}

public class Room : IListener
{
    private List<IListener> listeners;

    public Room()
    {
        listeners = new List<IListener>();
    }

    public virtual void Echo(string sound)
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

    public void Listen(string sound)
    {
        Echo(sound);
    }
}

public class OpenRoom : Room
{
    private string sound;
    private new List<IListener> listeners;

    public string Sound { get { return sound; } }
    public OpenRoom() : base()
    {
        listeners = new List<IListener>();
    }

    public override void Echo(string sound)
    {
        base.Echo(sound);
        this.sound = sound;
    }
}

public class Lector : IListener
{
    private int number = 0;
    public Lector() { }
    public Lector(int number) => this.number = number;

    public void Listen(string sound)
    {
        if (number != 0)
        {
            Console.WriteLine($"Lector {number} heard: {sound}");
        }
        else
        {
            Console.WriteLine($"Lector heard: {sound}");
        }
        
    }

    public void Say(Room room, string speech)
    {
        if (number != 0)
        {
            Console.WriteLine($"Lector {number} say: {speech}");
        }
        else
        {
            Console.WriteLine($"Lector say: {speech}");
        }
        room.Echo(speech);
    }
}

public class Student : IListener
{
    private string sound = "";
    private Notebook? notebook;
    private int number = 0;

    public Student() { }
    public Student(int number) => this.number = number;

    public void Listen(string sound)
    {
        if (number != 0)
        {
            Console.WriteLine($"Student {number} listen: {sound}");
        }
        else
        {
            Console.WriteLine($"Student listen: {sound}");
        }
        
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

    public void Eavesdropping(OpenRoom room)
    {
        string sound = room.Sound;
        if (number != 0)
        {
            Console.WriteLine($"Student {number} listen in {room}: {sound}");
        }
        else
        {
            Console.WriteLine($"Student listen in {room}: {sound}");
        }
        
    }
}

public class Notebook
{
    private List<string> records = new List<string>();
    public void Write(string sound)
    {
        Console.WriteLine($"Student write \"{sound}\" in notebook");
        records.Add(sound);
    }
}