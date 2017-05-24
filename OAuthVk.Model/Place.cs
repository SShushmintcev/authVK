using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Place : IPlace
  {
    /// <summary>
    /// Идентификатор места(если назначено).
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Название места(если назначено).
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Географическая широта.
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Географическая долгота.
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// Дата создания(если назначено).
    /// </summary>
    public int? Created { get; set; }

    /// <summary>
    /// URL изображения-иконки.
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// Название страны.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Название города.
    /// </summary>
    public string City { get; set; }

    /*
     * TODO: ?
     * Если место добавлено как чекин в сообщество, объект place имеет дополнительные поля:
     * type (integer) — тип чекина;
     * group_id (integer) — идентификатор сообщества;
     * group_photo (string) — URL миниатюры главной фотографии сообщества;
     * checkins (integer) — количество чекинов;
     * updated (integer) — время последнего чекина в Unixtime;
     * address (integer) — адрес;
     */
  }
}