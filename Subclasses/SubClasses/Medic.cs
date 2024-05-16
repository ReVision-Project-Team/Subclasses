using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses
{
    public class Medic : SubClassComponent
    {
        public override SubClassType Type { get; set; } = SubClassType.Medic;
        public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
        public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.MedicInfo}";
        public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.MedicItems;
        public override string Broadcast { get; set; } = Plugin.Instance.Translation.MedicBroadcast;

        public override void OnSpawned()
        {
            Log.Debug("Medic spawned");
        }
    }
}