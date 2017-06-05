using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class PushNotification : IPushNotification
  {
    /// <summary>
    /// Личные сообщения.Может принимать массив значений:
    /// no_sound - отключить звук;
    /// no_text - не передавать текст сообщения.
    /// </summary>
    public string Msg { get; set; }

    /// <summary>
    /// Групповые чаты. Может принимать массив значений:
    /// no_sound - отключить звук;
    /// no_text - не передавать текст сообщения.
    /// </summary>
    public string Chat { get; set; }

    /// <summary>
    /// Запрос на добавления в друзья.Может принимать массив значений:
    /// mutual - уведомлять только при наличии общих друзей.
    /// </summary>
    public string Friend { get; set; }

    /// <summary>
    /// Регистрация импортированного контакта.
    /// </summary>
    [JsonProperty("friend_found")]
    public string FriendFound { get; set; }

    /// <summary>
    /// Подтверждение заявки в друзья.
    /// </summary>
    [JsonProperty("friend_accepted")]
    public string FriendAccepted { get; set; }

    /// <summary>
    /// Ответы.
    /// </summary>
    public string Reply { get; set; }

    /// <summary>
    /// Комментарии. Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Упоминания.Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    public string Mention { get; set; }

    /// <summary>
    /// Отметки "Мне нравится". Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    public string Like { get; set; }

    /// <summary>
    /// Действия "Рассказать друзьям". Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    public string Repost { get; set; }

    /// <summary>
    /// Новая запись на стене пользователя.
    /// </summary>
    [JsonProperty("wall_post")]
    public string WallPost { get; set; }

    /// <summary>
    /// Размещение предложенной новости.
    /// </summary>
    [JsonProperty("wall_publish")]
    public string WallPublish { get; set; }

    /// <summary>
    /// Приглашение в сообщество.
    /// </summary>
    [JsonProperty("group_invite")]
    public string GroupInvite { get; set; }

    /// <summary>
    /// Подтверждение заявки на вступление в группу.
    /// </summary>
    [JsonProperty("group_accepted")]
    public string GroupAccepted { get; set; }

    /// <summary>
    /// Ближайшие мероприятия.
    /// </summary>
    [JsonProperty("event_soon")]
    public string EventSoon { get; set; }

    /// <summary>
    /// Отметки на фотографиях.Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    [JsonProperty("tag_photo")]
    public string TagPhoto { get; set; }

    /// <summary>
    /// Запросы в приложениях.
    /// </summary>
    [JsonProperty("app_request")]
    public string AppRequest { get; set; }

    /// <summary>
    /// Установка приложения.
    /// </summary>
    [JsonProperty("sdk_open")]
    public string SdkOpen { get; set; }

    /// <summary>
    /// Записи выбранных людей и сообществ.
    /// </summary>
    [JsonProperty("new_post")]
    public string NewPost { get; set; }

    /// <summary>
    /// Уведомления о днях рождениях на текущую дату.
    /// </summary>
    public string Birthday { get; set; }
  }
}