using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class SpawnSecurityCommander : ICommand, IUsageProvider
{
    public string Command => "SpawnSecurityCommander";

    public string[] Aliases { get; } = { "SpawnSC" };

    public string Description => "Спавнит Начальника СБ";

    public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за начальника СБ а если не напишете заспавнитесь вы" };

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
        player.Role.Set(RoleTypeId.Spectator);
        bool spawned = player.SpawnSecurityCommander();

        if (!spawned)
        {
            spawned = player.SpawnSecurityCommander();
        }
            
        response = "Спавн прошёл успешно";
        
        return spawned;
    }
}