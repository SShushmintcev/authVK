using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Photo : IPhoto
  {
    /// <summary>
    /// Идентификатор фотографии.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор альбома, в котором находится фотография.
    /// </summary>
    [JsonProperty("album_id")]
    public int AlbumId { get; set; }

    /// <summary>
    /// Идентификатор владельца фотографии.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Идентификатор пользователя, загрузившего фото 
    /// (если фотография размещена в сообществе).
    /// Для фотографий, размещенных от имени сообщества, user_id = 100.
    /// </summary>
    [JsonProperty("user_id")]
    public int UserId { get; set; }

    /// <summary>
    /// Текст описания фотографии.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Дата добавления в формате unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Массив с копиями изображения в разных размерах.
    /// См.Формат описания размеров фотографии.
    /// Поле возвращается только при передаче параметра photo_sizes = 1 в запросе.
    /// Если параметр не передан, вместо поля sizes возвращаются поля, описанные ниже.
    /// </summary>
    [JsonProperty]
    public List<Size> Sizes { get; set; }

    IEnumerable<ISize> IPhoto.Sizes
    {
      get { return Sizes; }
    }

    /// <summary>
    /// URL копии фотографии с максимальным размером 75x75px.
    /// </summary>
    [JsonProperty("photo_75")]
    public string PhotoMinilUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 130x130px.
    /// </summary>
    [JsonProperty("photo_130")]
    public string PhotoSmallUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 604x604px.
    /// </summary>
    [JsonProperty("photo_604")]
    public string PhotoMediumUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 807x807px.
    /// </summary>
    [JsonProperty("photo_807")]
    public string PhotoLargeUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 1280x1024px.
    /// </summary>
    [JsonProperty("photo_1280")]
    public string PhotoExtraUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 2560x2048px.
    /// </summary>
    [JsonProperty("photo_2560")]
    public string PhotoDoubleExtraUrl { get; set; }

    /// <summary>
    /// Ширина оригинала фотографии в пикселах.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота оригинала фотографии в пикселах.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Ключ доступа к объекту.
    /// </summary>
    [JsonProperty("access_key")]
    public string AccessKey { get; set; }
  }
}