using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses
{
    public class JuniorScientist : SubClassComponent
    {
        public override SubClassType Type { get; set; } = SubClassType.JuniorScientist;
        public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
        public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.JuniorScientistInfo}";
        public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.JuniorScientistItems;
        public override string Broadcast { get; set; } = Plugin.Instance.Translation.JuniorScientistBroadcast;

        public override void OnSpawned()
        {
            Log.Debug("JuniorScientist spawned");
        }
    }
}