using System;

namespace StaticandNonStaticinstantiate1
{
    public static class EmployStaticLoger
    {
        public static int EmployeeList = 0;

        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeeList++;
        }
        /// <summary>
        /// here we are going to get  the total number  of messages
        /// </summary>
        /// <returns>int</returns>
        public static int Getmessagecount()
        {
            return EmployeeList;
        }

    }
    public class EmployNonStaticLoger
    {
        public int EmployeeList = 0;
        public void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
            EmployeeList++;
        }
        /// <summary>
        /// here we are going to get  the total number  of messages
        /// </summary>
        /// <returns>int</returns>
        public int Getmessagecount()
        {
            return EmployeeList;
        }


    }



    class Program
    {
        static void Main()
        {
            // static class members calling this way
            //EmployStaticLoger.LogMessage("dany has joined on January 02 2025");
            //EmployStaticLoger.LogMessage("faizy has joined on October 10 2025");

            //int empciunt = EmployStaticLoger.Getmessagecount();
            //Console.WriteLine($"Total static count of messages: {empciunt}");


            // Non static class members calling this way
            // instance 1
            EmployNonStaticLoger ensclass1 = new EmployNonStaticLoger();
            ensclass1.LogMessage("dany has joined on January 02 2025");
            ensclass1.LogMessage("faizy has joined on October 10 2025");
            int empmsgcount1 = ensclass1.Getmessagecount();
            Console.WriteLine($" total nonstatic count of messages : {empmsgcount1}");

            //instance 2
            EmployNonStaticLoger ensclass2 = new EmployNonStaticLoger();
            ensclass2.LogMessage("dany has joined on January 02 2025");
            int empmsgcount2 = ensclass2.Getmessagecount();

            Console.WriteLine($" total nonstatic count of messages : {empmsgcount2}");

        }
    }
}
