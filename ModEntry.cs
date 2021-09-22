using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace QuickRun {
    public class ModEntry : Mod {

        private ModConfig Config;

        public override void Entry(IModHelper helper) {

            this.Config = this.Helper.ReadConfig<ModConfig>();
            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;

        }

        private void GameLoop_SaveLoaded(object sender, SaveLoadedEventArgs e) {
            
            this.Helper.Events.Input.ButtonsChanged += SpeedUp;
            this.Helper.Events.Input.ButtonReleased += RemoveSpeed;
        
        }

        private void RemoveSpeed(object sender, ButtonReleasedEventArgs e) {

            Buff ms = Game1.buffsDisplay.otherBuffs.Find(b => b.source == "QuickRun");
            //SButtonState spaceState = this.Helper.Input.GetState(SButton.Space);

            if (ms != null) {

                if (!this.Config.SprintKey.IsDown()) {
                    ms.removeBuff();
                    Game1.buffsDisplay.otherBuffs.Remove(ms);
                }
            }
        }

        private void SpeedUp(object sender, ButtonsChangedEventArgs e) {

            SButtonState keybindState = this.Helper.Input.GetState(SButton.Space);

            // Example buff application: https://github.com/minervamaga/FeelingLucky/blob/master/FeelingLucky/FeelingLucky/ModEntry.cs

            Buff ms = Game1.buffsDisplay.otherBuffs.Find(b => b.source == "QuickRun");
            if (this.Config.SprintKey.IsDown()) {
                if (ms == null) {

                    ms = new Buff(0, 0, 0, 0, 0, 0, 0, 0, 0, this.Config.SpeedBoost, 0, 0, 0, "QuickRun", "QuickRun");
                    ms.millisecondsDuration = this.Config.SpeedDurationMilliseconds;//2000;
                    Game1.buffsDisplay.addOtherBuff(ms);

                } else {
                    if (ms.millisecondsDuration > 0) {

                    } else {

                        ms.millisecondsDuration = this.Config.SpeedDurationMilliseconds;//2000;

                    }
                }
            }
        }
    }
}
