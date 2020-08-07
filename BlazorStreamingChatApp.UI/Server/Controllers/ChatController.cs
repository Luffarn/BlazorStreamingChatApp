using BlazorStreamingChatApp.Core.Chat;
using BlazorStreamingChatApp.Core.Chat.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BlazorStreamingChatApp.UI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ILogger<ChatController> logger;
        private readonly IChatHandler chatHandler;

        public ChatController(ILogger<ChatController> logger,
                              IChatHandler chatHandler)
        {
            this.logger = logger;
            this.chatHandler = chatHandler;
        }

        [HttpGet]
        public ChatRoom GetRoom(Guid id)
        {
            var chatRoom = chatHandler.GetChat(id);
            return chatRoom;
        }

        [HttpPost]
        public void AddRoom(ChatRoom room)
        {
            chatHandler.AddRoom(room);
        }
    }
}