namespace BlazorStreamingChatApp.Core.Chat.Entities
{
    using System;
    using System.Collections.Generic;

    public class ChatRoom
    {
        public Guid Id { get; set; }
        public string ChatRoomName { get; set; }
        public List<ChatUser> Users { get; set; }
    }
}
