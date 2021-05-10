namespace Mensajeria.API.Hubs
{
    using Mensajeria.IC.Acciones;
    using Microsoft.AspNetCore.SignalR;
    using System;
    using System.Threading.Tasks;

    public class MensajeriaHub : Hub<IMensajeriaAccionCliente>
    {
        public async Task EnviarMensaje(string idSala, string mensaje)
        {
            await Clients.Group(idSala).RecibirMensaje(mensaje);
        }

        public async Task ConectarseASala(string idSala)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, idSala);
        }

        //Prueba
        public async Task DesconectarseDeSala(string idSala)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, idSala);
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
    }
}