using HangMan.Factories;
using HangMan.Interfaces;
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

        private const string PLAYER_1 = "Player 1";
        private const string PLAYER_2 = "Player 2";


        public HangmanGame(IModelFactory modelFactory, IGuessesFactory guessesFactory, IScaffoldDisplayBox scaffoldDisplayBox)
        {
            _modelFactory = modelFactory;
            _guessesFactory = guessesFactory;
        }

        public async Task Run(CancellationToken stoppingToken)
        {
            await Task.Delay(2000, stoppingToken);

            while (true)
            {
                var targetWord = GetNewTargetWord();
                RunRound(targetWord);
            }
        }

        private static ITargetWord GetNewTargetWord()
        {
            Console.WriteLine($"{PLAYER_1} Enter word to guess");
            var targetWord = new TargetWord();

            while (!targetWord.IsValid())
            {
                targetWord.SetNewWord(Console.ReadLine());
                ClearPreviousLine();

                if (!targetWord.IsValid())
                {
                    Console.WriteLine($"{PLAYER_1} Enter a valid word");
                }
            }

            return targetWord;
        }

        private static void ClearPreviousLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new String(' ', Console.BufferWidth));
        }

        private void RunRound(ITargetWord targetWord)
        {
            if (string.IsNullOrEmpty(targetWord.Value) || string.IsNullOrEmpty(targetWord.Dashes))
            {
                throw new NullReferenceException("The target word value or dashes were not set");
            }

            var roundComplete = false;

            var scaffold = _modelFactory.CreateScaffold();
            var wordProgress = _modelFactory.CreateWordProgress(targetWord);

            var guesses = _guessesFactory.CreateGuesses();

            while (!roundComplete) 
            {
                Console.WriteLine(wordProgress.State);

                var guess = GetGuess(guesses);
                Console.WriteLine("");
                wordProgress.Update(guess);

                if (targetWord.Value.ToUpperInvariant().Contains(char.ToUpperInvariant(guess)))
                {
                    CorrectGuess(guess, guesses);
                }
                else
                {
                    IncorrectGuess(guess, guesses, scaffold);
                }

                Console.WriteLine("");
                Console.WriteLine(scaffold.Display?.Value);
                Console.WriteLine("");
                Console.WriteLine(guesses.ReturnIncorrectGuessesAsString());
                Console.WriteLine("");

                if (scaffold.Completed())
                {
                    roundComplete = EndRound(PLAYER_1);
                }

                if (wordProgress.Guessed())
                {
                    roundComplete = EndRound(PLAYER_2);
                }
            }
        }

        private static char GetGuess(IGuesses guesses)
        {
            char guess = new();

            while (!char.IsLetter(guess) || guesses.HasGuessBeenMadeAlready(guess))
            {
                Console.WriteLine($"{PLAYER_2} Enter a guess");
                guess = Console.ReadKey().KeyChar;
            }

            return guess;
        }

        private static void CorrectGuess(char guess, IGuesses guesses)
        {
            Console.WriteLine("Correct guess!");
            guesses.AddCorrectGuess(guess);
        }

        private static void IncorrectGuess(char guess, IGuesses guesses, IScaffold scaffold)
        {
            Console.WriteLine("Incorrect Guess!");
            guesses.AddIncorrectGuess(guess);
            scaffold.AddWrongGuess();
        }

        private static bool EndRound(string winner)
        {
            Console.WriteLine($"{winner} Wins");
            Console.WriteLine("");
            return true;
        }
    }
}
