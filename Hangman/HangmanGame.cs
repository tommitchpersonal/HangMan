using HangMan.Factories;
using HangMan.Interfaces.Factories;
using HangMan.Interfaces.Models;
using HangMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class HangmanGame : IHangmanGame
    {
        private readonly IModelFactory _modelFactory;
        private readonly IGuessesFactory _guessesFactory;
        private readonly IScaffoldDisplayBox _scaffoldDispayBox; 


        public HangmanGame(IModelFactory modelFactory, IGuessesFactory guessesFactory, IScaffoldDisplayBox scaffoldDisplayBox)
        {
            _modelFactory = modelFactory;
            _guessesFactory = guessesFactory;
            _scaffoldDispayBox = scaffoldDisplayBox;
        }

        public async Task Run(CancellationToken stoppingToken)
        {
            await Task.Delay(2000, stoppingToken);

            while (true)
            {
                var targetWord = GetNewTargetWord();
            }
        }

        private ITargetWord GetNewTargetWord()
        {
            Console.WriteLine("Enter word to guess");
            var targetWord = new TargetWord();

            while (!targetWord.IsValid())
            {
                targetWord.SetNewWord(Console.ReadLine());

                if (!targetWord.IsValid())
                {
                    Console.WriteLine("Enter a valid word");
                }
            }

            return targetWord;
        }
    }
}
