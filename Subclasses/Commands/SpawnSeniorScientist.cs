using CommandSystem;
using Exiled.API.Features;
using System;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.Commands;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class SpawnSeniorScientist : ICommand, IUsageProvider
{
    public string Command => "SpawnSeniorScientist";

    public string[] Aliases { get; } = { "SpawnSS" };

    public string Description => "Спавнит старшего научного сотрудника";

    public string[] Usage => new string[] { "Написав после команды \"айди игрока\" он заспавнится за старшего научного сотрудника а если не напишете заспавнитесь вы" };

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        Player player = arguments.Count == 0 ? Player.Get(sender) : Player.Get(arguments.At(0));
        player.Role.Set(RoleTypeId.Spectator);
        bool spawned = player.SpawnSeniorScientist();

        if (!spawned)
        {
            spawned = player.SpawnSeniorScientist();
        }
            
        response = "Спавн прошёл успешно";
        
        return spawned;
    }
}