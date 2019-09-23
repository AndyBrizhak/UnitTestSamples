using System;

namespace MoqSamples
{
    public class Doctor
    {
        public int TimesCured;
        public int AbductionsObserved;

        public Doctor(IAnimal animal)
        {
            animal.FallsIll += (sender, args) =>
            {
                Console.WriteLine("I will cure you!");
                TimesCured++;
            };

            animal.AbductedByAliens += (galaxy, returned) => ++AbductionsObserved;
        }
    }
}