using System;
using System.Collections.Generic;
using System.Text;
using DataInterfaces;
using DataFactory;

namespace Logic
{
    class ActorCollection 
    {
        private List<Actor> _actors;

        public ActorCollection()
        {
            IActorContext db = DataFactory.DataFactory.GetActorContext();
            _actors = new List<Actor>();
            foreach(var actor in db.GetActors())
            {
                _actors.Add(new Actor()
                {
                    ActorId = actor.ActorId,
                    ActorName = actor.ActorName,
                    ActorInfo = actor.ActorInfo
                });
            }
        }

        public void AddActor(Actor actor)
        {
            IActorContext db = DataFactory.DataFactory.GetActorContext();
            ActorDto actorDto = DataFactory.DataFactory.GetActorDto();

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

        public IReadOnlyList<Actor> GetActors()
        {
            return _actors;
        }
    }   
}
