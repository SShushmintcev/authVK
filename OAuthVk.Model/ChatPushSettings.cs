using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class ChatPushSettings : IChatPushSettings
  {
    /// <summary>
    /// Идентификатор собеседника.
    /// </summary>
    [JsonProperty("peer_id")]
    public long? PeerId { get; set; }

    /// <summary>
    /// Состояние звукового оповещения.
    /// </summary>
    [JsonProperty("sound")]
    public bool? IsSound { get; set; }

    /// <summary>
    /// Указывает, до какого времени оповещения отключены.
    /// </summary>
    [JsonProperty("disabled_until")]
    public int? DisabledUntil { get; set; }
  }
}