namespace BlazorStreamingChatApp.Core.Chat
{
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChatHandler : IChatHandler
    {
        private List<ChatRoom> _chatList = new List<ChatRoom>();

        public void AddRoom(ChatRoom room)
        {
            _chatList.Add(room);
        }

        public ChatRoom GetChat(Guid id)
        {
            return _chatList.SingleOrDefault(x => x.Id == id);
        }
    }
}
