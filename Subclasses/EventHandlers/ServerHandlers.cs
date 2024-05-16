using Exiled.API.Extensions;
using Exiled.API.Features;
using MEC;
using System.Linq;
using PlayerRoles;
using Subclasses.API;

namespace Subclasses.EventHandlers
{
    internal sealed class ServerHandlers
    {
        internal static void OnRoundStarted()
        {
            Timing.CallDelayed(2, () =>
            {
                Player securityCommander = Player.List.Where(x => x.Role.Type == RoleTypeId.FacilityGuard).GetRandomValue();
                Player facilityManager = Player.List.Where(x => x.Role.Type == RoleTypeId.Scientist).GetRandomValue();

                if (securityCommander != null && Player.List.Where(x => x.Role.Type == RoleTypeId.FacilityGuard).Count() >= 2)
                {
                    securityCommander.SpawnSecurityCommander();
                }
                if (facilityManager != null && Player.List.Where(x => x.Role.Type == RoleTypeId.FacilityGuard).Count() >= 3)
                {
                    facilityManager.SpawnFacilityManager();
                }
            });
        }
    }
}