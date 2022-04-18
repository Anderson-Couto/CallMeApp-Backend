using Microsoft.AspNetCore.SignalR;

namespace CallMe.Backend.Hub
{
    public class Chat : Microsoft.AspNetCore.SignalR.Hub
    {
        public void NewMessage(string userName, string message)
        {
            Clients.All.SendAsync("newMessage", userName, message);
        }
    }
}