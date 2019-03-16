using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace DrawWithMe
{
    public class DrawHub : Hub {  
        public async Task Send(string message){
            await Clients.All.SendAsync("NewMessage", message);
        }

        public async Task newStroke(Point start, Point end) {
            await Clients.Others.SendAsync("newStroke", start, end);
        }
    }
}