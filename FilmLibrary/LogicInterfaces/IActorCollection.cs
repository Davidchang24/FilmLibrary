using System;
using System.Collections.Generic;

namespace LogicInterfaces
{
    public interface IActorCollection
    {
        IReadOnlyList<IActor> GetActors();
        void AddActor(IActor actor);
        void RemoveActor(int actorId);
       
    }
}
