using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    static class KVSFileInfo
    {
        public static event Action<string> action;
        public static void GetFileInfo(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                action($"GetFileInfo works");
                Console.WriteLine($"filepath: {file.FullName}\nsize: {file.Length}\nextension: {file.Extension}\nname: {file.Name}\ncreation time: {file.CreationTime}\nchanging time: {file.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("file doesnt exist");
            }
        }
    }
}
