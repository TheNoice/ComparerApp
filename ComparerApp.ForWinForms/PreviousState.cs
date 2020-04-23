using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparerApp.LibrarySnd;

namespace ComparerApp.ForWinForms
{
    class PreviousState
    {
        public List<ObjectParticipator> ChoosedObjects { get; set; }
        public List<ObjectParticipator> ExcludedObjects { get; set; }
        public Round PreviousStageRound { get; set; }
        public ParticipatorsContainer PreviousPContainer { get; set; }

        public PreviousState()
        {
            ChoosedObjects = new List<ObjectParticipator>();
            ExcludedObjects = new List<ObjectParticipator>();
        }

        public void InitializePreviousState(Round round, ParticipatorsContainer container)
        {
            PreviousStageRound = (Round)round.Clone();
            PreviousPContainer = (ParticipatorsContainer)container.Clone();
            ExcludedObjects.Add(round.Pairs[0].First());
            ExcludedObjects.Add(round.Pairs[0].Last());
        }

        public void UpdateObjectsLists(ObjectParticipator choosedObject)
        {
            ChoosedObjects.Add(choosedObject);
            ExcludedObjects.Remove(choosedObject);
        }

        public void RestorePreviousState(ref Round round, ref ParticipatorsContainer container)
        {
            if (round.RoundNumber != 1)
            {
                round.RoundNumber--;

                List<List<ObjectParticipator>> tmpObjects = new List<List<ObjectParticipator>>() {
                new List<ObjectParticipator>() { ChoosedObjects.Last(), ExcludedObjects.Last() }};
                tmpObjects.AddRange(round.Pairs);

                round.Pairs = tmpObjects;

                container.RemainderOfInitialCapacity++;
                container.NextRoundObjectsArray.Remove(container.NextRoundObjectsArray.Last());
            }
            else
            {
                round = (Round)PreviousStageRound.Clone();
                container = (ParticipatorsContainer)PreviousPContainer.Clone();
            }

            ChoosedObjects.Remove(ChoosedObjects.Last());
            ExcludedObjects.Remove(ExcludedObjects.Last());

        }
    }
}
