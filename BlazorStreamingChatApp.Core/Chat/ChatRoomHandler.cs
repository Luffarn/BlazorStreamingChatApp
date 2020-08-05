namespace BlazorStreamingChatApp.Core.Chat
{
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using BlazorStreamingChatApp.Core.Chat.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChatRoomHandler : IChatRoomHandler
    {
        private List<ChatRoom> _chatRooms = new List<ChatRoom>();
        public ChatRoomHandler()
        {

        }

        public void AddChatRoom(ChatRoom chatRoom)
        {
            _chatRooms.Add(chatRoom);
        }

        public ChatRoom GetChatRoom(Guid id)
        {
            return _chatRooms.SingleOrDefault(x => x.Id == id);
        }
    }
}
