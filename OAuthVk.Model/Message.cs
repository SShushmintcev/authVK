using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  public class Message : IMessage
  {
    /// <summary>
    /// Идентификатор сообщения (не возвращается для пересланных сообщений).
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, в диалоге с которым находится сообщение.
    /// </summary>
    [JsonProperty("user_id")]
    public int UserId { get; set; }

    /// <summary>
    /// Идентификатор автора сообщения. положительное число.
    /// </summary>
    [JsonProperty("from_id")]
    public int FromId { get; set; }

    /// <summary>
    /// Дата отправки сообщения в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Признак того, что сообщение прочитано (не возвращается для пересланных сообщений).
    /// </summary>
    [JsonProperty("read_state")]
    public bool? IsRead { get; set; }

    /// <summary>
    /// Тип сообщения (не возвращается для пересланных сообщений).
    /// </summary>
    [JsonProperty("out")]
    public MessageType? TypeMessage { get; set; }

    /// <summary>
    /// Заголовок сообщения или беседы.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Текст сообщения.
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    [JsonProperty]
    public Geo Geo { get; set; }

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    IGeo IMessage.Geo => Geo;

    /// <summary>
    /// Массив пересланных сообщений(если есть).
    /// </summary>
    [JsonProperty("fwd_messages")]
    public IEnumerable<string> FwdMessages { get; set; }

    /// <summary>
    /// Содержатся ли в сообщении emoji-смайлы.
    /// </summary>
    [JsonProperty("emoji")]
    public bool? IsEmoji { get; set; }

    /// <summary>
    /// Является ли сообщение важным.
    /// </summary>
    [JsonProperty("important")]
    public bool? IsImportant { get; set; }

    /// <summary>
    /// Удалено ли сообщение.
    /// </summary>
    [JsonProperty("deleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Идентификатор, используемый при отправке сообщения. Возвращается только для исходящих сообщений.
    /// </summary>
    [JsonProperty("random_id")]
    public int? RandomId { get; set; }

    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    [JsonProperty("chat_id")]
    public int ChatId { get; set; }

    /// <summary>
    /// Идентификаторы авторов последних сообщений беседы.
    /// </summary>
    [JsonProperty("chat_active")]
    public IEnumerable<int> ChatActive { get; set; }

    /// <summary>
    /// Настройки уведомлений для беседы, если они есть.
    /// </summary>
    // TODO: What is this type?
    [JsonProperty("push_settings")]
    public object PushSettings { get; set; }

    /// <summary>
    /// Количество участников беседы.
    /// </summary>
    [JsonProperty("users_count")]
    public int UsersCount { get; set; }

    /// <summary>
    /// Идентификатор создателя беседы.
    /// </summary>
    [JsonProperty("admin_id")]
    public int AdminId { get; set; }

    /// <summary>
    /// Тип действия (если это служебное сообщение).
    /// </summary>
    /// <remarks>
    /// chat_photo_update — обновлена фотография беседы;
    /// chat_photo_remove — удалена фотография беседы;
    /// chat_create — создана беседа;
    /// chat_title_update — обновлено название беседы;
    /// chat_invite_user — приглашен пользователь;
    /// chat_kick_user — исключен пользователь.
    /// </remarks>
    public string Action { get; set; }

    /// <summary>
    /// Идентификатор пользователя (если больше 0) или email (если меньше 0),
    /// которого пригласили или исключили(для служебных сообщений с action = chat_invite_user или chat_kick_user).
    /// </summary>
    [JsonProperty("action_mid")]
    public int? ActionMid { get; set; }

    /// <summary>
    /// Email, который пригласили или исключили
    /// (для служебных сообщений с action = chat_invite_user или chat_kick_user и отрицательным action_mid).
    /// </summary>
    [JsonProperty("action_email")]
    public string ActionEmail { get; set; }

    /// <summary>
    /// Название беседы(для служебных сообщений с action = chat_create или chat_title_update).
    /// </summary>
    [JsonProperty("action_text")]
    public string ActionText { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 50 px.
    /// </summary>
    [JsonProperty("photo_50")]
    public string Photo50 { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 100 px.
    /// </summary>
    [JsonProperty("photo_100")]
    public string Photo100 { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 200 px.
    /// </summary>
    [JsonProperty("photo_200")]
    public string Photo200 { get; set; }
  }
}