using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class SpawnHCZManager : ICommand, IUsageProvider
{
    public string Command => "SpawnHCZManager";

    public string[] Aliases { get; } = { "SpawnHCZM" };

    public string Description => "Спавнит менеджера зоны тяжёлого содержания";

    public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за менеджера зоны тяжёлого содержания а если не напишете заспавнитесь вы" };

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
        player.Role.Set(RoleTypeId.Spectator);
        bool spawned = player.SpawnHCZManager();

        if (!spawned)
        {
            spawned = player.SpawnHCZManager();
        }
            
        response = "Спавн прошёл успешно";
        
        return spawned;
    }
}  