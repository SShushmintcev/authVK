using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Market : IMarket
  {
    /// <summary>
    /// Идентификатор товара.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца товара.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Название товара.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Текст описания товара.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Информация о цене.
    /// </summary>
    [JsonProperty]
    public Price Price { get; set; }

    /// <summary>
    /// Информация о цене.
    /// </summary>
    IPrice IMarket.Price => Price;

    /// <summary>
    /// Категория товара.
    /// </summary>
    [JsonProperty]
    public Category Category { get; set; }

    /// <summary>
    /// Категория товара.
    /// </summary>
    ICategory IMarket.Category => Category;

    /// <summary>
    /// URL изображения-обложки товара.
    /// </summary>
    [JsonProperty("thumb_photo")]
    public string ThumbPhoto { get; set; }

    /// <summary>
    /// Дата создания товара в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Статус доступности товара.
    /// </summary>
    public AvailabilityProductType Availability { get; set; }
  }
}