namespace BlazorStreamingChatApp.UI.Server.DataStore
{
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ChatHandler
    {
        private static List<ChatRoom> _chatList = new List<ChatRoom>();

        public static void AddRoom(ChatRoom room)
        {
            _chatList.Add(room);
        }

        public static ChatRoom GetChat(Guid id)
        {
            return _chatList.SingleOrDefault(x => x.Id == id);
        }
    }
}
