using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    static class KVSFileManager
    {
        public static event Action<string> action;
        public static void A(string diskName, string info)
        {
            DirectoryInfo disk = new DirectoryInfo(diskName);
            foreach (var item in disk.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in disk.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
            string path = @"D:\University\3\oop\laba13\laba13\kvsdirinfo.txt";
            Directory.CreateDirectory(@"D:\University\3\oop\laba13\laba13\KVSInspect");
            File.Create(path).Dispose();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(info);
            }
            string newPath = @"D:\University\3\oop\laba13\laba13\newkvsdirinfo.txt";
            File.Copy(path, newPath, true);
            File.Delete(path);
            action($"A works");
        }
        public static void B(string sourse)
        {
            string path = @"D:\University\3\oop\laba13\laba13\KVSFiles\";
            Directory.CreateDirectory(path);
            string extension = ".txt";
            DirectoryInfo dir = new DirectoryInfo(sourse);
            foreach (var item in dir.GetFiles())
            {
                if (item.Extension == extension)
                {
                    item.CopyTo(path + item.Name, true);
                }
            }
            string newPath = @"D:\University\3\oop\laba13\laba13\KVSInspect\";
            Directory.Delete(newPath, true);
            Directory.Move(path, newPath);
            action($"B works");
        }
        public static void C(string soursePath, string distPath)
        {
            if (!File.Exists(soursePath + ".zip"))
            {
                ZipFile.CreateFromDirectory(soursePath, soursePath + ".zip");
            }
            ZipFile.ExtractToDirectory(soursePath + ".zip", distPath);
            action($"C works");
        }
    }

}
