using System;
using System.IO;

namespace jukebox.webapi
{
    public class HelloWorld
    {
        public string Helloworld { get; set; }

        public HelloWorld()
        {
            if (File.Exists("helloworld.txt"))
            {
                Helloworld = File.ReadAllText("helloworld.txt");
            }
            else
            {
                Helloworld = "??";
            }
        }
    }
}
