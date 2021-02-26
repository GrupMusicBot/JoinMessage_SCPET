using CensusAPI.Enums;
using CensusAPI.Features;
using CensusCore.Events.Attributes;
using CensusCore.Events.EventArgs.Player;
using PluginFramework.Attributes;
using PluginFramework.Classes;
using PluginFramework.Events.EventsArgs;
using System.IO;
using System;

namespace SCPET_JoinMessage
{
    public class JoinEventHandler : IScript
    {
        [PlayerEvent(PlayerEventType.OnPlayerJoinFinal)]
        public static void OnPlayerJoin(PlayerJoinFinalEvent ev)
        {

            Player player = Player.Get(ev.player);
            string BCMessage = MessageFormatter(player, JoinMessage.Instance.Config.BroadcastMessage);
            string ChatMessage = MessageFormatter(player, JoinMessage.Instance.Config.ChatMessage);
            //Why would you ever need to put the persons name in the Mission Objective? I'm not sure. But alas, its here
            string MissionMessage = MessageFormatter(player, JoinMessage.Instance.Config.MissionMessage);
            if (JoinMessage.Instance.Config.BroadcastMessageEnabled){
                player.Broadcast(BCMessage, JoinMessage.Instance.Config.Timer);
            }
            if (JoinMessage.Instance.Config.ChatMessageEnabled){
                player.SendChatMessage(ChatMessage);
            }
            if (JoinMessage.Instance.Config.MissionMessageEnabled)
            {
                player.AddMission(MissionMessage, false);
            }

            Log.Info($"{player.Nickname} has joined the server!");

        }

        //Woo, no more useless methods
        private static string MessageFormatter(Player player, string Config) =>
            string.IsNullOrEmpty(Config) ? string.Empty : Config.Replace("%player%", player.Nickname);

    }
}
