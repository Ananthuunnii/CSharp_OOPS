using System;
//using ExcelFileSystem;    // we can use this another file namespace to access the class of that file
//using WordFileSystem;
using PPTFileSystem;
namespace MainProgramSystem
{
    class MainProgram
    {
        public void Main()
        {
            Console.WriteLine($"EXCEL FILES ");
            ExcelFileSystem.Jan_Files excel_jan_Files = new ExcelFileSystem.Jan_Files();              // we calling the another file class
            Console.WriteLine($"jan_Files filename :{excel_jan_Files.filename}");
            ExcelFileSystem.Feb_Files excel_fb_Files = new ExcelFileSystem.Feb_Files();
            Console.WriteLine($"jan_Files filename :{excel_fb_Files.filename}");
            ExcelFileSystem.Mar_Files excel_Mar_Files = new ExcelFileSystem.Mar_Files();
            Console.WriteLine($"jan_Files filename :{excel_fb_Files.filename}");

            Console.WriteLine($"WORD FILES ");
            WordFileSystem.Jan_Files word_jan_Files = new WordFileSystem.Jan_Files();              // we calling the another file class
            Console.WriteLine($"jan_Files filename :{word_jan_Files.filename}");
            WordFileSystem.Feb_Files word_fb_Files = new WordFileSystem.Feb_Files();
            Console.WriteLine($"jan_Files filename :{word_fb_Files.filename}");
            WordFileSystem.Mar_Files word_Mar_Files = new WordFileSystem.Mar_Files();
            Console.WriteLine($"jan_Files filename :{word_Mar_Files.filename}");


            Console.WriteLine($"PPT FILES ");
            Jan_Files ppt_jan_Files = new Jan_Files();              // we calling the another file class
            Console.WriteLine($"jan_Files filename :{ppt_jan_Files.filename}");
            Feb_Files ppt_fb_Files = new Feb_Files();
            Console.WriteLine($"jan_Files filename :{ppt_fb_Files.filename}");
            Mar_Files ppt_Mar_Files = new Mar_Files();
            Console.WriteLine($"jan_Files filename :{ppt_Mar_Files.filename}");

        }
    }
}
