using System.Collections.Generic;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.Enums;

namespace Subclasses
{
    public class Engineer : SubClassComponent
    {
        public override SubClassType Type { get; set; } = SubClassType.Engineer;
        public override RoleTypeId BaseRole { get; set; } = RoleTypeId.Scientist;
        public override string Info { get; set; } = $"\n{Plugin.Instance.Translation.EngineerInfo}";
        public override List<ItemType> Inventory { get; set; } = Plugin.Instance.Config.EngineerItems;
        public override string Broadcast { get; set; } = Plugin.Instance.Translation.EngineerBroadcast;

        public override void OnSpawned()
        {
            Log.Debug("Engineer spawned");
        }
    }
}