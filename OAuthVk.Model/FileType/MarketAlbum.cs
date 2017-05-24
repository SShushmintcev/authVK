using System;
using Newtonsoft.Json;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class MarketAlbum : IMarketAlbum
  {
    /// <summary>
    /// Идентификатор подборки.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца подборки.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Название подборки.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Обложка подборки, объект, описывающий фотографию.
    /// </summary>
    [JsonProperty]
    public Photo Photo { get; set; }

    /// <summary>
    /// Обложка подборки, объект, описывающий фотографию.
    /// </summary>
    IPhoto IMarketAlbum.Photo => Photo;

    /// <summary>
    /// Число товаров в подборке.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Дата обновления подборки в формате Unixtime.
    /// </summary>
    [JsonProperty("updated_time")]
    public int UpdatedTime { get; set; }
  }
}