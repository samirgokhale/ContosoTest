using System.Runtime.InteropServices;

namespace ContosoUniversity.Data
{
    public static class OperatingSystem
    {
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static bool IsMacOs() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
    }
}