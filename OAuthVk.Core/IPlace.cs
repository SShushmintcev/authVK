namespace OAuthVk.Core
{
  public interface IPlace
  {
    /// <summary>
    /// Идентификатор места(если назначено).
    /// </summary>
    int? Id {get;set;}

    /// <summary>
    /// Название места(если назначено).
    /// </summary>
    string Title {get;set;}

    /// <summary>
    /// Географическая широта.
    /// </summary>
    double Latitude {get;set;}

    /// <summary>
    /// Географическая долгота.
    /// </summary>
    double Longitude {get;set;}

    /// <summary>
    /// Дата создания(если назначено).
    /// </summary>
    int? Created {get;set;}

    /// <summary>
    /// URL изображения-иконки.
    /// </summary>
    string Icon {get;set;}

    /// <summary>
    /// Название страны.
    /// </summary>
    string Country {get;set;}

    /// <summary>
    /// Название города.
    /// </summary>
    string City {get;set;}
  }
}