using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SpawnMedic : ICommand, IUsageProvider
    {
        public string Command => "SpawnMedic";

        public string[] Aliases { get; } = { "SpawnM" };

        public string Description => "Спавнит медика";

        public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за медика а если не напишете заспавнитесь вы" };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
            player.Role.Set(RoleTypeId.Spectator);
            bool spawned = player.SpawnMedic();

            if (!spawned)
            {
                spawned = player.SpawnMedic();
            }
            
            response = "Спавн прошёл успешно";
        
            return spawned;
        }
    }  
}