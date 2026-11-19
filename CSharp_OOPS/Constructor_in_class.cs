using System;

// the name of the constructor = name of the class
// constructor name = class name
class File_Detailsconstructors        // class
{

    string filename = "alien_resume.pdf";
    string filelocation = @"d:\Students\resume";
    string filesize = "2Kb";
    string filecreateddate = "Mar-01-2024";


    public File_Detailsconstructors()  // constructor 
    {
        Console.WriteLine("file object created");
        Console.WriteLine($"file Name without this keyword: {filename}");   // we can call the fileds this is one way not recomented way 
        Console.WriteLine($"file Name with this. keyword:{this.filename}"); // this is second way using this. recomended way 
                                                                            // this is nothing but it's represent the class name 
        Console.WriteLine($"file location:{this.filelocation}");   
        Console.WriteLine($"file size:{this.filesize}");   
        Console.WriteLine($"file createdate:{this.filecreateddate}");   
    }
    public File_Detailsconstructors(string filename,string filelocation,string filesize, string filecreatedate)  // constructor  also with parameters we can create
    {
        Console.WriteLine("file object created");
        Console.WriteLine($"file Name without this keyword: {filename}");   // we can call the fileds this is one way not recomented way 
        Console.WriteLine($"file Name with this. keyword:{this.filename}"); // this is second way using this. recomended way 
                                                                            // this is nothing but it's represent the class name 
        Console.WriteLine($"file location with para:{this.filelocation}");   
        Console.WriteLine($"file size with para:{this.filesize}");   
        Console.WriteLine($"file createdate with para:{this.filecreateddate}");   
    }

    static void Main()
    {
        File_Detailsconstructors filedetails = new File_Detailsconstructors();
        File_Detailsconstructors fileTest = new File_Detailsconstructors("creadcitcardMarch.pdf",@"F:\home\Downloads\PDF","30Kb","Mar-01-2025");


    }
}
