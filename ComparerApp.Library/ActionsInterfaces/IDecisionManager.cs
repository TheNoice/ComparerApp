using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.Library.ActionsInterfaces
{
    public interface IDecisionManager
    {
        ObjectParticipator MakeDecisions(Round round, int capacity, IIOService iOService);
    }
}
