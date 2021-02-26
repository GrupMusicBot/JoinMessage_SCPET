# JoinMessage_SCPET
## Requires the latest version of Census

A really simple plugin to display a message on the players screen when they join.

**Installation**
1. Download the JoinMessage_SCPET.dll from the Releases Tab
2. Drag into your Plugins Folder
3. Start the Server, and configure the plugin in /CensusConfigs/JoinMessage.json
4. Restart and Enjoy


Config Example:
```
{
  "IsEnabled": true,
  "BroadcastMessageEnabled": true,
  "BroadcastMessage": "<color=green> %player%, Welcome to Your Server Name! </color>",
  "ChatMessageEnabled": true,
  "ChatMessage": "Welcome %player%, Join our Discord at : discord.gg/qvanityurl",
  "MissionMessage": "Have Fun!",
  "MissionMessageEnabled": true,
  "Timer": 5
}
```

The Timer Config is the amount of seconds that the broadcast message is displayed for
