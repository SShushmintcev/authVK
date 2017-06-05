namespace OAuthVk.Core.Filters
{
  public interface ICurrentAccountInfoFilter
  {
    /// <summary>
    /// Имя настройки.
    /// </summary>
    string Name {get;set;}

    /// <summary>
    /// Значение настройки.
    /// </summary>
    string Value {get;set;}

    /// <summary>
    /// Битовая маска, отвечающая за прохождение обучения в мобильных клиентах.
    /// </summary>
    int Intro {get;set;}

    /// <summary>
    /// Признак отображения записей на стене пользователя.
    /// True - на стене пользователя по умолчанию должны отображаться только собственные записи.
    /// False - на стене пользователя должны отображаться все записи.
    /// </summary>
    bool IsPostsDefault {get;set;}

    /// <summary>
    /// Признак отключения комментирования записей на стене.
    /// True - отключить комментирование записей на стене.
    /// False - разрешить комментирование.
    /// </summary>
    bool IsNoWallReplies {get;set;}
  }
}