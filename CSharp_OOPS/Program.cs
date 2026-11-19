using System;
class FileDetails
{

    string filename = "alien_resume.pdf";
    string filelocation = @"d:\Students\resume";
    string filesize = "2Kb";
    string filecreateddate = "Mar-01-2024";
    DateTime filecreateddatetime = DateTime.Now ;

    void showMessage(string name, string filelocation)                  //nonstatic method because it start with void
    {
        Console.WriteLine($"the file name {name} is located in {filelocation}");
    }

    void showdetailsmessage(FileDetails fileN)  //nonstatic method -here the fileN is a referance of FileDetails kind a datatype
    {
        Console.WriteLine($"the filename is {fileN.filename}");         //nonstatic method itstart with void
    }
    static void staticshowdetailsmessage(FileDetails fileN)  // static method
    {
        Console.WriteLine($"the filename is {fileN.filename}");        
    }

    static void Main()
    {
        Console.WriteLine("Start");
        FileDetails filedetails = new FileDetails();
        Console.WriteLine($"Data :{filedetails.filename}");
        Console.WriteLine($"Data :{filedetails.filelocation}");
        Console.WriteLine($"Data :{filedetails.filesize}");
        Console.WriteLine($"Data :{filedetails.filecreateddate}");
        Console.WriteLine($"Data :{filedetails.filecreateddatetime}");


        filedetails.filename = "akbar_resume.docx";
        filedetails.filelocation = @"c:\graduate\resume";
        filedetails.filesize = "500kb";
        filedetails.filecreateddate = "Jan-24-2025";
        filedetails.filecreateddatetime = DateTime.Now;

        //Console.WriteLine("Updated file Details");
        //Console.WriteLine($"Data :{filedetails.filename}");
        //Console.WriteLine($"Data :{filedetails.filelocation}");
        //Console.WriteLine($"Data :{filedetails.filesize}");
        //Console.WriteLine($"Data :{filedetails.filecreateddate}");
        //Console.WriteLine($"Data :{filedetails.filecreateddatetime}");

        FileDetails filedetails1 = new FileDetails();
        //method using the reference for nonstatice method
        filedetails1.showMessage(filedetails1.filename, filedetails1.filelocation);

        //method using the reference for nonstatice method
        filedetails1.showdetailsmessage(filedetails1); // this is a nonstatic method we to call the method using the reference

        // static method
        staticshowdetailsmessage(filedetails1);  // static method







    }
}
