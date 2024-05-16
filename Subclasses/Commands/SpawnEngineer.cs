using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SpawnEngineer : ICommand, IUsageProvider
    {
        public string Command => "SpawnEngineer";

        public string[] Aliases { get; } = { "SpawnE" };

        public string Description => "Спавнит инженера";

        public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за инженера а если не напишете заспавнитесь вы" };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
            player.Role.Set(RoleTypeId.Spectator);
            bool spawned = player.SpawnEngineer();

            if (!spawned)
            {
                spawned = player.SpawnEngineer();
            }
            
            response = "Спавн прошёл успешно";
        
            return spawned;
        }
    }  
}