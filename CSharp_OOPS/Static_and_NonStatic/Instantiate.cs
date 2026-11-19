using System;

namespace StaticandNonStaticinstantiate
{
    public static class StaticClass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("this is a static class method");
        }
    }
    public class NonStaticClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("this is a non static class method");

        }
    }

    class Program
    {
        static void Main()
        {
            StaticClass.PrintMessage();                         // calling static method
            NonStaticClass nsclass = new NonStaticClass();      // calling nonstatic method first create instance
            nsclass.PrintMessage();                             // then calling the method

        }
    }
}
