using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;
using OAuthVk.Model.FileType;

namespace OAuthVk.Model
{
  [Serializable]
  public class Preview : IPreview
  {
    /// <summary>
    /// Изображения для предпросмотра.
    /// </summary>
    [JsonProperty]
    public Photo Photo { get; set; }

    /// <summary>
    /// Данные о граффити.
    /// </summary>
    [JsonProperty]
    public Size Graffiti { get; set; }

    /// <summary>
    /// Данные об аудиосообщении.
    /// </summary>
    [JsonProperty("audio_msg")]
    public Audio AudioMsg { get; set; }

    /// <summary>
    /// Изображения для предпросмотра.
    /// </summary>
    IPhoto IPreview.Photo => Photo;

    /// <summary>
    /// Данные о граффити.
    /// </summary>
    ISize IPreview.Graffiti => Graffiti;

    /// <summary>
    /// Данные об аудиосообщении.
    /// </summary>
    IAudio IPreview.AudioMsg => AudioMsg;
  }
}
