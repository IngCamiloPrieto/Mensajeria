namespace Mensajeria.IC.Acciones
{
    using System.Threading.Tasks;

    public interface IMensajeriaAccionCliente
    {
        Task RecibirMensaje(string mensaje);
    }
}