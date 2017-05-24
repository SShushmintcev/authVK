using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Repost : IRepost
  {
    /// <summary>
    /// Количество.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Наличие репоста от текущего пользователя.
    /// </summary>
    [JsonProperty("user_reposted")]
    public bool UserReposted { get; set; }
  }
}