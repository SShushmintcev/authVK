using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class CurrentAccountInfoFilter : ICurrentAccountInfoFilter
  {
    /// <summary>
    /// Имя настройки.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Значение настройки.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Битовая маска, отвечающая за прохождение обучения в мобильных клиентах.
    /// </summary>
    public int Intro { get; set; }

    /// <summary>
    /// Признак отображения записей на стене пользователя.
    /// True - на стене пользователя по умолчанию должны отображаться только собственные записи.
    /// False - на стене пользователя должны отображаться все записи.
    /// </summary>
    public bool IsPostsDefault { get; set; }

    /// <summary>
    /// Признак отключения комментирования записей на стене.
    /// True - отключить комментирование записей на стене.
    /// False - разрешить комментирование.
    /// </summary>
    public bool IsNoWallReplies { get; set; }
  }
}