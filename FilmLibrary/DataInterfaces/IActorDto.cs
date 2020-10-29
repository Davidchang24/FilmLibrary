using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterfaces
{
    public interface IActorDto
    {
        int ActorId { get; set; }
        string ActorName { get; set; }
        string ActorInfo { get; set; }
    }
}
