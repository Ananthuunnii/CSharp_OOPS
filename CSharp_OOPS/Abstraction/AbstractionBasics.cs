using System;

namespace AbstractionBasics
{
    abstract class AbstractionBasicsDemo            // this is a abstract class
    {

        // abstract class constructor

        public AbstractionBasicsDemo()
        {
            Console.WriteLine("insdie the abstract class constructor without parameter");
        }
        public AbstractionBasicsDemo(int myid)
        {
            Console.WriteLine($"insdie the abstract class constructor without parameter ;{myid}");

        }


        // abstract class properties  can't access outside of the class if 
        // if i need to access property ouside the class use public keyword
        
        
        
        // abstract Properties
        public abstract string Myname {  get; set; }
        public abstract int myage { get; set; }


        // non abstract Properties
        public  string Empname {  get; set; }
        public  int Empage { get; set; }



        // if we decalre any method we should decalre with abstract keyword

        // abstract methods
        public abstract void Message();
        public abstract int GetAge();
        public abstract string GetName();
        public abstract int GetPhone(int Phone);


        // in abstract class abstaract mmethods as well as the non abstract methods

        // non abstract methods
        public void GetMessage()
        {
            Console.WriteLine("The message is Hello");
        }

    }
}
