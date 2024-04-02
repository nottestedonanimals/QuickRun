using StardewModdingAPI.Utilities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace QuickRun {
    class ModConfig {

        public int SpeedBoost { get; set; } = 2;
        public KeybindList SprintKey { get; set; } = KeybindList.Parse("Space, LeftStick");
        public int SpeedDurationMilliseconds { get; set; } = 2000;
    }
}
