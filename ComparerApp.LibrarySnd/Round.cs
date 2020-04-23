using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.LibrarySnd
{
    public class Round : ICloneable
    {
        public int RoundNumber { get; set; }
        public string Stage { get; set; }

        public List<List<ObjectParticipator>> Pairs { get; set; } = new List<List<ObjectParticipator>>();

        public object Clone()
        {
            List<List<ObjectParticipator>> pairs = new List<List<ObjectParticipator>>();
            pairs.AddRange(this.Pairs);
            return new Round() { Pairs = pairs, RoundNumber = this.RoundNumber, Stage = this.Stage };
        }
    }
}
