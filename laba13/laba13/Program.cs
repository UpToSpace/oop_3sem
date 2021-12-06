using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            KVSDiskInfo.action += KVSlog.WriteLog;
            KVSFileInfo.action += KVSlog.WriteLog;
            KVSDirInfo.action += KVSlog.WriteLog;
            KVSFileManager.action += KVSlog.WriteLog;

            KVSDiskInfo.GetFreeSpace(@"C:\");
            KVSDiskInfo.GetEveryDisk();
            KVSFileInfo.GetFileInfo(@"D:\University\3\oop\laba13\laba13\file.txt");
            KVSDirInfo.GetDirInfo(@"D:\University\3\oop\laba13\laba13");
            KVSFileManager.A(@"D:\", "its info");
            KVSFileManager.B(@"D:\University\3\oop\laba13\laba13");
            KVSFileManager.C(@"D:\University\3\oop\laba13\laba13\KVSFiles", @"D:\University\3\oop\laba13\");
            KVSlog.Search("A");
        }
    }
}
