using SimpleClassExample;

Console.WriteLine("***** Fun with Class types *****\n");
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;
myCar.PrintState();
//for (int i = 10; i >= 0; i--)
//{
//    myCar.SpeedUp(5);
//    myCar.PrintState();
//}

Car chuck = new Car();
chuck.PrintState();

Car mary = new Car("Marry");
mary.PrintState();

Car daisy = new Car("Daisy", 75);
daisy.PrintState();

Motorcycle c = new Motorcycle(0, "mania");
//c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine($"Rider name is {c.driverName}\n");

MakeSomeBikes();


Console.ReadLine();

static void MakeSomeBikes()
{
    Motorcycle m1 = new Motorcycle();
    Console.WriteLine($"Name={m1.driverName}, Intensity={m1.driverIntensity}");

    Motorcycle m2 = new Motorcycle(name: "Tiny");
    Console.WriteLine($"Name={m2.driverName}, Intensity={m2.driverIntensity}");

    Motorcycle m3 = new Motorcycle(7);
    Console.WriteLine($"Name={m3.driverName}, Intensity={m3.driverIntensity}");
}