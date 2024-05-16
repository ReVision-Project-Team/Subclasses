using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.API;
using Subclasses.Enums;

namespace Subclasses;

public class FacilityManager : SubClassComponent
{
    public override SubClassType Type { get; set; } = SubClassType.FacilityManager;
    public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
    public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.FacilityManagerInfo}";
    public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.FacilityManagerItems;
    public override string Broadcast { get; set; } = Plugin.Instance.Translation.FacilityManagerBroadcast;
    public override Room Spawnpoint { get; set; } = RoomType.EzIntercom.FindRoom();

    public override void OnSpawned()
    {
        Log.Debug("FacilityManager spawned");
    }
}