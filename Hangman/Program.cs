using HangMan.Interfaces.Factories;
using HangMan.Factories;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using HangMan.Models.ScaffoldComponents;
using HangMan.Interfaces.Models;
using HangMan.HostedServices;

namespace HangMan
{
    class Program
    {
        private const string VERSION = "V 1.0";
        public static async Task Main(string[] args)
        {
            Console.WriteLine($"HangMan Game {VERSION}");

            var builder = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) => {
                    services.AddSingleton<IModelFactory, ModelFactory>();
                    services.AddSingleton<IScaffoldDisplayBox, ScaffoldDisplayBox>();
                    services.AddSingleton<IGuessesFactory, GuessesFactory>();
                    services.AddSingleton<IHangmanGame, HangmanGame>();
                    services.AddHostedService<HangmanGameHostedService>();
                }  
            );

            var host = builder.Build();
            await host.RunAsync();
        }

    }
}
