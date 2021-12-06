using System;
using System.IO;

namespace laba13
{
    static class KVSDirInfo
    {
        public static event Action<string> action;
        public static void GetDirInfo(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            action($"GetDirInfo works");
            Console.WriteLine($"Files number:{dir.GetFiles().Length}\nCreation Time: {dir.CreationTime}\nSubderictoris number: " +
                $"{dir.GetDirectories().Length}\nParent derictory: {dir.Parent}");
        }
    }
}
