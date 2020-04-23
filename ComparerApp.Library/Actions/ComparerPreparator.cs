using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ComparerApp.Library.Utils;

namespace ComparerApp.Library.Actions
{
    public class ComparerPreparator
    {
        public ParticipatorsContainer Prepare()
        {
            string[] objectsDirectory = Directory.GetFiles(@"C:\Users\Пользователь\source\repos\ComparerApp\ComparerApp.Library\Comparer_Pictures");

            if (objectsDirectory == null)
            {
                throw new DirectoryNotFoundException();
            }

            ParticipatorsContainer container = new ParticipatorsContainer();
            container.Capacity = objectsDirectory.Length;

            if ((Math.Log2((double)container.Capacity) % 1) != 0)
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

        public Round CreateRound(ParticipatorsContainer container)
        {
            ParticipatorsContainer tmpContainer = new ParticipatorsContainer();
            foreach (ObjectParticipator item in container.ObjectsArray)
            {
                tmpContainer.ObjectsArray.Add(item);
            }

            Round round = new Round();
            int numberOfPairs = container.Capacity / 2;
            int tmpCapacity = container.Capacity;
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
