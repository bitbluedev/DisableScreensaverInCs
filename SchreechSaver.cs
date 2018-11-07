using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    //c:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe SchreechSaver.cs
    //c:\Windows\Microsoft.NET\Framework\v3.5\csc.exe SchreechSaver.cs
    //c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe SchreechSaver.cs
    class SchreechSaver
    {
        private const uint ES_CONTINUOUS = 0x80000000;
        private const uint ES_DISPLAY_REQUIRED = 0x00000002;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint SetThreadExecutionState([In] uint esFlags);

        static void Main()
        {
            Console.WriteLine("F?ing up screen lock");

            SetThreadExecutionState(ES_CONTINUOUS | ES_DISPLAY_REQUIRED);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}