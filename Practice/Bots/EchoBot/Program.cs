// Simplest Telegram Bot

using Telegram.Bot;

string token = File.ReadAllText("token.config");

var client = new TelegramBotClient(token);

client.StartReceiving(
    (c, arg, _) => c.SendTextMessageAsync(
        arg.Message.Chat.Id, "ПРИВЕТ КОМАНДА!!!"),
        (_, _, _) => Task.CompletedTask);

Console.WriteLine("Start echobot...");

Console.ReadLine();