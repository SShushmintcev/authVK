using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Comments : IComments
  {
    /// <summary>
    /// Количество комментариев.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Может ли текущий пользователь комментировать запись.
    /// </summary>
    [JsonProperty("can_post")]
    public bool CanPost { get; set; }
  }
}