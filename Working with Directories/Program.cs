using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            //create directory 
            Directory.CreateDirectory(@"c:\temp\folder1");


            //Get files in given directories 
            var files = Directory.GetFiles(@"C:\Users\slal\Desktop\Mosh\CSharpFundamentals", "*.sln*"
                , SearchOption.AllDirectories);

            foreach(var file in files)
                Console.WriteLine(files);

            
              
            
            var directories =Directory.GetDirectories(@"C:\Users\slal\Desktop\Mosh\CSharpFundamentals","*.sln*"
                , SearchOption.AllDirectories);
              
            foreach (var directory in directories)
            {
                Console.WriteLine(directories);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }   
    }
}
