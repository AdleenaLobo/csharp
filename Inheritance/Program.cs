// See https://aka.ms/new-console-template for more information

class A {
    public virtual void display() {
        Console.WriteLine("in A");

    }
}
class B:A{
    public new virtual void display() { 
        Console.WriteLine("in B");
    }
}

class C:B{ 
    public override void display()
    {
        Console.WriteLine("in C");
    }
}
class D : C {
    public override void display() { 
        Console.WriteLine("in D");
    }
}

internal class MyProgram {
    static void Main() {
        A a = new D();
        a.display();
    }
}