using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComparerApp.Library
{
    public class ParticipatorsContainer
    {
        public List<ObjectParticipator> ObjectsArray { get; set; } = new List<ObjectParticipator>();
        public int Capacity { get; set; }
    }
}
