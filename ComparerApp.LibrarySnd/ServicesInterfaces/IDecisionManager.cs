using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.LibrarySnd.ServicesInterfaces
{
    public interface IDecisionManager
    {
        ObjectParticipator MakeDecision(string fileName, Round round, ParticipatorsContainer container);
        bool CheckWinCondition(ParticipatorsContainer container);
        Round CreateNewRoundIfNeeded(Round round, ParticipatorsContainer container);
    }
}
