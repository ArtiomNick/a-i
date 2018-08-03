using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;


namespace _13._2
{
    class Program
    {
        public static string path1 = @"D:\Folder1\";
        public static string path2 = @"D:\Folder2\";

        public static void Main()
        {
            Run();

        }

        public static void Run()
        {

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path1;
            //string DestinationPath = @"D:\Folder2\";

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }




        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            File.Copy(e.FullPath, Path.Combine(path2, e.Name), true);

        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            File.Move(Path.Combine(path2, e.OldName), (Path.Combine(path2, e.Name)));
        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            File.Copy(e.FullPath, Path.Combine(path2, e.Name));
        }

        private static void OnDeleted(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            File.Delete(Path.Combine(path2, e.Name));
        }


        

    }
}
