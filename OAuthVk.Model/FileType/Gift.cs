using System;
using Newtonsoft.Json;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Gift : IGift
  {
    /// <summary>
    /// Идентификатор подарка.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// URL изображения 48x48px.
    /// </summary>
    [JsonProperty("thumb_48")]
    public string Photo48 { get; set; }

    /// <summary>
    /// URL изображения 96x96px.
    /// </summary>
    [JsonProperty("thumb_96")]
    public string Photo96 { get; set; }

    /// <summary>
    /// URL изображения 256x256px.
    /// </summary>
    [JsonProperty("thumb_256")]
    public string Photo256 { get; set; }
  }
}