using System;


class Const_Readonly        // class
{
    const double pi = 3.14;         // the constant
    readonly string createddate = "01/11/2026";
    public Const_Readonly(string ddate)
    {
        createddate = ddate;
    }
    static void Main()
    {
        Console.WriteLine($"the pi value is {Const_Readonly.pi}");

        Const_Readonly filecalling = new Const_Readonly("20/11/2026");
        //filecalling.createddate = "24/11/2026";    // we can't able to update the value because it is readonly
        Console.WriteLine($"the readonly value is {filecalling.createddate}");
    }
}
