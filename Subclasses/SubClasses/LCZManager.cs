using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses;

public class LCZManager : SubClassComponent
{
    public override SubClassType Type { get; set; } = SubClassType.LCZManager;
    public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
    public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.LCZManagerInfo}";
    public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.LCZManagerItems;
    public override string Broadcast { get; set; } = Plugin.Instance.Translation.LCZManagerBroadcast;

    public override void OnSpawned()
    {
        Log.Debug("LCZManager spawned");
    }
}