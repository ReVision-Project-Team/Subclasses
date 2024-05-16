using Exiled.API.Interfaces;

namespace Subclasses
{
    public class Translation : ITranslation
    {
        public string MedicBroadcast { get; private set; } = "<b>Вы - <color=#FC2847>Медик</color>!</b>";
        public string MedicInfo { get; private set; } = "Медик";
        
        public string EngineerBroadcast { get; private set; } = "<b>Вы - <color=#FBCEB1>Инженер</color>!</b>";
        public string EngineerInfo { get; private set; } = "Инженер";
        
        public string JuniorScientistBroadcast { get; private set; } = "<b>Вы - <color=#F8F32B>Младший научный сотрудник</color>!</b>";
        public string JuniorScientistInfo { get; private set; } = "Младший научный сотрудник";
        
        public string HCZManagerBroadcast { get; private set; } = "<b>Вы - <color=#40826D>Менеджер Зоны Тяжёлого Содержания</color>!</b>";
        public string HCZManagerInfo { get; private set; } = "Менеджер Зоны Тяжёлого Содержания";
        
        public string LCZManagerBroadcast { get; private set; } = "<b>Вы - <color=#40826D>Менеджер Зоны Лёгкого Содержания</color>!</b>";
        public string LCZManagerInfo { get; private set; } = "Менеджер Зоны Лёгкого Содержания";
        
        public string SeniorScientistBroadcast { get; private set; } = "<b>Вы - <color=#FFBA00>Старший научный сотрудник</color>!</b>";
        public string SeniorScientistInfo { get; private set; } = "Старший научный сотрудник";
        
        public string FacilityManagerBroadcast { get; private set; } = "<b>Вы - <color=#FC2847>Менеджер Комплекса</color>!</b>";
        public string FacilityManagerInfo { get; private set; } = "Менеджер Комплекса";

        public string JanitorBroadcast { get; private set; } = "<b>Вы - <color=#7FB5B5>Уборщик</color>!</b>";
        public string JanitorInfo { get; private set; } = "Уборщик";

        public string SecurityCommanderBroadcast { get; private set; } = "<b>Вы - <color=#6699CC>Начальник Охраны Комплекса</color>!</b>";
        public string SecurityCommanderInfo { get; private set; } = "Начальник Охраны Комплекса";
    }
}
