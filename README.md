# Map Party Assist

Tool for automatically keeping track of treasure maps opened by players in your party. Also records treasure dungeon statistics.

[![image](https://i.imgur.com/JeyAe7l.png) [![image](https://i.imgur.com/OMK8LPU.png)

## Installation

1. Add "https://raw.githubusercontent.com/wrath16/DalamudPluginRepo/main/pluginmaster.json" to your Custom Plugin Repositories under Settings -> Experimental, then save.
2. Plugin should now appear in the available plugins list and be installable.

## Usage instructions 

### Map tracking:

* Enter '/mparty' into chat to open the window.
* When a player uses a map by touching a treasure chest or entering a portal, it will be automatically recorded with a checkmark.
* Maps can be manually added and removed by right-clicking on each party member's name or checkmarks.
* If someone links a waymark in party chat, it will be noted with a magnifying glass next to their name that you can hover over or click on to open your map with the waymark.
* The most recent party member to use a map will be highlighted in yellow.
* Maps auto-archive after 24 hours, and you can see recent party members' maps until then. You can also clear the slate manually if you're running multiple parties a day.
* A number of customization options for both map and stats tracking are available in the configuration menu opened with '/mpartyconfig' or by pressing the 'Settings' button in the Dalamud plugin installer.

### Treasure dungeon stats:

* Enter '/mpartystats' to open the stats window.
* The "Current" filter only includes duties resulting from maps currently recorded on the main window.

### Important notes:
* Only works with the client language set to English.
* The plugin primarily works by parsing system chat messages. Sometimes it isn't always possible to know exactly who owns a map and the tracker can make mistakes (known cases are listed below), so stay vigilant and correct mistakes as necessary.
* You can use '/mpartydutyresults' to amend the results of a dungeon in the case of a mistake by the tracker or you miss a checkpoint due to a disconnect. Do so at your own risk!
* Use imports to add alternatively-recorded stats when the plugin is unavailable!

## Known issues:

#### Map tracker issues:
* If you are too far away from a party member who successfully uses Dig, the tracker will not know who owns the treasure coffer and will require manual verification.
* If you are too far away from the party member who successfully uses Dig but are within range of another party member who unsucessfully uses Dig, the tracker will assume the latter player is the map owner and will require correction.
* If two or more party members use Dig around the same time and are within range, the tracker will assume the first player to use Dig is the owner of the coffer that spawns, but this is not always the case and should be verified.
* Discarding an opened map generates the same message as using it, and will be added as if it were used.
* If a party member goes offline just as you are entering a portal, this will cancel the portal and can lead to double-counting for Thief's Maps only.
* A party member consuming a Thief's Map immediately after finishing another party member's regular map without entering a portal may result in it not being counted.
* Waiting too long to enter a (non-Thief's Map, non-self-owned) portal can result in double counting, as can restarting the game or Dalamud.
