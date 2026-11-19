using System;

class File_properties
{

    string filename = "alien_resume.pdf";
    string filelocation = @"d:\Students\resume";
    string filesize = "2Kb";
    string filecreateddate = "Mar-01-2024";
    DateTime filecreateddatetime = DateTime.Now;

    string FileName { get; set; } = "hullala";
    string FileLocation { get; set; } = @"M:\Trash\myresume";
    string FileSize { get; set; } = "50kb";
    string FileCreatedDate { get; set; } = "jun-30-2026";

    static void Main()
    {
        Console.WriteLine("Start");
        File_properties filedetails = new File_properties();
        Console.WriteLine($"Data :{filedetails.filename}");
        Console.WriteLine($"Data :{filedetails.filelocation}");
        Console.WriteLine($"Data :{filedetails.filesize}");
        Console.WriteLine($"Data :{filedetails.filecreateddate}");
        Console.WriteLine($"Data :{filedetails.filecreateddatetime}");


        File_properties filedetails1 = new File_properties();
        filedetails1.FileName = "Nabil";
        Console.WriteLine(filedetails1.FileName);
    }
}
