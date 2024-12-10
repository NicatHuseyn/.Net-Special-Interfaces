

#region IComparer

Person p1 = new Person() { Name = "Nicat", Age= 22};
Person p2 = new Person() { Name = "Agil", Age= 21 };
Person p3 = new Person() { Name = "Amil", Age= 23 };
Person p4 = new Person() { Name = "Seymur", Age= 22 };
Person p5 = new Person() { Name = "Ramil", Age= 25 };

List<Person> people = new() { p1,p2,p3,p4,p5};
people.ForEach(p=> Console.WriteLine(p.Name));
Console.WriteLine("***************************");
people.Sort(new AgeComparer());
people.ForEach(p => Console.WriteLine(p.Name));

AgeComparer ageComparer = new();
var result = ageComparer.Compare(p1, p2);
Console.WriteLine(result); // Result: 1
class AgeComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x!.Age.CompareTo(y!.Age);
    }
}

#endregion 


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}