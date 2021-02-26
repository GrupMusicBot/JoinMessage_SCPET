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
        public string BroadcastMessage { get; set; } = "Welcome to my server!";
        public string ChatMessage { get; set; } = "Welcome %player%, to my Server!";

        [Description("How long does the broadcasted message appear on the players screen")]
        public int Timer { get; set; } = 5;
    }
}
