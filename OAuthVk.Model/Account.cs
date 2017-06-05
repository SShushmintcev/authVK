using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  [Serializable]
  public class Account : IAccount
  {
    /// <summary>
    /// Строковой код страны, определенный по IP адресу, с которого сделан запрос.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Включено ли безопасное соединение для аккаунта.
    /// </summary>
    [JsonProperty("https_required")]
    public bool IsHttpsRequired { get; set; }

    /// <summary>
    /// Включена ли двухфакторная аутентификация для аккаунта.
    /// </summary>
    [JsonProperty("2fa_required")]
    public bool Is2FaRequired { get; set; }

    /// <summary>
    /// Показываются ли по умолчанию на стене только записи пользователя.
    /// </summary>
    [JsonProperty("own_posts_default")]
    public bool OwnPostsDefault { get; set; }

    /// <summary>
    /// Отключено ли комментирование записей на стене.
    /// </summary>
    [JsonProperty("no_wall_replies")]
    public bool NoWallReplies { get; set; }

    /// <summary>
    /// Прошел ли пользователь обучение по использованию приложения.
    /// </summary>
    [JsonProperty("intro")]
    public bool IsIntro { get; set; }

    /// <summary>
    /// Идентификатор текущего языка пользователя.
    /// </summary>
    public LangType Lang { get; set; }
  }
}