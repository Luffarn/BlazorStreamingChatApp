using BlazorStreamingChatApp.Core.Chat.Entities;
using BlazorStreamingChatApp.UI.Server.DataStore;
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

        public ChatController(ILogger<ChatController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ChatRoom GetRoom(Guid id)
        {
            var chatRoom = ChatHandler.GetChat(id);
            return chatRoom;
        }

        [HttpPost]
        public void AddRoom(ChatRoom room)
        {
            ChatHandler.AddRoom(room);
        }
    }
}