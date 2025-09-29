namespace Class7_Zlamanyuk_ISP_231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //Student student1 = new Student("Mika");
            //Student student2 = new Student("Mika",24);
            //Student student3 = new Student("Mika",24, "ISP-231");
            //Console.WriteLine(student);
            //student.name = "Mika";
            //student.age = 17;
            //student.group = "ISP-231";
            //student.PrintInfo();
            //student1.name = "Veronika";
            //student1.age = 18;
            //student1.group = "ISP-231";
            //student1.PrintInfo();
            //Console.WriteLine($"{student.name} совершеннолетний - {student.IsAdult()}");
            //Car car = new Car();
            //car.model = "Skoda";
            //car.Accelerate(80);
            //Player player = new Player();
            //Console.WriteLine(player.GetHealth());
            //player.TakeDamage(40);
            //TV tV = new TV();
            //tV.SetVolume(78);
            //tV.SetVolume(145);
            //Person.Print();
            //Console.WriteLine();
            BankAccount account = new BankAccount();
            account.Deposit(50);
            account.Withdraw(23);
            Personcs bob = new(68);
            bob.CheckAge();
            Personcs tom = new(37);
            tom.CheckAge();
            Console.WriteLine(Personcs.retire);
            Personcs.retire = 67;
        }
    }
    //class Person { 
    //    static public void Print()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}
}

