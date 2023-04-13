using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using CancellationTokenSource cts = new CancellationTokenSource();

string token = "";
TelegramBotClient client = new TelegramBotClient(token);

ReceiverOptions receiver = new ReceiverOptions
{
    AllowedUpdates = Array.Empty<UpdateType>()
};

client.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorsAsync,
    receiverOptions: receiver,
    cancellationToken: cts.Token
    );
async Task HandlePollingErrorsAsync(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
{
    throw new NotImplementedException();
}

async Task HandleUpdateAsync(ITelegramBotClient arg1, Update arg2, CancellationToken arg3)
{
    throw new NotImplementedException();
}