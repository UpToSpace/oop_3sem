using System;
using System.IO;
using System.Linq;

namespace laba13
{
    static class KVSDiskInfo
    {
        public static event Action<string> action;
        public static void GetFreeSpace(string name)
        {
            var disk = DriveInfo.GetDrives().Single(e => e.Name == name);
            Console.WriteLine($"Available free space: {disk.AvailableFreeSpace} bytes\nFile system: {disk.DriveFormat}\n");
            action($"GetFreeSpace works");
        }
        public static void GetEveryDisk()
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                Console.WriteLine($"disk name:{item.Name}\ntotal size: {item.TotalSize} bytes\nfree size: {item.AvailableFreeSpace} bytes\n label: {item.VolumeLabel}\n");
            }
            action($"GetEveryDisk works");
        }
    }
}
