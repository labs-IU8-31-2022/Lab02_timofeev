Pupil p1 = new ExcelentPupil("Tom");
GoodPupil p2 = new("Bob");
ExcelentPupil p3 = new("Ann");
BadPupil p4 = new("Vova");
ClassRoom classroom1 = new(p1, p2);
ClassRoom classroom2 = new(p1, p2, p3, p4);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("In first class:");
classroom1.Print();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\nIn second class:");
classroom2.Print();
Console.ForegroundColor = ConsoleColor.White;
Console.Read();

class ClassRoom
{
    private Pupil[]? _pupils;
    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length > 4)
        {
            Console.WriteLine("Too much");
            _pupils = null;
            return;
        }
        _pupils = pupils;
    }

    public void Print()
    {
        Console.WriteLine("Pupils can:");
        if (_pupils is null) return;
        foreach (var i in _pupils)
        {
            Console.WriteLine(i.Name);
            i.Study();
            i.Read();
            i.Write();
            i.Relax();
        }
    }
}

class Pupil
{
    private string _name;
    public string Name => _name;
    public Pupil(string name)
    {
        _name = name;
    }
    
    public virtual void Study()
    {
        Console.Write("Studying");
    }

    public virtual void Read()
    {
        Console.Write("Reading");
    }

    public virtual void Write()
    {
        Console.Write("Writing");
    }

    public virtual void Relax()
    {
        Console.Write("Relaxing");
    }
}

class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) : base(name) {}
    public override void Study()
    {
        base.Study();
        Console.WriteLine(" a lot");
    }

    public override void Read()
    {
        base.Read();
        Console.WriteLine(" a lot of books");
    }

    public override void Write()
    {
        base.Write();
        Console.WriteLine(" many tasks");
    }

    public override void Relax()
    {
        base.Relax();
        Console.WriteLine(" no time");
    }
}

class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name) {}
    public override void Study()
    {
        base.Study();
        Console.WriteLine(" not all day, but doing a lot");
    }

    public override void Read()
    {
        base.Read();
        Console.WriteLine(" only necessary books");
    }

    public override void Write()
    {
        base.Write();
        Console.WriteLine(" only necessary tasks");
    }

    public override void Relax()
    {
        base.Relax();
        Console.WriteLine(" only on holidays");
    }
}

class BadPupil : Pupil
{
    public BadPupil(string name) : base(name) {}
    public override void Study()
    {
        base.Study();
        Console.WriteLine(" not at all");
    }

    public override void Read()
    {
        base.Read();
        Console.WriteLine(" is only for dumbs");
    }

    public override void Write()
    {
        base.Write();
        Console.WriteLine(" is very hard for him");
    }

    public override void Relax()
    {
        base.Relax();
        Console.WriteLine(" all day walking outside");
    }
}