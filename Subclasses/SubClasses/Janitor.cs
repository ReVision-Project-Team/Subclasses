using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses
{
    public class Janitor : SubClassComponent
    {
        public override SubClassType Type { get; set; } = SubClassType.Janitor;
        public override RoleTypeId BaseRole { get; set; } = RoleTypeId.ClassD;
        public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.JanitorInfo}";
        public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.JanitorItems;
        public override string Broadcast { get; set; } = Plugin.Instance.Translation.JanitorBroadcast;

        public override void OnSpawned()
        {
            Log.Debug("Janitor spawned");
        }
    }
}