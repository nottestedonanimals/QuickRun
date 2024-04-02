using StardewModdingAPI.Utilities;

namespace QuickRun {
    class ModConfig {

        public int SpeedBoost { get; set; } = 5;
        public KeybindList SprintKey { get; set; } = KeybindList.Parse("Space, LeftStick");

    }
}
