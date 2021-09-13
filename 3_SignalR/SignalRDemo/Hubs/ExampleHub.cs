using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo.DTOs;

namespace SignalRDemo.Hubs
{
    public interface IExampleHub
    {
        Task ClientMethod(ComplexDataType complexDataType);
        Task OnClientConnected(ComplexDataType complexDataType);
    }

    public class ExampleHub : Hub<IExampleHub>
    {
        public override Task OnConnectedAsync()
        {
            Clients.All.OnClientConnected(new() {SomeValue = "Sent to all the clients!"});
            Clients.Caller.ClientMethod(new() {SomeValue = "Sent to single client"});

            return base.OnConnectedAsync();
        }

        public void ServerMethod(ComplexDataType complexDataType)
        {
            Console.WriteLine(JsonSerializer.Serialize(complexDataType));
        }
    }
}
