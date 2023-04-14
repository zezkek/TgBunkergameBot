using System.Threading;
using System.Threading.Tasks;

namespace TgBunkergameBot.Abstract;

public interface IReceiverService
{
    Task ReceiveAsync(CancellationToken stoppingToken);
}
