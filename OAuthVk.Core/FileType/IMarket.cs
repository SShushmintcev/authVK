using OAuthVk.Core.Enums;

namespace OAuthVk.Core.FileType
{
  public interface IMarket
  {
    /// <summary>
    /// Идентификатор товара.
    /// </summary>
    int Id {get;set;}

    /// <summary>
    /// Идентификатор владельца товара.
    /// </summary>
    int OwnerId {get;set;}

    /// <summary>
    /// Название товара.
    /// </summary>
    string Title {get;set;}

    /// <summary>
    /// Текст описания товара.
    /// </summary>
    string Description {get;set;}

    /// <summary>
    /// Информация о цене.
    /// </summary>
    IPrice Price {get;}

    /// <summary>
    /// Категория товара.
    /// </summary>
    ICategory Category {get;}

    /// <summary>
    /// URL изображения-обложки товара.
    /// </summary>
    string ThumbPhoto {get;set;}

    /// <summary>
    /// Дата создания товара в формате Unixtime.
    /// </summary>
    int Date {get;set;}

    /// <summary>
    /// Статус доступности товара.
    /// </summary>
    AvailabilityProductType Availability {get;set;} 
  }
}