AutomaticReplayViewer v1.2 for Skullgirls

Created by Mao (@NZMao)
InputManager.dll by shynet (https://www.codeproject.com/Articles/117657/InputManager-library-Track-user-input-and-simulate)

This program allows for sets of consecutive replays to be played back automatically.
It also has functionality for pressing hotkeys for starting and stopping recording software such as OBS.

Before starting the viewing process, navigate to the first replay to be played in SG.

Inputs:
- Start!
	- Starts the viewing process
- Stop
	- Stops the viewing process
- Number of replays
	- The number of replays that will be played
	- If the text inputted does not parse or is a number less than 1, this value will be set to 1 upon starting
- Start recording hotkey
	- An optional hotkey for the purpose of starting a recording of the set
	- Set this to whatever start recording hotkey you use with your software
- Stop recording hotkey
	- An optional hotkey for the purpose of stopping a recording of the set
	- Set this to whatever stop recording hotkey you use with your software
	- If either of these hotkeys are left blank or do not parse this functionality is disabled
- Display Hitboxes
	- This will display in-game hitboxes during playback
- Display Inputs
	- This will display both players inputs during playback
- Display Attack Data
	- This will display attack data during playback

By default the program assumes that in SG:
	- LP is bound to the A button
	- LK is bound to the Z button
	- MP is bound to the S button
	- Right is bound to the right button
This can be changed by editing the config file included with the program.
The default settings for all the forms can be changed in the config file as well.

If at any point during the viewing process SG is not open the viewing process will stop.