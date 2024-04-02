using StardewModdingAPI.Utilities;

namespace QuickRun {
    class ModConfig {

        public int SpeedBoost { get; set; } = 10;
        public KeybindList SprintKey { get; set; } = KeybindList.Parse("Space, LeftStick");

    }
}
