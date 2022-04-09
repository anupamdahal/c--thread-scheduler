using System;
using System.Threading;

namespace Producer_Consumer_Pattern
{
  public class Consumer{
    public SyncQueue queue;
    private int noJobs;
    private int producedJobs = 0;

    public Consumer(SyncQueue queue, int noJobs ){
      this.queue = queue;
      this.noJobs = noJobs;
    }

    public void run(){
      while(this.producedJobs < this.noJobs){
        JobNode = this.queue.pop();
        this.sleep(JobNode);
      }
    }

    private void sleep(JobNode node){
      Console.WriteLine($"Job with id {node.id} sleeping for {node.time} seconds.");
      Thread.Sleep(node.time);
    }
  }
}