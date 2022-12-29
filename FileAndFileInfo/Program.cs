using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program

    //File- Provides static methods 

    //File Info - Provides instance methods


    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //(source, destination, true-if file exists we can overwrite it)
            
            File.Delete(path);

            if (File.Exists(path))
            { 
                //do something 
            
            }


            //Read all text in files-method returns a string 
            var content= File.ReadAllText(path);



            //created object
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            //check if file exists 
            if (fileInfo.Exists)
            {
                //do something 
            }


            


        }
    }
}
 