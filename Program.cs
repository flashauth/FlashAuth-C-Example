using System;
using System.IO;

namespace KeyAuth
{
    class Program
    {

        /*
         * 
         * WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=UXRkNEvgxJU
         * 
         */

        static string name = "Test";
        static string ownerid = "c5x32zr8LZ";
        static string secret = "c21cc67ee9a72eaa76f22b0db6cb3c85a9d8e675191a96b2ca8f2aa407745f33";
        static string version = "1.0";

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        static void Main(string[] args) {

            Console.Title = "Flash Auth Example!";
            Console.WriteLine("\n\n  Connecting..");
            KeyAuthApp.init();
            Console.Write("\n\n Enter your license key: ");
            string key = Console.ReadLine();
            KeyAuthApp.license(key);
            Console.WriteLine("\n\n  Logged In!");
            
            Console.ReadLine();
        }
    }
}
