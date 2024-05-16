using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace Subclasses
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public float SubclassChance { get; set; } = 0.40f;
        public ushort BroadcastDuration { get; set; } = 7;
        
        public List<ItemType> FacilityManagerItems { get; set; } = new()
        {
            ItemType.Radio,
            ItemType.GunRevolver,
            ItemType.ArmorLight,
            ItemType.KeycardFacilityManager,
            ItemType.Medkit
        };
        public List<ItemType> SeniorScientistItems { get; set; } = new()
        {
            ItemType.Medkit,
            ItemType.Painkillers,
            ItemType.Radio,
            ItemType.KeycardResearchCoordinator
        };
        public List<ItemType> LCZManagerItems { get; set; } = new()
        {
            ItemType.Adrenaline,
            ItemType.Radio,
            ItemType.ArmorLight,
            ItemType.KeycardZoneManager,
            ItemType.Flashlight
        };
        public List<ItemType> HCZManagerItems { get; set; } = new()
        {
            ItemType.Adrenaline,
            ItemType.Radio,
            ItemType.ArmorLight,
            ItemType.KeycardZoneManager,
            ItemType.Flashlight,
            ItemType.GunCOM18
        };
        public List<ItemType> JuniorScientistItems { get; set; } = new()
        {
            ItemType.Painkillers,
            ItemType.KeycardJanitor,
            ItemType.Radio
        };
        public List<ItemType> EngineerItems { get; set; } = new()
        {
            ItemType.Medkit,
            ItemType.Adrenaline,
            ItemType.Painkillers,
            ItemType.KeycardContainmentEngineer,
            ItemType.Flashlight,
            ItemType.ArmorLight,
            ItemType.Radio
        };
        public List<ItemType> MedicItems { get; set; } = new()
        {
            ItemType.Medkit,
            ItemType.Adrenaline,
            ItemType.Medkit,
            ItemType.KeycardZoneManager,
            ItemType.Radio,
            ItemType.Medkit,
            ItemType.Medkit,
            ItemType.Medkit
        };
        public List<ItemType> SecurityCommanderItems { get; set; } = new()
        {
            ItemType.Radio,
            ItemType.GunCrossvec,
            ItemType.ArmorCombat,
            ItemType.Medkit,
            ItemType.KeycardNTFLieutenant,
            ItemType.GrenadeHE,
            ItemType.Adrenaline
        };
        public List<ItemType> JanitorItems { get; set; } = new()
        {
            ItemType.KeycardJanitor,
            ItemType.Painkillers
        };
    }
}
