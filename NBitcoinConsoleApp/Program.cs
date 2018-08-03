using System;
using NBitcoin;


namespace NBitcoinConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! " + new Key().GetWif(Network.Main));
        }

        Key privateKey = new Key();// generate a random private key
        //PubKey publicKey = privateKey.PubKey;
    }
}
