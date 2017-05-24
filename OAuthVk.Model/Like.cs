using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model
{
  [Serializable]
  public class Like : ILike
  {
    /// <summary>
    /// Количество.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Наличие отметки «Мне нравится» от текущего пользователя.
    /// </summary>
    [JsonProperty("user_likes")]
    public bool UserLikes { get; set; }

    /// <summary>
    /// Может ли текущий пользователь поставить отметку «Мне нравится».
    /// </summary>
    [JsonProperty("can_like")]
    public bool CanLike { get; set; }

    /// <summary>
    /// Может ли текущий пользователь сделать репост записи.
    /// </summary>
    [JsonProperty("can_publish")]
    public bool CanPublish { get; set; }
  }
}