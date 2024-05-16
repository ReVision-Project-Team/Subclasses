using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using PlayerRoles;
using Subclasses.API;
using Teleports.API;
using Subclasses.Enums;
using UnityEngine;

namespace Subclasses
{
    public class SubClassComponent : MonoBehaviour
    {
        public virtual SubClassType Type { get; set; }
        public virtual List<ItemType> Inventory { get; set; }
        public virtual string Info { get; set; }
        public virtual string Broadcast { get; set; }
        public virtual RoleTypeId BaseRole { get; set; }
        public virtual Room Spawnpoint { get; set; }
        public virtual Vector3 PlayerSize { get; set; }
        public virtual float MaxHP { get; set; }
        public virtual float HP { get; set; }

        private Player owner;

        private void Start()
        {
            owner = Player.Get(gameObject);
            
            AssignPlayer();
        }
        
        private void OnDestroy()
        {
            owner.CustomInfo = string.Empty;
        }
        
        void AssignPlayer()
        {
            if (Spawnpoint is null)
            {
                owner.Role.Set(BaseRole, SpawnReason.None, RoleSpawnFlags.UseSpawnpoint);
            }
            else
            {
                owner.Role.Set(BaseRole, SpawnReason.None, RoleSpawnFlags.None);
                owner.Teleport(Spawnpoint.GetSafePosition() + Vector3.up * 2f);
            }
            
            if (HP > 0)
            {
                owner.Health = HP;   
            }
            
            if (MaxHP > 0)
            {
                owner.MaxHealth = MaxHP;   
            }
            
            if (PlayerSize != Vector3.zero)
            {
                owner.Scale = PlayerSize;
            }
            
            owner.CustomInfo += Info;
            owner.InfoArea = PlayerInfoArea.Nickname | PlayerInfoArea.Badge | PlayerInfoArea.CustomInfo | PlayerInfoArea.UnitName | PlayerInfoArea.PowerStatus;
            owner.Broadcast(Plugin.Instance.Config.BroadcastDuration, Broadcast);

            owner.ClearInventory();
            foreach (ItemType item in Inventory)
            {
                owner.AddItem(item);
            }
            
            OnSpawned();
        }

        public virtual void OnSpawned()
        {
            
        }
    }
}