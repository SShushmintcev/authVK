using System;
using System.Collections.Generic;

namespace OAuthVk.Core.FileType
{
  public interface IWall
  {
    /// <summary>
    /// Идентификатор записи.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца стены, на которой размещена запись.
    /// В версиях API ниже 5.7 это поле называется to_id.
    /// </summary>
    int? OwnerId { get; set; }

    /// <summary>
    /// Идентификатор владельца стены, на которой размещена запись.
    /// Для версии ниже 5.7.
    /// </summary>
    int? ToId { get; set; }

    /// <summary>
    /// Идентификатор автора записи.
    /// </summary>
    int FromId { get; set; }

    /// <summary>
    /// Время публикации записи в формате unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Текст записи.
    /// </summary>
    string Text { get; set; }

    /// <summary>
    /// Идентификатор владельца записи, в ответ на которую была оставлена текущая.
    /// </summary>
    int ReplyOwnerId { get; set; }

    /// <summary>
    /// Идентификатор записи, в ответ на которую была оставлена текущая.
    /// </summary>
    int ReplyPostId { get; set; }

    /// <summary>
    /// 1, если запись была создана с опцией «Только для друзей».
    /// </summary>
    int FriendsOnly { get; set; }

    /// <summary>
    /// Информация о комментариях к записи.
    /// </summary>
    IComments Comments { get; }

    /// <summary>
    /// Информация о лайках к записи.
    /// </summary>
    ILike Likes { get; }

    /// <summary>
    /// Информация о репостах записи «Рассказать друзьям».
    /// </summary>
    IRepost Reposts { get; }

    /// <summary>
    /// Информация о просмотрах записи.
    /// </summary>
    ICount Views { get; }

    /// <summary>
    /// Тип записи, может принимать следующие значения: post, copy, reply, postpone, suggest.
    /// </summary>
    string PostType { get; set; }

    /// <summary>
    /// Поле возвращается только для Standalone-приложений с ключом доступа, полученным в Implicit Flow.
    /// Информация о способе размещения записи.
    /// </summary>
    IPostSource PostSource { get; }

    /// <summary>
    /// Медиавложения записи (фотографии, ссылки и т.п.).
    /// </summary>
    IEnumerable<IAttachment> Attachments { get; }

    /// <summary>
    /// Информация о местоположении.
    /// </summary>
    IGeo Geo { get; }

    /// <summary>
    /// Идентификатор автора, если запись была опубликована от имени сообщества и подписана пользователем.
    /// </summary>
    int? SignerId { get; set; }

    /// <summary>
    /// Массив, содержащий историю репостов для записи.
    /// Возвращается только в том случае, если запись является репостом.
    /// Каждый из объектов массива, в свою очередь, является объектом-записью стандартного формата.
    /// </summary>
    /// TODO: Что за тип массива?
    Array CopyHistory { get; set; }

    /// <summary>
    /// Может ли текущий пользователь закрепить запись.
    /// </summary>
    bool IsPin { get; set; }

    /// <summary>
    /// Может ли текущий пользователь удалить запись.
    /// </summary>
    bool IsDelete { get; set; }

    /// <summary>
    /// Может ли текущий пользователь редактировать запись.
    /// </summary>
    bool IsEdit { get; set; }

    /// <summary>
    /// Признак того, что запись закреплена.
    /// </summary>
    bool IsPinned { get; set; }

    /// <summary>
    /// Содержит ли запись отметку "реклама".
    /// </summary>
    bool MarkedAsAds { get; set; }
  }
}