using Subclasses.EventHandlers;
using Exiled.Events.Handlers;
using System;

namespace Subclasses
{
    public class Plugin : Exiled.API.Features.Plugin<Config, Translation>
    {
        public static Plugin Instance;
        
        public override string Prefix => "Subclasses";
        public override string Name => "Subclasses";
        public override string Author => "Security camera & Timersky";
        public override Version Version { get; } = new(2, 0, 0);
        
        public override void OnEnabled()
        {
            Instance = this;
            
            Player.ChangingRole += PlayerHandlers.OnChangingRole;
            Server.RoundStarted += ServerHandlers.OnRoundStarted;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Server.RoundStarted -= ServerHandlers.OnRoundStarted;
            Player.ChangingRole -= PlayerHandlers.OnChangingRole;
            
            Instance = null;
            
            base.OnDisabled();
        }
    }
}