using System;
using System.Collections.Generic;
using System.Text;
using LogicInterfaces;

namespace Logic
{
    class Actor : IActor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorInfo { get; set; }       
    }
}
