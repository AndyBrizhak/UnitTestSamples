namespace MoqSamples
{
    public partial class NonMethodSamples
    {
        public class Consumer
        {
            private IFoo foo;

            public Consumer(IFoo foo)
            {
                this.foo = foo;
            }

            public void Hello()
            {
                foo.DoSomething("ping");
                var name = foo.Name;
                foo.SomeOtherProperty = 123;
            }
        }
    }
}