using System;

namespace Producer_Consumer_Pattern{

    class PMain{
        static void Main(string[] args){
            SyncQueue queue = new SyncQueue(25);
            Producer producer = new Producer(queue, 25);
            // Console.Write("Adding Jobs");
            producer.run();
            // Console.Write(producer.queue);
        }
    }
    
}