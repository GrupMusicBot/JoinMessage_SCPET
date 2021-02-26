using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CensusAPI.Interfaces;

namespace SCPET_JoinMessage
{
    public class JoinConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool BroadcastMessageEnabled { get; set; } = true;
        public string BroadcastMessage { get; set; } = "Welcome to my server!";
        public bool ChatMessageEnabled { get; set; } = true;
        public string ChatMessage { get; set; } = "Welcome %player%, to my Server!";
        public string MissionMessage { get; set; } = "Have Fun!";
        public bool MissionMessageEnabled { get; set; } = false;
        public int Timer { get; set; } = 5;
    }
}
