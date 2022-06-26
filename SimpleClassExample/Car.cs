﻿namespace SimpleClassExample
{
    internal class Car
    {
        public string petName;
        public int currSpeed;
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string pn) => petName = pn;

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed}.");
        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
