using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.Library.ActionsInterfaces
{
    public interface IIOService
    {
        ObjectParticipator AskForDecision(List<ObjectParticipator> objectParticipators);
    }
}
