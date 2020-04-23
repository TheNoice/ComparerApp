using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComparerApp.LibrarySnd;
using ComparerApp.LibrarySnd.Services;
using ComparerApp.LibrarySnd.ServicesInterfaces;

namespace ComparerApp.ForConsole
{
    class Application
    {
        public void Run(IDecisionManager decisionManager, IComparerPreparator preparator)
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Welcome to the comparer application.");
                ParticipatorsContainer container = new ParticipatorsContainer(); //мб чтобы убрать дублирование кода можно было бы через делегат для ex.Message,
                //но особого упрощения кода в этом не вижу
                try
                {
                    container = preparator.Prepare(); //есть контейнер файлов, в котором есть имя и полный путь каждого файла из папки
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                container.RemainderOfInitialCapacity = container.Capacity;

                Round round = preparator.CreateRound(container.Capacity, container.ObjectsArray);

                bool roundActive = true;
                while (roundActive)
                {
                    round = decisionManager.CreateNewRoundIfNeeded(round, container);

                    Console.WriteLine();
                    Console.WriteLine($"Current Stage: {round.Stage}. Round: {round.RoundNumber} out of {round.Pairs.Count + container.NextRoundObjectsArray.Count}");
                    Console.WriteLine($"Choose the best between: {round.Pairs[0].First().FileName} and {round.Pairs[0].Last().FileName}");
                    Console.WriteLine($"To make your decision write down \"{round.Pairs[0].First().FileName}\" or \"{round.Pairs[0].Last().FileName}\"");

                    string choice = Console.ReadLine().ToLower();
                    if (choice == round.Pairs[0].First().FileName.ToLower() || choice == round.Pairs[0].Last().FileName.ToLower())
                    {
                        decisionManager.MakeDecision(choice, round, container);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unknown input. Please, try again");
                    }

                    if (decisionManager.CheckWinCondition(container))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"The winner is {container.NextRoundObjectsArray[0].FileName}!");
                        Console.WriteLine();
                        roundActive = false;
                    }
                }

                bool continueNeeded = false;
                while (!continueNeeded)
                {
                    Console.WriteLine("Would you like to restart the comparer application?\nWrite down \"yes\" or \"no\"");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine();
                        continueNeeded = true;
                    }
                    else if (answer == "no")
                    {
                        continueNeeded = true;
                        isWorking = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unknown command");
                    }

                }
            }
            
        }
    }
}
