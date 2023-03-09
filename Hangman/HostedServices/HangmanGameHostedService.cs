using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.HostedServices
{
    public class HangmanGameHostedService : BackgroundService
    {
        private readonly IHangmanGame _game;
        public HangmanGameHostedService(IHangmanGame game)
        {
            _game= game;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                await _game.Run(stoppingToken).ConfigureAwait(false);
            }
            catch(OperationCanceledException)
            {
                Console.WriteLine("Closing game");
                Environment.Exit(0);
            }
        }
    }
}
