
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;

#region IComparer

//Person p1 = new Person() { Name = "Nicat", Age= 22};
//Person p2 = new Person() { Name = "Agil", Age= 21 };
//Person p3 = new Person() { Name = "Amil", Age= 23 };
//Person p4 = new Person() { Name = "Seymur", Age= 22 };
//Person p5 = new Person() { Name = "Ramil", Age= 25 };

//List<Person> people = new() { p1,p2,p3,p4,p5};
//people.ForEach(p=> Console.WriteLine(p.Name));

//Console.WriteLine("***************************");

//people.Sort(new AgeComparer());
//people.ForEach(p => Console.WriteLine(p.Name));

//AgeComparer ageComparer = new();
//var result = ageComparer.Compare(p1, p2);
//Console.WriteLine(result); // Result: 1
//class AgeComparer : IComparer<Person>
//{
//    public int Compare(Person? x, Person? y)
//    {
//        return x!.Age.CompareTo(y!.Age);
//    }
//}

#endregion


#region IComparable

//Person p1 = new Person();
//Person p2 = new Person();

//p1.CompareTo(p2);
//class Person : IComparable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public int CompareTo(Person? other)
//    {
//        return Age.CompareTo(other!.Age);
//    }
//}

#endregion


#region ICloneable

//Person person = new() { Name = "Nicat", Age = 22 };
//var clone = person.Clone();
//Person person2 = (Person)clone;

//Console.WriteLine(person.Name); // Micat
//Console.WriteLine(person2.Name); // Nicat

//class Person : ICloneable
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public object Clone()
//    {
//        return this.MemberwiseClone();
//    }
//}

#endregion


#region INotifyProperyChanged

//Person person = new() { Name = "Nicat", Age = 22 };
//person.PropertyChanged += (sender, e) =>
//{
//    Console.WriteLine($"{e.PropertyName} property's name value chnaged to {{{(sender as Person)?.Age}}}");
//};

//person.Age = 22;
//person.Age = 23;
//person.Age = 24;

//class Person : INotifyPropertyChanged
//{
//    public string Name { get; set; }
//    int _age;

//    public int Age
//    {
//        get
//        {
//            return _age;
//        }
//        set
//        {
//            if (_age != value)
//            {
//                _age = value;
//                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Age)));
//            }
//        }
//    }

//    public event PropertyChangedEventHandler? PropertyChanged;
//}


#endregion


#region IEquatable

//Person person = new Person() { Name = "Nicat", Age= 22};
//Person person2 = new Person() { Name = "Salim", Age= 28};

//var result = person.Equals(person2);
//Console.WriteLine(result);


//class Person : IEquatable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public bool Equals(Person? other)
//    {
//        if (other is null)
//        {
//            return false;
//        }

//        return Age == other.Age & Name == other.Name;
//    }
//}

#endregion


#region IEnumerable

//Depo depo = new Depo();

//foreach (var item in depo)
//{
//    Console.WriteLine(item);
//}

//class Depo : IEnumerable
//{

//    List<string> products = new() { "compuet", "phone", "TV", "notebook" };

//    public IEnumerator GetEnumerator()
//    {
//        return products.GetEnumerator();
//    }
//}

#endregion


#region IDisposeble

public class MyDatabase:IDisposable
{
    SqlConnection connection;
    SqlCommand command;

    public MyDatabase(SqlConnection connection, SqlCommand command)
    {
        this.connection = connection;
        this.command = command;
    }

    public void Dispose()
    {
        connection = null;
        command = null;
    }

    ~MyDatabase()
    {
        Dispose();
    }
}

#endregion