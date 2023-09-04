

//  inheritance Kod Örnekleri

/*

                                            // Örnek 1

using System;

// Soyut Sınıf (Abstract Class)
public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Speak();
}

// Interface (Arayüz)
public interface ISwimmer
{
    void Swim();
}

// Alt Sınıf (Derived Class)
public class Dog : Animal, ISwimmer
{
    public Dog(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} havlar.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} yüzer.");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} miyavlar.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Karabas");
        Cat cat = new Cat("Pamuk");

        dog.Speak();   // Çıktı: "Karabas havlar."
        cat.Speak();   // Çıktı: "Pamuk miyavlar."
        dog.Swim();    // Çıktı: "Karabas yüzer."
    }
}

*/





                            // Örnek 2

using System;

// Bir arayüz (interface) tanımlama
interface IStudy
{
    void Study();
}

// Temel (base) sınıf
abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Introduce();
}

// Türetilmiş (derived) sınıf
class Student : Person, IStudy
{
    public string SchoolName { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"Merhaba, benim adım {Name} ve yaşım {Age}.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} isimli öğrenci {SchoolName} okulunda öğrenim görüyor.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Person sınıfından türetilmiş bir nesne oluşturma
        Person person = new Student(); // Değişken adı "person" olarak düzeltilmiştir
        person.Name = "Ali";
        person.Age = 25;
        person.Introduce();

        // Student sınıfından türetilmiş bir nesne oluşturma
        Student student = new Student(); // Değişken adı "student" olarak düzeltilmiştir
        student.Name = "Ayşe";
        student.Age = 20;
        student.SchoolName = "ABC Okulu";
        student.Introduce();
        student.Study();
    }
}





