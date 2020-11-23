using System;
using System.Collections.Generic;
using System.Text;
using LogicInterfaces;
using DataInterfaces;
using DataFactory;

namespace Logic
{
    class ActorCollection : IActorCollection
    {
        private List<IActor> actors;

        public ActorCollection()
        {
            IActorContext db = DataFactory.DataFactory.GetActorContext();
            actors = new List<IActor>();
            foreach(var actor in db.GetActors())
            {
                actors.Add(new Actor()
                {
                    ActorId = actor.ActorId,
                    ActorName = actor.ActorName,
                    ActorInfo = actor.ActorInfo
                });
            }
        }

        public void AddActor(IActor actor)
        {
            IActorContext db = DataFactory.DataFactory.GetActorContext();
            IActorDto actorDto = DataFactory.DataFactory.GetActorDto();

            actorDto.ActorId = actor.ActorId;
            actorDto.ActorName = actor.ActorName;
            actorDto.ActorInfo = actor.ActorInfo;

            db.AddActor(actorDto);
        }

        public void RemoveActor(int actorId)
        {
            IActorContext db = DataFactory.DataFactory.GetActorContext();

            db.RemoveActor(actorId);
        }

        public IReadOnlyList<IActor> GetActors()
        {
            return actors;
        }
    }   
}
