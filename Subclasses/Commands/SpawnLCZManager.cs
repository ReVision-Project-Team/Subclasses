using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class SpawnLCZManager : ICommand, IUsageProvider
{
    public string Command => "SpawnLCZManager";

    public string[] Aliases { get; } = { "SpawnLCZM" };

    public string Description => "Спавнит менеджера зоны лёгкого содержания";

    public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за менеджера зоны лёгкого содержания а если не напишете заспавнитесь вы" };

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
        player.Role.Set(RoleTypeId.Spectator);
        bool spawned = player.SpawnLCZManager();

        if (!spawned)
        {
            spawned = player.SpawnLCZManager();
        }
            
        response = "Спавн прошёл успешно";
        
        return spawned;
    }
}