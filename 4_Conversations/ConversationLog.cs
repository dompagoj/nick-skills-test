using System;

namespace Conversations
{
    public class ConversationLog
    {
        public int Id { get; init; }
        public DateTime Timestamp { get; init; }
        public string Name { get; init; }
        public string Message { get; init; }
    }
}
