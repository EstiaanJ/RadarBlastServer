using System;

namespace RadarBlastServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Server";

            Server.Start(50,12459);

            Console.ReadKey();
        }
    }
}
