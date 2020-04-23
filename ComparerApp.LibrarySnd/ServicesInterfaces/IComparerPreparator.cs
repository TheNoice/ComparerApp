using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.LibrarySnd.ServicesInterfaces
{
    public interface IComparerPreparator
    {
        ParticipatorsContainer Prepare();
        Round CreateRound(int capacity, List<ObjectParticipator> participators);

    }
}
