using System;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Subclasses.Enums;
using UnityEngine;

namespace Subclasses.API
{
    public static class Extensions
    {
        public static Room FindRoom(this RoomType type) => Room.List.ToList().FirstOrDefault(x => x.Type == type);

        public static T AddSubclassComponent<T>(this Player player) where T : Component
        {
            if (player.GameObject.TryGetComponent(out SubClassComponent component))
                return null;
            
            return player.GameObject.AddComponent<T>();
        }

        public static SubClassType GetSubclassType(this Player player)
        {
            if (player.GameObject.TryGetComponent(out SubClassComponent component))
            {
                return component.Type;
            }

            return SubClassType.None;
        }

        public static bool SpawnJanitor(this Player player)
        {
            player.AddSubclassComponent<Janitor>();

            return player.GameObject.TryGetComponent(out Janitor component);
        }

        public static bool SpawnSecurityCommander(this Player player)
        {
            player.AddSubclassComponent<SecurityCommander>();

            return player.GameObject.TryGetComponent(out SecurityCommander component);
        }
        public static bool SpawnFacilityManager(this Player player)
        {
            player.AddSubclassComponent<FacilityManager>();

            return player.GameObject.TryGetComponent(out FacilityManager component);
        }
        public static bool SpawnEngineer(this Player player)
        {
            player.AddSubclassComponent<Engineer>();

            return player.GameObject.TryGetComponent(out Engineer component);
        }
        public static bool SpawnHCZManager(this Player player)
        {
            player.AddSubclassComponent<HCZManager>();

            return player.GameObject.TryGetComponent(out HCZManager component);
        }
        public static bool SpawnLCZManager(this Player player)
        {
            player.AddSubclassComponent<LCZManager>();

            return player.GameObject.TryGetComponent(out LCZManager component);
        }
        public static bool SpawnSeniorScientist(this Player player)
        {
            player.AddSubclassComponent<SeniorScientist>();

            return player.GameObject.TryGetComponent(out SeniorScientist component);
        }
        public static bool SpawnJuniorScientist(this Player player)
        {
            player.AddSubclassComponent<JuniorScientist>();

            return player.GameObject.TryGetComponent(out JuniorScientist component);
        }
        public static bool SpawnMedic(this Player player)
        {
            player.AddSubclassComponent<Medic>();

            return player.GameObject.TryGetComponent(out Medic component);
        }
    }
}