using DataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class ActorDto : IActorDto
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorInfo { get; set; }
    }
}
