using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Conversations;


var conversation = new Conversation();
var tasks = new List<Task>();

for (var i = 0; i < 10; i++)
{
    var id = i + 1;
    var task = Task.Run(() =>
    {
        conversation.AddLog((new() {Id = id, Message = "asd", Name = "Wut123", Timestamp = DateTime.Now}));
    });
    
    tasks.Add(task);
}

await Task.WhenAll(tasks);

Console.WriteLine($"Log count: {conversation.Logs.Count}");

foreach (var log in conversation)
{
    Console.WriteLine($"Log! {log.Id}");
}
