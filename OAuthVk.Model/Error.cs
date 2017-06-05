using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Error
  {
    [JsonProperty("error_code")]
    public string Code { get; set; }

    [JsonProperty("error_msg")]
    public string Message { get; set; }

    [JsonProperty("request_params")]
    public ICollection<KeyValuePair<string, string>> Params { get; set; }
  }
}