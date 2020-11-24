using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IActorContext
    {
        List<ActorDto> GetActors();
        void AddActor(ActorDto actorDto);
        void RemoveActor(int ActorId);
        void EditActor(string actorName, string actorInfo, int actorId);
    }
}
