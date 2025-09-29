class Student
{
    public string name;
    public int age;
    public string group;
    public Student() {
        Console.WriteLine("Создание студента");
        name = "None";
        age = 18;
        group = "None";
    }
    public Student(string name)
    {
        this.name = name;
        age = 18;
        group = "None";
    }
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        group = "None";
    }
    public Student(string name,int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Имя - {name}, возраст - {age}, группа - {group}");
    }
    public bool IsAdult()
    {
        return age >= 18;
    }
}