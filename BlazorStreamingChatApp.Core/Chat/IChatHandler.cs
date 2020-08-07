namespace BlazorStreamingChatApp.Core.Chat
{
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using System;

    public interface IChatHandler
    {
        void AddRoom(ChatRoom room);
        ChatRoom GetChat(Guid id);
    }
}