using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using Subclasses.API;
using Subclasses.Enums;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Subclasses.EventHandlers
{
    internal class PlayerHandlers
    {
        internal static void OnChangingRole(Exiled.Events.EventArgs.Player.ChangingRoleEventArgs ev)
        {
            if (ev.Player is null) return;
            Log.Debug("Changing role...");
            
            if (ev.Player.GameObject.TryGetComponent(out SubClassComponent subclass) && ev.Reason == SpawnReason.None)
            {
                Log.Debug("Player already has subclass");
                return;
            }
            
            if (ev.Player.GameObject.TryGetComponent(out SubClassComponent component))
            {
                ev.Player.CustomInfo = String.Empty;
                Object.Destroy(component);
            }
            
            if (Random.value <= Plugin.Instance.Config.SubclassChance)
            {
                Log.Debug("Try give subclass");
                Timing.CallDelayed(0.3f, () =>
                {
                    if (ev.NewRole == PlayerRoles.RoleTypeId.ClassD)
                    {
                        ev.Player.SpawnJanitor();
                    }
                    else if (ev.NewRole == PlayerRoles.RoleTypeId.Scientist)
                    {
                        int subclassesCount = 6;
                        int subclass = Random.Range(1, subclassesCount);
                        switch (subclass)
                        {
                            case 1:
                                ev.Player.SpawnEngineer();
                                break;
                            case 2:
                                ev.Player.SpawnJuniorScientist();
                                break;
                            case 3:
                                ev.Player.SpawnSeniorScientist();
                                break;
                            case 4:
                                ev.Player.SpawnLCZManager();
                                break;
                            case 5:
                                ev.Player.SpawnHCZManager();
                                break;
                            case 6:
                                ev.Player.SpawnMedic();
                                break;
                        }
                    }
                });
            }
        }
    }
}