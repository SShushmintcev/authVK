using System;
using Newtonsoft.Json;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Sticker : ISticker
  {
    /// <summary>
    /// Идентификатор стикера.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор набора.
    /// </summary>
    [JsonProperty("product_id")]
    public int ProductId { get; set; }

    /// <summary>
    /// URL изображения с высотой 64 px.
    /// </summary>
    [JsonProperty("photo_64")]
    public string Photo64 { get; set; }

    /// <summary>
    /// URL изображения с высотой 128 px.
    /// </summary>
    [JsonProperty("photo_128")]
    public string Photo128 { get; set; }

    /// <summary>
    /// URL изображения с высотой 256 px.
    /// </summary>
    [JsonProperty("photo_256")]
    public string Photo256 { get; set; }

    /// <summary>
    /// URL изображения с высотой 352 px.
    /// </summary>
    [JsonProperty("photo_352")]
    public string Photo352 { get; set; }

    /// <summary>
    /// Ширина в px.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота в px.
    /// </summary>
    public int Height { get; set; }
  }
}