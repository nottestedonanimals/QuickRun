# QuickRun

Quick run is a mod for the PC version of Stardew Valley. It enables an on demand speed buff to the player's movement speed.

Currently tested for (Windows):
SMAPI == 3.9.0
Stardew Valley == 1.5.4

## Requirements
SMAPI

## Installation Instructions
Download QuickRun 0.0.1.zip
Extract it in your Mods folder found in Steam/steamapps/common/Stardew Valley/Mods

## Usage
After you load the game press and hold the sprint key (space on keyboard or pressing down the left stick on controller by default) and you will move faster until you release the button.


## Configurations
The behavior of this mod can be changed via the config.json file, which should be written after the game is started with the mod installed.

- SpeedBoost - the size of the speed buff given to the player when the sprint button is triggered (must be an integer)
- SprintKey - the keybinding for the sprint key. Currently binds it to the Space Bar on the keyboard and clicking the left stick on the controller. This can be set to whatever buttons you would like.<br>Refer to https://stardewvalleywiki.com/Modding:Player_Guide/Key_Bindings for the correct values for this setting.
- SpeedDurationMilliseconds - The length of the buff duration. Since the buff is removed when the button is released this doesn't affect the actual behavior. But because the buff is continually<br>reapplied, the buff icon in the top will flash when this happens. If that annoys you increase this value and it will flash less.<br>I kept the value low incase of bugs, this way the buffs will be quick to be removed.