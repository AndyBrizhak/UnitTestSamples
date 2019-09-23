namespace MoqSamples
{
    public partial class NonMethodSamples
    {
        private abstract class Person
        {
            protected int SSN { get; set; }
            protected abstract void Execute(string cmd);
        }
    }
}