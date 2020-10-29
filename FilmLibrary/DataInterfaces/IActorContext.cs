using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IActorContext
    {
        List<IActorDto> GetActors();
        void AddActor(IActorDto actorDto);
        void DeleteActor(int ActorId);
        void EditActor(string actorName, string actorInfo, int actorId);
    }
}
