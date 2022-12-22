using System;
using Microsoft.Extensions.Hosting;

namespace HangMan;
class Program
{
    private const string VERSION = "V 1.0";
    static void Main(string[] args)
    {
        Console.WriteLine($"HangMan Game {VERSION}");

        var builder = Host.CreateDefaultBuilder(args);

    }
}
