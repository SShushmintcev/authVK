using System.Collections.Generic;

namespace OAuthVk.Core.FileType
{
  public interface IPhoto
  {
    /// <summary>
    /// Идентификатор фотографии.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор альбома, в котором находится фотография.
    /// </summary>
    int AlbumId { get; set; }

    /// <summary>
    /// Идентификатор владельца фотографии.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Идентификатор пользователя, загрузившего фото 
    /// (если фотография размещена в сообществе).
    /// Для фотографий, размещенных от имени сообщества, user_id = 100.
    /// </summary>
    int UserId { get; set; }

    /// <summary>
    /// Текст описания фотографии.
    /// </summary>
    string Text { get; set; }

    /// <summary>
    /// Дата добавления в формате unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Массив с копиями изображения в разных размерах.
    /// См.Формат описания размеров фотографии.
    /// Поле возвращается только при передаче параметра photo_sizes = 1 в запросе.
    /// Если параметр не передан, вместо поля sizes возвращаются поля, описанные ниже.
    /// </summary>
    IEnumerable<ISize> Sizes { get; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 75x75px.
    /// </summary>
    string PhotoMinilUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 130x130px.
    /// </summary>
    string PhotoSmallUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 604x604px.
    /// </summary>
    string PhotoMediumUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 807x807px.
    /// </summary>
    string PhotoLargeUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 1280x1024px.
    /// </summary>
    string PhotoExtraUrl { get; set; }

    /// <summary>
    /// URL копии фотографии с максимальным размером 2560x2048px.
    /// </summary>
    string PhotoDoubleExtraUrl { get; set; }

    /// <summary>
    /// Ширина оригинала фотографии в пикселах.
    /// </summary>
    int Width { get; set; }

    /// <summary>
    /// Высота оригинала фотографии в пикселах.
    /// </summary>
    int Height { get; set; }

    /// <summary>
    /// Ключ доступа к объекту.Подробнее см.Ключ доступа к данным access_key.
    /// </summary>
    string AccessKey { get; set; }
  }
}