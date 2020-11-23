using System;

namespace LogicInterfaces
{
    public interface IActor
    {
        int ActorId { get; set; }
        string ActorName { get; set; }
        string ActorInfo { get; set; }
    }
}
