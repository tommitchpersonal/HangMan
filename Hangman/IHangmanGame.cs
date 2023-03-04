namespace HangMan
{
    public interface IHangmanGame
    {
        public Task Run(CancellationToken stoppingToken);
    }
}
