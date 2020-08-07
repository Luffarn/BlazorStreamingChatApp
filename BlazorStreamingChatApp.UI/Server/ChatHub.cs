namespace BlazorSignalRApp.Server.Hubs
{
    using BlazorStreamingChatApp.Core.Chat;
    using BlazorStreamingChatApp.Core.Chat.Entities;
    using Microsoft.AspNetCore.SignalR;
    using System;
    using System.Threading.Tasks;

    public class ChatHub : Hub
    {
        private readonly IChatHandler chatHandler;

        public ChatHub(IChatHandler chatHandler)
        {
            this.chatHandler = chatHandler;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task ConnectUser(string userName, Guid chatRoomId)
        {
            var user = new ChatUser
            {
                Id = Guid.NewGuid(),
                Name = userName
            };

            var chatRoom = chatHandler.GetChat(chatRoomId);
            chatRoom.AddUser(user);

            await Clients.All.SendAsync("UserConnected", user);
        }
    }
}