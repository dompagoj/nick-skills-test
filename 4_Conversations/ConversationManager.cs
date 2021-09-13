using System;
using System.Collections.Concurrent;

namespace Conversations
{
    public class ConversationManager
    {
        ConcurrentDictionary<int, Conversation> Conversations { get; init; } = new();

        public void AddConversation(Conversation conversation)
        {
            Conversations.TryAdd(conversation.Id, conversation);
        }

        public void RemoveConversation(int id)
        {
            Conversations.TryRemove(id, out _);
        }

        public void Test()
        {
            Console.WriteLine($"Conv count: {Conversations.Count}");
        }
    }
}
