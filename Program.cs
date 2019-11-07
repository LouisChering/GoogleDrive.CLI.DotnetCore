using System;
using System.IO;

using DriveDotNet.Models;
using DriveDotNet.Service;

namespace commandline
{
    class Program
    {

        static void PrintHelp(){
            Console.WriteLine($"--------------------------------\n.net core driver help\n--------------------------------\n");
            Console.WriteLine($"-Get all files at root folder-\ndotnet commandline.dll get-files\n\n");
            Console.WriteLine($"-Get all files in a folder-\ndotnet commandline.dll get-files [folder-id]\n\n");
            Console.WriteLine($"-Get all folders in root folder-\ndotnet commandline.dll get-folders\n\n");
            Console.WriteLine($"-Get all folders in a folder-\ndotnet commandline.dll get-folders [folder-id]\n\n");
            Console.WriteLine($"-Download a file-\ndotnet commandline.dll download [file-id] [destination]\n\n");

        }

        static void Main(string[] args)
        {
            String[] myStr = Environment.GetCommandLineArgs();
            var service = new Driver();
            var command = args.Length >= 1 ? args[0] : "help";
            var id = args.Length >= 2 ? args[1] : "";
            var destination = args.Length >= 3 ? args[2] : "";

            FileResultContainer result;
            Stream stream;

            switch(command){
                    case "get-files":
                        result = service.GetFiles(id,"123");
                        foreach(var item in result.files){
                            Console.WriteLine($"Name: {item.Name}, Id:{item.Id}");
                        }
                    break;
                    case "get-folders":
                        result = service.GetFiles(id,"123");
                        foreach(var item in result.folders){
                            Console.WriteLine($"Name: {item.Name}, Id:{item.Id}");
                        }
                    break;
                    case "download":
                        if(string.IsNullOrWhiteSpace(destination)){
                            throw new Exception("You must provide a valid destination.");
                        }
                        stream = service.Download(id);
                        var fileStream = File.Create(destination);
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                        fileStream.Close();
                    break;
                    default:
                        PrintHelp();
                    break;
            }
        }
    }
}
