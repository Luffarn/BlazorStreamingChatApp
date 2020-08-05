namespace BlazorStreamingChatApp.Core.Chat.Interfaces
{
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using System;

    public interface IChatRoomHandler
    {
        void AddChatRoom(ChatRoom chatRoom);
        ChatRoom GetChatRoom(Guid id);
    }
}