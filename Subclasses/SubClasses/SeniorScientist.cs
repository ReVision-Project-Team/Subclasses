using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses;

public class SeniorScientist : SubClassComponent
{
    public override SubClassType Type { get; set; } = SubClassType.SeniorScientist;
    public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
    public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.SeniorScientistInfo}";
    public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.SeniorScientistItems;
    public override string Broadcast { get; set; } = Plugin.Instance.Translation.SeniorScientistBroadcast;

    public override void OnSpawned()
    {
        Log.Debug("SeniorScientist spawned");
    }
}