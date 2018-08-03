using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Text;


namespace lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"D:\Folder1\";
            string path2 = @"D:\Folder2\";

            DirectoryInfo dirinfo1 = new DirectoryInfo(path1);
            DirectoryInfo dirinfo2 = new DirectoryInfo(path2);

            IEnumerable<FileInfo> list1 = dirinfo1.GetFiles("*.*", SearchOption.AllDirectories);
            IEnumerable<FileInfo> list2 = dirinfo2.GetFiles("*.*", SearchOption.AllDirectories);

            CopyFromFileToFile(list1, list2);
            //list of files that are present in the first direcory and not in the second one
            IEnumerable<FileInfo> diff1 = list1.Where(files1 => !list2.Any( files2 => files1.Name == files2.Name)).Select(x => x); 
            
            CreateFilesInDirectory(path2, diff1);
            //list of files that are present in the second direcory and not in the first one
            IEnumerable<FileInfo> diff2 = list2.Where(files2 => !list1.Any(files1 => files2.Name == files1.Name)).Select(x => x);

            DeleteFilesInDirectory(diff2);

            Console.ReadKey();
        }

        static async void CopyFromFileToFile(IEnumerable<FileInfo> list1, IEnumerable<FileInfo> list2)
        {
            foreach (var file1 in list1)
            {
                foreach (var file2 in list2)
                {
                    if (file1.Name == file2.Name && !CompareTwoFiles(file1.FullName, file2.FullName))
                    {
                        using (FileStream SourceStream = File.Open(file1.FullName, FileMode.Open))
                        {
                            await SourceStream.CopyToAsync(File.Open(file2.FullName, FileMode.Open));
                            //File.Copy(file1.FullName, file2.FullName, true);
                        }
                        
                    }
                }
            }
        }

        static bool CompareTwoFiles(string path1, string path2)
        {
            HashAlgorithm ha = HashAlgorithm.Create();
            FileStream f1 = new FileStream(path1, FileMode.Open);
            FileStream f2 = new FileStream(path2, FileMode.Open);
            
            byte[] hash1 = new MD5CryptoServiceProvider().ComputeHash(f1);
            byte[] hash2 = new MD5CryptoServiceProvider().ComputeHash(f2);
            f1.Close();
            f2.Close();

            if (hash2.Length == hash1.Length)
            {
                int i = 0;
                while ((i < hash2.Length) && (hash2[i] == hash1[i]))
                {
                    i += 1;
                }
                if (i == hash2.Length)
                {
                    return true;
                }
            }


            return false;
            
        }

        static async void CreateFilesInDirectory(string path2, IEnumerable<FileInfo> diff1)
        {
            foreach (var diff in diff1)
            {
                using (FileStream SourceStream = File.Open(diff.FullName, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(path2 + diff.Name))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                        //File.Copy(diff.FullName, Path.Combine(path2, diff.Name));
                    }
                }
            }
        }


        static  void DeleteFilesInDirectory(IEnumerable<FileInfo> diff2)
        {
            foreach (var diff in diff2)
            {
                File.Delete(diff.FullName);
            }
        }

        

    }
}
