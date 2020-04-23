using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.Library
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public string Stage { get; set; }

        public List<List<ObjectParticipator>> Pairs { get; set; } = new List<List<ObjectParticipator>>();
    }
}
