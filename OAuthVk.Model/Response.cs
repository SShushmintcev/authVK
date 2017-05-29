using System.Collections.Generic;

namespace OAuthVk.Model
{
  public class Result<T>
  {
    public Response<T> Response { get; set; }
    //public List<User> Response { get; set; }
  }

  public class Response<T>
  {
    public int Count { get; set; }

    public List<T> Items { get; set; }
  }
}