using System;

namespace MoqSamples
{
    public interface IAnimal
    {
        event EventHandler FallsIll;
        void Stumble();

        event AlienAbductionEventHandler AbductedByAliens;
    }
}