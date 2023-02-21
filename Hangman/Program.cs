using HangMan.Interfaces.Factories;
using HangMan.Factories;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using HangMan.Models.ScaffoldComponents;
using HangMan.Interfaces.Models;
using HangMan.Builders;

namespace HangMan
{
    class Program
    {
        //private const string VERSION = "V 1.0";
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"HangMan Game {VERSION}");

        //    var builder = Host.CreateDefaultBuilder(args)
        //    .ConfigureServices((_, services) => 
        //        services.AddSingleton<IModelFactory, ModelFactory>()
        //    );
        //}

        static void Main(string[] args) 
        {
            var scaffoldBase = new ScaffoldBase();
            var scaffoldPole = new ScaffoldPole();
            var scaffoldArm = new ScaffoldArm();

            var state = new List<IScaffoldComponent>()
            {
                scaffoldBase,
                scaffoldPole,
                scaffoldArm
            };

            var scaffoldComponentArranger = new ScaffoldComponentArranger();

            Console.WriteLine(scaffoldComponentArranger.ArrangeScaffoldComponents(state));
        }
    }
}
