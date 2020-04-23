using ComparerApp.LibrarySnd.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparerApp.LibrarySnd.Services
{
    public class DecisionManager : IDecisionManager
    {
        public ObjectParticipator MakeDecision(string fileName, Round round, ParticipatorsContainer container)
        {
            ObjectParticipator choosenObject = round.Pairs[0].Find(i => i.FileName.ToLower() == fileName.ToLower());
            round.Pairs.Remove(round.Pairs[0]);
            round.RoundNumber++;
            container.NextRoundObjectsArray.Add(choosenObject);
            container.RemainderOfInitialCapacity--;

            return choosenObject;
        }

        public bool CheckWinCondition(ParticipatorsContainer container)
        {
            if (container.RemainderOfInitialCapacity == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Round CreateNewRoundIfNeeded(Round round, ParticipatorsContainer container)
        {
            if (!round.Pairs.Any())
            {
                var preparator = new ComparerPreparator();
                container.NextRoundCapacity = container.NextRoundObjectsArray.Count();
                round = preparator.CreateRound(container.NextRoundCapacity, container.NextRoundObjectsArray);

                container.NextRoundObjectsArray = new List<ObjectParticipator>();
                return round;
            }
            else
            {
                return round;
            }
        }
    }
}
