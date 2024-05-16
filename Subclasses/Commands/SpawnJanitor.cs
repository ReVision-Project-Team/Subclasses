using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SpawnJanitor : ICommand, IUsageProvider
    {
        public string Command => "SpawnJanitor";

        public string[] Aliases { get; } = { "SpawnJ" };

        public string Description => "Спавнит уборщика";

        public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за уборщика а если не напишете заспавнитесь вы" };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
            player.Role.Set(RoleTypeId.Spectator);
            bool spawned = player.SpawnJanitor();

            if (!spawned)
            {
                spawned = player.SpawnJanitor();
            }
            
            response = "Спавн прошёл успешно";
        
            return spawned;
        }
    }   
}