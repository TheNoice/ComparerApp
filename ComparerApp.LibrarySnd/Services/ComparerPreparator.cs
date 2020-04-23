using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ComparerApp.LibrarySnd.Utils;
using ComparerApp.LibrarySnd.ServicesInterfaces;

namespace ComparerApp.LibrarySnd.Services
{
    public class ComparerPreparator : IComparerPreparator
    {
        public ParticipatorsContainer Prepare()
        {
            string[] objectsDirectory = Directory.GetFiles(@"C:\Users\Пользователь\source\repos\ComparerApp\ComparerApp.LibrarySnd\Comparer_Pictures");

            if (objectsDirectory == null)
            {
                throw new DirectoryNotFoundException();
            }

            ParticipatorsContainer container = new ParticipatorsContainer();
            container.Capacity = objectsDirectory.Length;

            if ((Math.Log((double)container.Capacity, 2) % 1) != 0)
            {
                throw new ComparerValidityException("The amount of files in your Directory is not a number that represents number 2 raised to some power.\nCannot procede.");
            }

            foreach (string item in objectsDirectory)
            {
                ObjectParticipator participator = new ObjectParticipator();
                participator.FileDirectory = item;
                participator.FileName = Path.GetFileNameWithoutExtension(item);
                container.ObjectsArray.Add(participator);
            }
            return container;
        }

        public Round CreateRound(int capacity, List<ObjectParticipator> participators)
        {
            ParticipatorsContainer tmpContainer = new ParticipatorsContainer();
            foreach (ObjectParticipator item in participators)
            {
                tmpContainer.ObjectsArray.Add(item);
            }

            Round round = new Round();
            int numberOfPairs = capacity / 2;
            int tmpCapacity = capacity;
            for (int i = 0; i < numberOfPairs; i++)
            {
                List<ObjectParticipator> pair = new List<ObjectParticipator>();
                Random rnd = new Random();

                int firstObj = rnd.Next(tmpCapacity);
                tmpCapacity--;
                pair.Add(tmpContainer.ObjectsArray[firstObj]);
                tmpContainer.ObjectsArray.Remove(tmpContainer.ObjectsArray[firstObj]);

                int secondObj = rnd.Next(tmpCapacity);
                tmpCapacity--;
                pair.Add(tmpContainer.ObjectsArray[secondObj]);
                tmpContainer.ObjectsArray.Remove(tmpContainer.ObjectsArray[secondObj]);

                round.Pairs.Add(pair);
            }
            round.RoundNumber = 1;
            round.Stage = $"1/{numberOfPairs}";
            if (round.Stage == "1/1")
            {
                round.Stage = "Final";
            }

            return round;
        }
    }
}
