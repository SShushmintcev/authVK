using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface IAccount
  {
    /// <summary>
    /// Строковой код страны, определенный по IP адресу, с которого сделан запрос.
    /// </summary>
    string Country {get;set;}

    /// <summary>
    /// Включено ли безопасное соединение для аккаунта.
    /// </summary>
    bool IsHttpsRequired {get;set;}

    /// <summary>
    /// Включена ли двухфакторная аутентификация для аккаунта.
    /// </summary>
    bool Is2FaRequired {get;set;}

    /// <summary>
    /// Показываются ли по умолчанию на стене только записи пользователя.
    /// </summary>
    bool OwnPostsDefault {get;set;}

    /// <summary>
    /// Отключено ли комментирование записей на стене.
    /// </summary>
    bool NoWallReplies {get;set;}

    /// <summary>
    /// Прошел ли пользователь обучение по использованию приложения.
    /// </summary>
    bool IsIntro {get;set;}

    /// <summary>
    /// Идентификатор текущего языка пользователя.
    /// </summary>
    LangType Lang {get;set;}
  }
}