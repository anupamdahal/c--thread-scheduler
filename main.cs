using System;
using System.Threading;

namespace Producer_Consumer_Pattern{

    class PMain{
        static void Main(string[] args){
            SyncQueue queue = new SyncQueue(25);
            Producer producer = new Producer(queue, 25);
            Consumer consumer = new Consumer(queue, 25);
            // Console.Write("Adding Jobs");
            Thread t1 = new Thread(new ThreadStart(consumer.run)).Start();
            Thread t2 = new Thread(new ThreadStart(consumer.run)).Start();
            Thread t3 = new Thread(new ThreadStart(consumer.run)).Start();
            t1.Join();
            t2.Join();
            t3.Join();
            // Console.Write(producer.queue);
        }
    }
    
}