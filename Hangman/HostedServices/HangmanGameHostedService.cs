using Microsoft.Extensions.Hosting;

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
            await _game.Run(stoppingToken).ConfigureAwait(false);
        }
    }
}
