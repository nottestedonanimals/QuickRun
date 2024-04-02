using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Buffs;

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

            //Buff ms = new Buff(id: "QuickRun.Speed_Sprint", displayName: "Sprint", iconTexture: this.Helper.ModContent.Load<Texture2D>("assets/zoom.png"), iconSheetIndex: 0,
            //                   duration: this.Config.SpeedDurationMilliseconds, effects: new BuffEffects() { Speed = { this.Config.SpeedBoost } });

            

            if (!this.Config.SprintKey.IsDown()) {
                Game1.player.buffs.Remove("QuickRun.Speed_Sprint");
            }
            
        }

        private void SpeedUp(object sender, ButtonsChangedEventArgs e) {


            Buff ms = new Buff(id: "QuickRun.Speed_Sprint", displayName: "Sprint", iconTexture: this.Helper.ModContent.Load<Texture2D>("assets/blank.png"), iconSheetIndex: 0,
                               duration: this.Config.SpeedDurationMilliseconds, effects: new BuffEffects() { Speed = { this.Config.SpeedBoost } });
            ms.visible = false;

            if (this.Config.SprintKey.IsDown()) {
                Game1.player.buffs.Apply(ms);

                
                if (ms.millisecondsDuration > 0) {

                } else {

                    ms.millisecondsDuration = this.Config.SpeedDurationMilliseconds;//2000;

                }
            }
        }
    }
}
