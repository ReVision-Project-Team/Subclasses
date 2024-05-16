using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class SpawnFacilityManager : ICommand, IUsageProvider
{
    public string Command => "SpawnFacilityManager";

    public string[] Aliases { get; } = { "SpawnFM" };

    public string Description => "Спавнит Менеджера комплекса";

    public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за менеджера комплекса а если не напишете заспавнитесь вы" };

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
        player.Role.Set(RoleTypeId.Spectator);
        bool spawned = player.SpawnFacilityManager();

        if (!spawned)
        {
            spawned = player.SpawnFacilityManager();
        }
            
        response = "Спавн прошёл успешно";
        
        return spawned;
    }
}