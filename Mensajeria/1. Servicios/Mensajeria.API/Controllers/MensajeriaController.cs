namespace Mensajeria.API.Controllers
{
    using Mensajeria.API.Hubs;
    using Mensajeria.API.Models.Negocio;
    using Mensajeria.IC.Acciones;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.SignalR;
    using Newtonsoft.Json;
    using System.Threading.Tasks;

    [Route("api/Mensajeria")]
    [ApiController]
    public class MensajeriaController : Controller
    {
        public IHubContext<MensajeriaHub, IMensajeriaAccionCliente> Mensajeria { get; }

        public MensajeriaController(IHubContext<MensajeriaHub, IMensajeriaAccionCliente> argMensajeria)
        {
            Mensajeria = argMensajeria;
        }

        [HttpGet]
        public ActionResult<bool> Index()
        {
            return true;
        }

        [HttpPost]
        [Route("EnviarMensaje")]
        public async Task EnviarMensaje(MensajeModel mensaje)
        {
            await Mensajeria.Clients.Group(mensaje.IdSala).RecibirMensaje(JsonConvert.SerializeObject(mensaje));
        }
    }
}