namespace OAuthVk.Core
{
  public interface ICounters
  {
    /// <summary>
    /// Количество Фотоальбомов.
    /// </summary>
    int? Albums { get; set; }

    /// <summary>
    /// Количество Видеозаписей.
    /// </summary>
    int? Videos { get; set; }

    /// <summary>
    /// Количество Аудиозаписей.
    /// </summary>
    int? Audios { get; set; }

    /// <summary>
    /// Количество Фотографий.
    /// </summary>
    int? Photos { get; set; }

    /// <summary>
    /// Количество Заметок.
    /// </summary>
    int? Notes { get; set; }

    /// <summary>
    /// Количество Друзей.
    /// </summary>
    int? Friends { get; set; }

    /// <summary>
    /// Предлагаемые друзья.
    /// </summary>
    int? FriendsSuggestions { get; set; }

    /// <summary>
    /// Количество Сообществ.
    /// </summary>
    int? Groups { get; set; }

    /// <summary>
    /// Количество Друзей онлайн.
    /// </summary>
    int? OnlineFriends { get; set; }

    /// <summary>
    /// Количество Общих друзей.
    /// </summary>
    int? MutualFriends { get; set; }

    /// <summary>
    /// Количество Видеозаписей с Пользователем.
    /// </summary>
    int? UserVideos { get; set; }

    /// <summary>
    /// Количество Подписчиков.
    /// </summary>
    int? Followers { get; set; }

    /// <summary>
    /// Количество Объектов в Блоке «Интересные Страницы».
    /// </summary>
    int? Pages { get; set; }

    /// <summary>
    /// Количество топиков.
    /// </summary>
    int? Topics { get; set; }

    /// <summary>
    /// Количество документов.
    /// </summary>
    int? Docs { get; set; }

    /// <summary>
    /// Количество подарков.
    /// </summary>
    int? Gifts { get; set; }

    /// <summary>
    /// Количество событий.
    /// </summary>
    int? Events { get; set; }

    /// <summary>
    /// Количество ответов.
    /// </summary>
    int? Notifications { get; set; }

    /// <summary>
    /// Количество новых сообщений.
    /// </summary>
    int? Messages { get; set; }

    /// <summary>
    /// Количество запросов в мобильных играх.
    /// </summary>
    int? Sdk { get; set; }

    /// <summary>
    /// Количество уведомлений от приложений.
    /// </summary>
    int? AppRequests { get; set; }
  }
}