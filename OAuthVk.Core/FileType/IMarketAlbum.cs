namespace OAuthVk.Core.FileType
{
  public interface IMarketAlbum
  {
    /// <summary>
    /// Идентификатор подборки.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца подборки.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Название подборки.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Обложка подборки, объект, описывающий фотографию.
    /// </summary>
    IPhoto Photo { get; }

    /// <summary>
    /// Число товаров в подборке.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// Дата обновления подборки в формате Unixtime.
    /// </summary>
    int UpdatedTime { get; set; }
  }
}