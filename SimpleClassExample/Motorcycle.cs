namespace SimpleClassExample
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle() 
        {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        public Motorcycle(int intensity) : this(intensity, "")
        { Console.WriteLine("In ctor taking a int"); }
        public Motorcycle(string name) : this(0, name) 
        {Console.WriteLine("In ctor taking a string"); }



        //public Motorcycle()
        //{

        //}
        //public Motorcycle(int intensity, string name)
        //{
        //    SetIntencity(intensity);
        //    driverName = name;
        //}

        //public Motorcycle(int intensity) => driverIntensity = intensity;

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            { Console.WriteLine("Yeeeeeee Haaaaaaaaaeeewwww!"); }

        }
        public void SetDriverName(string name) => driverName = name;
        public void SetIntencity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }
    }

}
