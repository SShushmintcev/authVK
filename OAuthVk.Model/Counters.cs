using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Counters : ICounters
  {
    /// <summary>
    /// Количество Фотоальбомов.
    /// </summary>
    public int Albums { get; set; }

    /// <summary>
    /// Количество Видеозаписей.
    /// </summary>
    public int Videos { get; set; }

    /// <summary>
    /// Количество Аудиозаписей.
    /// </summary>
    public int Audios { get; set; }

    /// <summary>
    /// Количество Фотографий.
    /// </summary>
    public int Photos { get; set; }

    /// <summary>
    /// Количество Заметок.
    /// </summary>
    public int Notes { get; set; }

    /// <summary>
    /// Количество Друзей.
    /// </summary>
    public int Friends { get; set; }

    /// <summary>
    /// Количество Сообществ.
    /// </summary>
    public int Groups { get; set; }

    /// <summary>
    /// Количество Друзей онлайн.
    /// </summary>
    [JsonProperty("online_friends")]
    public int OnlineFriends { get; set; }

    /// <summary>
    /// Количество Общих друзей.
    /// </summary>
    [JsonProperty("mutual_friends")]
    public int MutualFriends { get; set; }

    /// <summary>
    /// Количество Видеозаписей с Пользователем.
    /// </summary>
    [JsonProperty("user_videos")]
    public int UserVideos { get; set; }

    /// <summary>
    /// Количество Подписчиков.
    /// </summary>
    public int Followers { get; set; }

    /// <summary>
    /// Количество Объектов в Блоке «Интересные Страницы».
    /// </summary>
    public int Pages { get; set; }

    /// <summary>
    /// Количество топиков.
    /// </summary>
    public int Topics { get; set; }

    /// <summary>
    /// Количество документов.
    /// </summary>
    public int Docs { get; set; }
  }
}