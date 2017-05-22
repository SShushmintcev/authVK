using System.Collections.Generic;

namespace OAuthVk.Model
{
  public class Result
  {
    public Response Response { get; set; }
    //public List<User> Response { get; set; }
  }

  public class Response
  {
    public int Count { get; set; }

    public List<User> Items { get; set; }
  }
}