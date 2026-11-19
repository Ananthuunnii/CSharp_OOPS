namespace InterfaceBasices
{
    // not need to give the public keyword
    // every member in the interface is public only
    
    // one single interface can accept or inherite the multiple interfaces
    interface Interface1           // this way the interface start with "interface"  keyword with name
    {
        // properties
        int id {  get; set; }
        string name { get; set; }


        // only declaration of methods like "what" not include the "what"- the logic

        int GetAge();               // int return type method
        string GetName();           // string return type method

        void GetMessage();          // no return type method

        void GetEmployId(int id);   // no return type method with parameter 

    }

    interface Interface3 
    {
        void GetEmployeeByLocation(string location);
    }
    //interface2 - child     // the interface1 , interface3 - base interface of interface2
    interface Interface2 : Interface1, Interface3           // applay inheritance between interfaces
    {
        int GetEmpList();
    }
}
