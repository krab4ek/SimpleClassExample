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

Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine($"Rider name is {c.driverName}");

Console.ReadLine();
