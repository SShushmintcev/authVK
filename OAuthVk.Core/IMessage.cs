using System.Collections.Generic;
using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface IMessage
  {
    /// <summary>
    /// Идентификатор сообщения (не возвращается для пересланных сообщений).
    /// </summary>
    int? Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, в диалоге с которым находится сообщение.
    /// </summary>
    int UserId { get; set; }

    /// <summary>
    /// Идентификатор автора сообщения. положительное число.
    /// </summary>
    int FromId { get; set; }

    /// <summary>
    /// Дата отправки сообщения в формате Unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Признак того, что сообщение прочитано (не возвращается для пересланных сообщений).
    /// </summary>
    bool? IsRead { get; set; }

    /// <summary>
    /// Тип сообщения (не возвращается для пересланных сообщений).
    /// </summary>
    MessageType? TypeMessage { get; set; } 

    /// <summary>
    /// Заголовок сообщения или беседы.
    /// </summary>
    string Title {get;set;}

    /// <summary>
    /// Текст сообщения.
    /// </summary>
    string Body { get; set; }

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    IGeo Geo { get; }

    /// <summary>
    /// Медиавложения сообщения (фотографии, ссылки и т.п.).
    /// </summary>
    IEnumerable<IAttachment> Attachments { get; }

    /// <summary>
    /// Массив пересланных сообщений(если есть).
    /// </summary>
    IEnumerable<string> FwdMessages { get; }

    /// <summary>
    /// Содержатся ли в сообщении emoji-смайлы.
    /// </summary>
    bool? IsEmoji { get; set; }

    /// <summary>
    /// Является ли сообщение важным.
    /// </summary>
    bool? IsImportant { get; set; }

    /// <summary>
    /// Удалено ли сообщение.
    /// </summary>
    bool? IsDeleted { get; set; }

    /// <summary>
    /// Идентификатор, используемый при отправке сообщения. Возвращается только для исходящих сообщений.
    /// </summary>
    int? RandomId { get; set; }

    #region Дополнительные поля в сообщениях из мультидиалогов

    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    int ChatId { get; set; }

    /// <summary>
    /// Идентификаторы авторов последних сообщений беседы.
    /// </summary>
    IEnumerable<int> ChatActive { get; }

    /// <summary>
    /// Настройки уведомлений для беседы, если они есть.
    /// </summary>
    // TODO: What is this type?
    object PushSettings { get; set; }

    /// <summary>
    /// Количество участников беседы.
    /// </summary>
    int UsersCount { get; set; }

    /// <summary>
    /// Идентификатор создателя беседы.
    /// </summary>
    int AdminId { get; set; }

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
    string Action { get; set; }

    /// <summary>
    /// Идентификатор пользователя (если больше 0) или email (если меньше 0),
    /// которого пригласили или исключили(для служебных сообщений с action = chat_invite_user или chat_kick_user).
    /// </summary>
    int? ActionMid { get; set; }

    /// <summary>
    /// Email, который пригласили или исключили
    /// (для служебных сообщений с action = chat_invite_user или chat_kick_user и отрицательным action_mid).
    /// </summary>
    string ActionEmail { get; set; }

    /// <summary>
    /// Название беседы(для служебных сообщений с action = chat_create или chat_title_update).
    /// </summary>
    string ActionText { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 50 px.
    /// </summary>
    string Photo50 { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 100 px.
    /// </summary>
    string Photo100 { get; set; }

    /// <summary>
    /// URL копии фотографии беседы шириной 200 px.
    /// </summary>
    string Photo200 { get; set; }

    #endregion
  }
}