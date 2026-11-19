using System;

namespace Family
{
    class Parent
    {
        public string ParentName { get; set; }

        public Parent(string name,int age)
        {
            Console.WriteLine("this is Parent class constructor");
            Console.WriteLine($"this name is {name}");
            Console.WriteLine($"this age is {age}");
        }

        public void ShowParentMessage()
        {
            Console.WriteLine($"hello, i am Parent {ParentName}");
        }
    }
    class Child : Parent            // child class inheriting the Parent class using : symbol
    {
        public string ChildName { get; set; }


        // very very importent  the :base() - calling the base class constructor
        public Child(string name,int age) : base(name, age)             /// this is the highlite to pass the agrument through child class to paratent class
        {
            Console.WriteLine("this is Child class constructor");
        }

        public void ShowChildMessage()
        {
            var thischild = this;   // also this prepresent this child class
            Console.WriteLine($"hello, i am parent  :{thischild.ParentName} from chid class");
            Console.WriteLine($"hello, i am child : {this.ChildName} from chid class");
            
            //Console.WriteLine($"hello, i am parent {base.ParentName} from chid class"); // base means represent the parent class
            Console.WriteLine($"hello, i am Child {ChildName}");
        }
    }
    class Program
    {
        static void Main()
        {
            Child child = new Child("Brak world",18);              // first the parent class constructor is trigered first when child object creation then 
            //Parent parent = new Child("Brak world",18);              // UPcasting is possible in c#. but i can i only access the members of the parent class
            child.ChildName = "namechild";
            child.ParentName = "nameparent";

            //child.ShowParentMessage();
            //child.ShowChildMessage();

        }
    }
}
