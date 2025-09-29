class Personcs
{
    int age;
    public static int retire = 65;
    public Personcs(int age) { 
        this.age = age;
    }
    public void CheckAge()
    {
        if (age >= retire)
        {
            Console.WriteLine("Уже на пенсии");
        }
        else {
            Console.WriteLine($" Сколько лето осталось до пенсии: {retire-age}");
        }
    }
}
