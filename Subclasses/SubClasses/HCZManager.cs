using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.API;
using Subclasses.Enums;

namespace Subclasses;

public class HCZManager : SubClassComponent
{
    public override SubClassType Type { get; set; } = SubClassType.HCZManager;
    public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
    public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.HCZManagerInfo}";
    public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.HCZManagerItems;
    public override string Broadcast { get; set; } = Plugin.Instance.Translation.HCZManagerBroadcast;
    public override Room Spawnpoint { get; set; } = RoomType.HczCrossing.FindRoom();

    public override void OnSpawned()
    {
        Log.Debug("HCZManager spawned");
    }
}