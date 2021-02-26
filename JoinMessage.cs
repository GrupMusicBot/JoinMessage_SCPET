using System;
using CensusAPI.Features;

namespace SCPET_JoinMessage
{
    public class JoinMessage : Plugin<JoinConfig>
    {
        public override string Name => "JoinMessage";

        public override Version Version => new Version(1, 0, 1);

        public override string Author => "KuebV";

        public static JoinMessage Instance { get; private set; }

        public override void Disable()
        {
            throw new NotImplementedException();
        }

        public override void Enable()
        {
            Instance = this;
            CensusCore.CensusCore.InjectEvents();

        }
    }
}
