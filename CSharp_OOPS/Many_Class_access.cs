using System;

class PDFFiles
{
    public string fileName;
    public string filelocation;
    public string filesize;
    public string filecreateddate;
}
class PDFFileSystem
{
    public void showpdffilelenfth(string[] filename)
    {
        Console.WriteLine("the length is : "+filename.Length);

    }

    public void showallpdffilenames(string[] filename)
    {
        foreach(string pfile in filename)
        {
            Console.WriteLine($" the filename : {pfile}");
        }
    }

    public PDFFiles getfirstrecord(PDFFiles[] filename)
    {
        return filename[0];
    }
}
class PDFProgram
{
    static void Main()
    {
        string[] pdffilename = { "PDFfile1.pdf", "PDFfile2.pdf", "PDFfile3.pdf", "PDFfile4.pdf" };
        PDFFileSystem pdfFsystem = new PDFFileSystem();
        pdfFsystem.showpdffilelenfth(pdffilename);
        pdfFsystem.showallpdffilenames(pdffilename);

        PDFFiles creditcardstatementpdfmarch = new PDFFiles()
        {
            fileName = "creditcardmatchstatement.pdf",
            filelocation = @"D:\Home\Downloads\March",
            filesize = "25Kb",
            filecreateddate = "mar-01-2025"
        };
        PDFFiles creditcardstatementpdfapril = new PDFFiles()
        {
            fileName = "creditcardmatchstatement.pdf",
            filelocation = @"D:\Home\Downloads\March",
            filesize = "25Kb",
            filecreateddate = "mar-01-2025"
        };
        PDFFiles creditcardstatementpdfmay = new PDFFiles()
        {
            fileName = "creditcardmatchstatement.pdf",
            filelocation = @"D:\Home\Downloads\March",
            filesize = "25Kb",
            filecreateddate = "mar-01-2025"
        };
        //PDFFiles[] excelFileList = new PDFFiles[]                     // we can write like this also 
        //{
        //    creditcardstatementpdfmarch,
        //    creditcardstatementpdfapril,
        //    creditcardstatementpdfmay

        //};
        PDFFiles[] excelFileList = new PDFFiles[]                     // we can write like this also 
        {
            new PDFFiles()
            {
                fileName = "creditcardmatchstatementmarch.pdf",
                filelocation = @"D:\Home\Downloads\March",
                filesize = "25Kb",
                filecreateddate = "mar-03-2025"
            },
            new PDFFiles()
            {
                fileName = "creditcardmatchstatementapril.pdf",
                filelocation = @"D:\Home\Downloads\March",
                filesize = "25Kb",
                filecreateddate = "mar-04-2025"
            },
            new PDFFiles()
            {
                fileName = "creditcardmatchstatementmay.pdf",
                filelocation = @"D:\Home\Downloads\March",
                filesize = "25Kb",
                filecreateddate = "mar-05-2025"
            }

        };

        PDFFiles firstrecord = pdfFsystem.getfirstrecord(excelFileList);
        Console.WriteLine(firstrecord.fileName);

    }
}
