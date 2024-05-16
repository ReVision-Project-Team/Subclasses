using System.Collections.Generic;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.API;
using Subclasses.Enums;

namespace Subclasses;

public class SecurityCommander : SubClassComponent
{
    public override SubClassType Type { get; set; } = SubClassType.SecurityCommander;
    public override RoleTypeId BaseRole { get; set; } = RoleTypeId.NtfPrivate;
    public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.SecurityCommanderInfo}";
    public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.SecurityCommanderItems;
    public override string Broadcast { get; set; } = Plugin.Instance.Translation.SecurityCommanderBroadcast;
    public override Room Spawnpoint { get; set; } = RoomType.EzIntercom.FindRoom();

    public override void OnSpawned()
    {
        Log.Debug("SecurityCommander spawned");
    }
}