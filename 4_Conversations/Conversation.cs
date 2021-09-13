using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Priority_Queue;

namespace Conversations
{
    public class Conversation : IEnumerable<ConversationLog>
    {
        public int Id { get; set; }
        public SimplePriorityQueue<ConversationLog, int> Logs { get; init; } = new();

        public void AddLog(ConversationLog log)
        {
            Logs.Enqueue(log, log.Id);
        }

        public IEnumerator<ConversationLog> GetEnumerator()
        {
            while (Logs.Count != 0)
            {
                yield return Logs.Dequeue();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
