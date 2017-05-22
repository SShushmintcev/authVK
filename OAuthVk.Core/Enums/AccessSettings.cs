using System;

namespace OAuthVk.Core.Enums
{
  [Flags]
  public enum AccessSettings
  {
    /// <summary>
    /// Пользователь разрешил отправлять ему уведомления (для flash/iframe-приложений).
    /// </summary>
    Notify = 1,

    /// <summary>
    /// Доступ к друзьям.
    /// </summary>
    Friends = 2,

    /// <summary>
    /// Доступ к фотографиям.
    /// </summary>
    Photos = 4,

    /// <summary>
    /// Доступ к аудиозаписям.
    /// </summary>
    Audio = 8,

    /// <summary>
    /// Доступ к видеозаписям.
    /// </summary>
    Video = 16,

    /// <summary>
    /// Доступ к wiki-страницам.
    /// </summary>
    Pages = 128,

    //+256	Добавление ссылки на приложение в меню слева.

    /// <summary>
    /// Доступ к статусу пользователя.
    /// </summary>
    Status = 1024,

    /// <summary>
    /// Доступ к заметкам пользователя.
    /// </summary>
    Notes = 2048,

    /// <summary>
    /// Доступ к расширенным методам работы с сообщениями (только для Standalone-приложений).
    /// </summary>
    Messages = 4096,

    /// <summary>
    /// Доступ к обычным и расширенным методам работы со стеной. Данное право доступа по умолчанию недоступно для сайтов при использовании OAuth-авторизации (игнорируется при попытке авторизации).
    /// </summary>
    Wall = 8192,

    /// <summary>
    /// Доступ к расширенным методам работы с рекламным API.
    /// </summary>
    Ads = 32768,

    /// <summary>
    /// Доступ к API в любое время (при использовании этой опции параметр expires_in, возвращаемый вместе с access_token, содержит 0 — токен бессрочный). Не применяется в Open API.
    /// </summary>
    Offline = 65536,

    /// <summary>
    /// Доступ к документам.
    /// </summary>
    Docs = 131072,

    /// <summary>
    /// Доступ к группам пользователя.
    /// </summary>
    Groups = 262144,

    /// <summary>
    /// Доступ к оповещениям об ответах пользователю.
    /// </summary>
    Notifications = 524288,

    /// <summary>
    /// Доступ к статистике групп и приложений пользователя, администратором которых он является.
    /// </summary>
    Stats = 1048576,

    /// <summary>
    /// Доступ к email пользователя.
    /// </summary>
    Email = 4194304,

    /// <summary>
    /// Доступ к товарам.
    /// </summary>
    Market = 134217728,

    All = Market | Email | Stats | Notifications | Groups | Docs | Ads | Messages | Notes | Status | Pages | Video | Audio | Photos | Friends | Notify
  }
}