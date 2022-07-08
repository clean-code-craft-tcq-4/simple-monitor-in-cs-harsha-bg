using System;

namespace Simple_Monitor
{
    public static class ExtensionMethod
    {
        public static void printMessage(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
