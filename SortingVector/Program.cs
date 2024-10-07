int[] vector = new int[5] { 3, 2, 1, 5, 4 };

for (int i = 0; i < vector.Length; i++)
{
    Console.Write(vector[i] + " ");
}
Console.WriteLine();

Comparing compare = new Comparing();

Sorting sorting = new Sorting(compare);


int[] sortingVector = sorting.Sort(vector);

for (int i = 0; i < sortingVector.Length; i++)
{
    Console.Write(sortingVector[i] + " ");
}
Console.WriteLine();


Sorting sortingReverse = new Sorting(new ComparingReverse(compare));


sortingVector = sortingReverse.Sort(vector);

for (int i = 0; i < sortingVector.Length; i++)
{
    Console.Write(sortingVector[i] + " ");
}
Console.WriteLine();



class Sorting {

    protected Comparings comparings;

    public Sorting(Comparings comparings)
    {
        this.comparings = comparings;
    }
    public int[] Sort(int[] vector)
    {
        int[] sort_vector = vector.Take(vector.Length).ToArray();
        int temp;
        for (int i = 0; i < sort_vector.Length; i++)
        {
            for (int j = i + 1; j < sort_vector.Length; j++)
            {
                if (comparings.Compare(sort_vector[i], sort_vector[j]))
                {
                    temp = sort_vector[i];
                    sort_vector[i] = sort_vector[j];
                    sort_vector[j] = temp;
                }
            }
        }
        return sort_vector;
    }
}

abstract class Comparings
{
    public abstract bool Compare(int a, int b);
}

class Comparing : Comparings
{
    public override bool Compare(int a, int b)
    {
        return a > b ? true : false;
    }
}

abstract class Decorator : Comparings
{
    protected Comparings comparings;

    public Decorator(Comparings comparings)
    {
        this.comparings = comparings;
    }

    public void SetComparing(Comparings comparings)
    {
        this.comparings = comparings;
    }

    public override bool Compare(int a, int b)
    {
        return this.comparings.Compare(a, b);
    }
}

class ComparingReverse : Decorator
{
    public ComparingReverse(Comparings comparings) : base(comparings) { }

    public override bool Compare(int a, int b)
    {
        return !base.Compare(a, b);
    }
}