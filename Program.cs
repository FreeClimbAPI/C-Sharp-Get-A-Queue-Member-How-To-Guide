using com.freeclimb.api;
using com.freeclimb.api.queue;

namespace GetQueueMember {
  class Program {

    public static string getFreeClimbAccountId()
    {
      return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
    }

    public static string getFreeClimbAccountToken()
    {
      return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
    }

    static void Main (string[] args) {
      string queueId = "";
      string callId = "";
      // Create FreeClimbClient object
      FreeClimbClient client = new FreeClimbClient (getFreeClimbAccountId (),
        getFreeClimbAccountToken ());

      // Invoke get method to retrieve queued call metadata
      QueueMember queueMember = client.getQueuesRequester.getQueueMember (queueId, callId);
    }
  }
}