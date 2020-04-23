using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComparerApp.LibrarySnd
{
    public class ParticipatorsContainer : ICloneable
    {
        public List<ObjectParticipator> ObjectsArray { get; set; } = new List<ObjectParticipator>();
        public List<ObjectParticipator> NextRoundObjectsArray { get; set; } = new List<ObjectParticipator>();
        public int Capacity { get; set; }
        public int NextRoundCapacity { get; set; }
        public int RemainderOfInitialCapacity { get; set; }

        public object Clone()
        {
            List<ObjectParticipator> objectsArray = new List<ObjectParticipator>();
            List<ObjectParticipator> nextRoundObjectsArray = new List<ObjectParticipator>();

            objectsArray.AddRange(this.ObjectsArray);
            nextRoundObjectsArray.AddRange(this.NextRoundObjectsArray);

            return new ParticipatorsContainer()
            {
                ObjectsArray = objectsArray,
                NextRoundObjectsArray = nextRoundObjectsArray,
                Capacity = this.Capacity,
                NextRoundCapacity = this.NextRoundCapacity,
                RemainderOfInitialCapacity = this.RemainderOfInitialCapacity
            };

        }
    }
}
