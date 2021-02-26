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
            string BCMessage = BroadcastMessageFormatter(player);
            string ChatMessage = ChatMessageFormatter(player);

            player.Broadcast(BCMessage, JoinMessage.Instance.Config.Timer);
            player.SendChatMessage(ChatMessage);
            // player.SteamID doesnt work here. Returns AuthorizedUser
            Log.Info($"{player.Nickname} has joined the server!");

        }

        private static string BroadcastMessageFormatter(Player player) =>
            string.IsNullOrEmpty(JoinMessage.Instance.Config.BroadcastMessage) ? string.Empty : JoinMessage.Instance.Config.BroadcastMessage.Replace("%player%", player.Nickname);

        private static string ChatMessageFormatter(Player player) =>
            string.IsNullOrEmpty(JoinMessage.Instance.Config.ChatMessage) ? string.Empty : JoinMessage.Instance.Config.ChatMessage.Replace("%player%", player.Nickname);

    }
}
