using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Chat
{
    public class ChatHub: Hub
    {
        public async Task EnviarMensaje(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("MensajeRecibido",user,message);
        }
        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowWho",$"Alguien se conecta: {Context.ConnectionId}");
        }
    }
}
